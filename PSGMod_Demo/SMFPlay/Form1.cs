using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using SmfLite;          // from https://github.com/keijiro/smflite

namespace SMFPlay
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ArrayList SoundEventData;
        PsgCtlcs CTL;

        /// <summary>
        /// ファイルのロードボタンイベント
        /// SMF(midiファイル)のパーズを行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.FileName = "";
            openfile.Filter = "MIDI FIle(*.mid;*midi)|*mid;*midi|OtherFiles(*.*)|*.*";
            openfile.RestoreDirectory = true;

            if(openfile.ShowDialog() == DialogResult.OK)
            {
                textBoxFileName.Text = openfile.FileName;
                parseMIDI(openfile.FileName);
            }
        }

        /// <summary>
        /// 再生ボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(SoundEventData == null)
            {
                MessageBox.Show("SMFファイルが読み込まれていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CTL = null;
            try {
                CTL = new PsgCtlcs(textBoxCOM.Text);
            }
            catch
            {
                MessageBox.Show("COMポートが開けませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double previousTime = 0;
            for(int i=0; i<SoundEventData.Count; i++)
            {
                SoundData sd = (SoundData)SoundEventData[i];

                double deltaTime = sd.Time - previousTime;
                System.Threading.Thread.Sleep((int)(deltaTime * (double)numericUpDownTempo.Value));

                //YMZ294には矩形波発生器が3系統しかないから、3ch分だけ再生
                if (sd.NoteControl == true)
                {
                    if (sd.Channel == 0) { CTL.Set(PsgCtlcs.Ch.A, (uint)sd.NoteNumber); }
                    if (sd.Channel == 1) { CTL.Set(PsgCtlcs.Ch.B, (uint)sd.NoteNumber); }
                    if (sd.Channel == 2) { CTL.Set(PsgCtlcs.Ch.C, (uint)sd.NoteNumber); }
                }
                else
                {
                    if (sd.Channel == 0) { CTL.Set(PsgCtlcs.Ch.A, 128); }
                    if (sd.Channel == 1) { CTL.Set(PsgCtlcs.Ch.B, 128); }
                    if (sd.Channel == 2) { CTL.Set(PsgCtlcs.Ch.C, 128); }
                }
                

                previousTime = sd.Time;
            }

            CTL.Dispose();
        }

        /// <summary>
        /// PANICボタンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPanic_Click(object sender, EventArgs e)
        {
            try {
                CTL.Dispose();
            }
            catch
            {
                ;
            }
            CTL = new PsgCtlcs("COM6");
            CTL.Reset();
            CTL.Dispose();
            CTL = null;
        }


        /// <summary>
        /// SMF(midiファイル)のパーズを行う。
        /// ノートONとノートOFFのイベントのみを拾う
        /// </summary>
        /// <param name="filepath"></param>
        private void parseMIDI(string filepath)
        {
            SoundEventData = new ArrayList();

            MidiFileContainer container = MidiFileLoader.Load(File.ReadAllBytes(filepath));

            var noteTrack_1 = container.tracks[0];
            //var noteTrack_2 = container.tracks[2];
            //var noteTrack_3 = container.tracks[3];

            var deltaTimeSum = 0;

            var eventSeconds = new List<float>();

            //とりあえずnoteTrack_1だけ
            foreach(var smfEv in noteTrack_1)
            {
                SoundData sd = new SoundData();

                deltaTimeSum += smfEv.delta;
                int ch = (smfEv.midiEvent.status & 0x0f);

                if ((smfEv.midiEvent.status & 0xf0) == 0x90) //noteOn (ピアノ鍵盤を叩いた瞬間、ここから音がなる)
                {
                    int noteNum = smfEv.midiEvent.data1;    //ノートナンバーとは音階情報のこと
                    int vel = smfEv.midiEvent.data2;        //ベロシティは音量のこと
                    
                    
                    string strData = "";
                    if (vel < 1) //音量が十分小さい場合は、ノートOFF扱いにしちゃう
                    {
                        sd.NoteControl = false;
                        sd.NoteNumber = noteNum;
                        sd.Time = deltaTimeSum;
                        sd.Channel = ch;

                        strData = ch.ToString() + "\t" + deltaTimeSum.ToString() + "\t" + "OFF" + "\t" + noteNum.ToString();
                        //Console.WriteLine(strData);
                    }
                    else
                    {
                        sd.NoteControl = true;
                        sd.NoteNumber = noteNum;
                        sd.Time = deltaTimeSum;
                        sd.Channel = ch;

                        strData = deltaTimeSum.ToString() + "\t" + "ON_" + "\t" + noteNum.ToString();
                    }

                    SoundEventData.Add(sd);
                    //Console.WriteLine(strData);
                    //Console.WriteLine(smfEv.midiEvent.status.ToString("X"));
                }
                if ((smfEv.midiEvent.status & 0xf0) == 0x80) //noteOff (ピアノ鍵盤を話した瞬間、ここまで音がなる)
                {
                    sd.NoteControl = false;
                    sd.NoteNumber = 0;
                    sd.Time = deltaTimeSum;
                    sd.Channel = ch;

                    SoundEventData.Add(sd);
                    string strData = deltaTimeSum.ToString() + "\t" + "OFF";
                    //Console.WriteLine(strData);
                    
                }
            }
        }

       
    }

    public class SoundData
    {
        public double Time;
        public int NoteNumber;
        public bool NoteControl;
        public int Channel;
    }

}
