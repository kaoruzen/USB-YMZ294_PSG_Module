using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSGMod_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        


        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = textBoxCOMPort.Text;

            serialPort1.Open();

            byte[] data = { (byte)'D', 0x00, 0x00 };

            // Mixer
            data[1] = 0x07;
            data[2] = 0x38; //0x38
            serialPort1.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);

            // Mixer Volume A
            data[1] = 0x08;
            data[2] = 0x0F;
            serialPort1.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);

            // Mixer Volume B
            data[1] = 0x09;
            data[2] = 0x0F;
            serialPort1.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);

            // Mixer Volume C
            data[1] = 0x0A;
            data[2] = 0x0F;
            serialPort1.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);


            ////
            //data[1] = (char)0x01;
            //data[2] = (char)0x01;
            //serialPort1.Write(data, 0, 3);
            //System.Threading.Thread.Sleep(10);

            ////
            //data[1] = (char)0x00;
            //data[2] = (char)0xC2;
            //serialPort1.Write(data, 0, 3);
            //System.Threading.Thread.Sleep(10);


            //set_ch(Ch.A, (uint)numericUpDown1.Value);
            mario();

            serialPort1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = textBoxCOMPort.Text;
            serialPort1.Open();
            serialPort1.Write("R");
            serialPort1.Close();
        }


        private void mario()
        {
            delay(50);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(151);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(167);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(166);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(165);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(166);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(167);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(165);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 38);
            set_ch(Ch.C, 66);
            delay(166);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 71);
            delay(167);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 71);
            delay(499);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 31);
            delay(165);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 31);
            delay(499);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(167);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(332);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 40);
            set_ch(Ch.C, 60);
            delay(167);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 40);
            set_ch(Ch.C, 60);
            delay(332);
            set_ch(Ch.A, 64);
            set_ch(Ch.B, 36);
            set_ch(Ch.C, 55);
            delay(166);
            set_ch(Ch.A, 64);
            set_ch(Ch.B, 36);
            set_ch(Ch.C, 55);
            delay(332);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(167);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(166);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(165);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(166);
            set_ch(Ch.A, 70);
            set_ch(Ch.B, 42);
            set_ch(Ch.C, 61);
            delay(166);
            set_ch(Ch.A, 70);
            set_ch(Ch.B, 42);
            set_ch(Ch.C, 61);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(165);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(166);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(167);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(82);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            delay(167);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            delay(81);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            delay(166);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            set_ch(Ch.A, 81);
            set_ch(Ch.B, 53);
            set_ch(Ch.C, 72);
            delay(165);
            set_ch(Ch.A, 81);
            set_ch(Ch.B, 53);
            set_ch(Ch.C, 72);
            delay(166);
            set_ch(Ch.A, 77);
            set_ch(Ch.B, 50);
            set_ch(Ch.C, 69);
            delay(167);
            set_ch(Ch.A, 77);
            set_ch(Ch.B, 50);
            set_ch(Ch.C, 69);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            delay(164);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            delay(166);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 69);
            delay(167);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 69);
            delay(164);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 45);
            set_ch(Ch.C, 64);
            delay(166);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 45);
            set_ch(Ch.C, 64);
            set_ch(Ch.A, 74);
            set_ch(Ch.B, 47);
            set_ch(Ch.C, 65);
            delay(167);
            set_ch(Ch.A, 74);
            set_ch(Ch.B, 47);
            set_ch(Ch.C, 65);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(164);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(334);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(165);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(333);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 40);
            set_ch(Ch.C, 60);
            delay(166);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 40);
            set_ch(Ch.C, 60);
            delay(333);
            set_ch(Ch.A, 64);
            set_ch(Ch.B, 36);
            set_ch(Ch.C, 55);
            delay(166);
            set_ch(Ch.A, 64);
            set_ch(Ch.B, 36);
            set_ch(Ch.C, 55);
            delay(333);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(166);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(166);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(166);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(165);
            set_ch(Ch.A, 70);
            set_ch(Ch.B, 42);
            set_ch(Ch.C, 61);
            delay(166);
            set_ch(Ch.A, 70);
            set_ch(Ch.B, 42);
            set_ch(Ch.C, 61);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(166);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 60);
            delay(165);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(166);
            set_ch(Ch.A, 67);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 64);
            delay(82);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            delay(166);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            delay(82);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            delay(166);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            set_ch(Ch.A, 81);
            set_ch(Ch.B, 53);
            set_ch(Ch.C, 72);
            delay(166);
            set_ch(Ch.A, 81);
            set_ch(Ch.B, 53);
            set_ch(Ch.C, 72);
            delay(165);
            set_ch(Ch.A, 77);
            set_ch(Ch.B, 50);
            set_ch(Ch.C, 69);
            delay(166);
            set_ch(Ch.A, 77);
            set_ch(Ch.B, 50);
            set_ch(Ch.C, 69);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            delay(166);
            set_ch(Ch.A, 79);
            set_ch(Ch.B, 52);
            set_ch(Ch.C, 71);
            delay(165);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 69);
            delay(166);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 69);
            delay(166);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 45);
            set_ch(Ch.C, 64);
            delay(165);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 45);
            set_ch(Ch.C, 64);
            set_ch(Ch.A, 74);
            set_ch(Ch.B, 47);
            set_ch(Ch.C, 65);
            delay(166);
            set_ch(Ch.A, 74);
            set_ch(Ch.B, 47);
            set_ch(Ch.C, 65);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(166);
            set_ch(Ch.A, 71);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 62);
            delay(332);
            set_ch(Ch.B, 36);
            delay(167);
            set_ch(Ch.B, 36);
            delay(165);
            set_ch(Ch.A, 79);
            set_ch(Ch.C, 76);
            delay(166);
            set_ch(Ch.A, 79);
            set_ch(Ch.C, 76);
            set_ch(Ch.A, 78);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 75);
            delay(167);
            set_ch(Ch.A, 78);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 75);
            set_ch(Ch.A, 77);
            set_ch(Ch.C, 74);
            delay(164);
            set_ch(Ch.A, 77);
            set_ch(Ch.C, 74);
            set_ch(Ch.A, 75);
            set_ch(Ch.C, 71);
            delay(166);
            set_ch(Ch.A, 75);
            set_ch(Ch.C, 71);
            set_ch(Ch.B, 48);
            delay(167);
            set_ch(Ch.B, 48);
            set_ch(Ch.A, 76);
            set_ch(Ch.C, 72);
            delay(164);
            set_ch(Ch.A, 76);
            set_ch(Ch.C, 72);
            set_ch(Ch.B, 41);
            delay(166);
            set_ch(Ch.B, 41);
            set_ch(Ch.A, 68);
            set_ch(Ch.C, 64);
            delay(167);
            set_ch(Ch.A, 68);
            set_ch(Ch.C, 64);
            set_ch(Ch.A, 69);
            set_ch(Ch.C, 65);
            delay(164);
            set_ch(Ch.A, 69);
            set_ch(Ch.C, 65);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            delay(166);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            set_ch(Ch.B, 48);
            delay(167);
            set_ch(Ch.B, 48);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 60);
            delay(164);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 60);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 64);
            delay(166);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 64);
            set_ch(Ch.A, 74);
            set_ch(Ch.C, 65);
            delay(167);
            set_ch(Ch.A, 74);
            set_ch(Ch.C, 65);
            set_ch(Ch.B, 36);
            delay(164);
            set_ch(Ch.B, 36);
            delay(166);
            set_ch(Ch.A, 79);
            set_ch(Ch.C, 76);
            delay(167);
            set_ch(Ch.A, 79);
            set_ch(Ch.C, 76);
            set_ch(Ch.A, 78);
            set_ch(Ch.B, 40);
            set_ch(Ch.C, 75);
            delay(165);
            set_ch(Ch.A, 78);
            set_ch(Ch.B, 40);
            set_ch(Ch.C, 75);
            set_ch(Ch.A, 77);
            set_ch(Ch.C, 74);
            delay(166);
            set_ch(Ch.A, 77);
            set_ch(Ch.C, 74);
            set_ch(Ch.A, 75);
            set_ch(Ch.C, 71);
            delay(166);
            set_ch(Ch.A, 75);
            set_ch(Ch.C, 71);
            set_ch(Ch.B, 43);
            delay(166);
            set_ch(Ch.B, 43);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 72);
            delay(166);
            set_ch(Ch.A, 76);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 72);
            delay(167);
            set_ch(Ch.A, 84);
            set_ch(Ch.C, 77);
            delay(165);
            set_ch(Ch.A, 84);
            set_ch(Ch.C, 77);
            delay(166);
            set_ch(Ch.A, 84);
            set_ch(Ch.C, 77);
            delay(167);
            set_ch(Ch.A, 84);
            set_ch(Ch.C, 77);
            set_ch(Ch.A, 84);
            set_ch(Ch.C, 77);
            delay(164);
            set_ch(Ch.A, 84);
            set_ch(Ch.C, 77);
            delay(166);
            set_ch(Ch.B, 43);
            delay(167);
            set_ch(Ch.B, 43);
            delay(165);
            set_ch(Ch.B, 36);
            delay(167);
            set_ch(Ch.B, 36);
            delay(167);
            set_ch(Ch.A, 79);
            set_ch(Ch.C, 76);
            delay(165);
            set_ch(Ch.A, 79);
            set_ch(Ch.C, 76);
            set_ch(Ch.A, 78);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 75);
            delay(166);
            set_ch(Ch.A, 78);
            set_ch(Ch.B, 43);
            set_ch(Ch.C, 75);
            set_ch(Ch.A, 77);
            set_ch(Ch.C, 74);
            delay(167);
            set_ch(Ch.A, 77);
            set_ch(Ch.C, 74);
            set_ch(Ch.A, 75);
            set_ch(Ch.C, 71);
            delay(164);
            set_ch(Ch.A, 75);
            set_ch(Ch.C, 71);
            set_ch(Ch.B, 48);
            delay(166);
            set_ch(Ch.B, 48);
            set_ch(Ch.A, 76);
            set_ch(Ch.C, 72);
            delay(167);
            set_ch(Ch.A, 76);
            set_ch(Ch.C, 72);
            set_ch(Ch.B, 41);
            delay(164);
            set_ch(Ch.B, 41);
            set_ch(Ch.A, 68);
            set_ch(Ch.C, 64);
            delay(166);
            set_ch(Ch.A, 68);
            set_ch(Ch.C, 64);
            set_ch(Ch.A, 69);
            set_ch(Ch.C, 65);
            delay(166);
            set_ch(Ch.A, 69);
            set_ch(Ch.C, 65);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            delay(165);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 67);
            set_ch(Ch.B, 48);
            delay(166);
            set_ch(Ch.B, 48);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 60);
            delay(168);
            set_ch(Ch.A, 69);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 60);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 64);
            delay(164);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 41);
            set_ch(Ch.C, 64);
            set_ch(Ch.A, 74);
            set_ch(Ch.C, 65);
            delay(167);
            set_ch(Ch.A, 74);
            set_ch(Ch.C, 65);
            set_ch(Ch.B, 32);
            delay(167);
            set_ch(Ch.B, 32);
            delay(165);
            set_ch(Ch.A, 75);
            set_ch(Ch.B, 44);
            set_ch(Ch.C, 68);
            delay(166);
            set_ch(Ch.A, 75);
            set_ch(Ch.B, 44);
            set_ch(Ch.C, 68);
            delay(332);
            set_ch(Ch.A, 74);
            set_ch(Ch.B, 46);
            set_ch(Ch.C, 65);
            delay(166);
            set_ch(Ch.A, 74);
            set_ch(Ch.B, 46);
            set_ch(Ch.C, 65);
            delay(332);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 64);
            delay(166);
            set_ch(Ch.A, 72);
            set_ch(Ch.B, 48);
            set_ch(Ch.C, 64);
            delay(333);
            set_ch(Ch.B, 43);
            delay(166);
            set_ch(Ch.B, 43);
            set_ch(Ch.B, 43);
            delay(167);
            set_ch(Ch.B, 43);
            delay(165);
            set_ch(Ch.B, 36);
            delay(166);
            set_ch(Ch.B, 36);
            delay(167);
            set_ch(Ch.B, 36);
            delay(165);
            set_ch(Ch.B, 36);

        }

        uint[] noteNumber = {
15289, 14431, 13621, 12856, 12135, 11454, 10811, 10204,//0-7
9631, 9091, 8581, 8099, 7645, 7215, 6810, 6428,//8-15
6067, 5727, 5405, 5102, 4816, 4545, 4290, 4050,//16-23
3822, 3608, 3405, 3214, 3034, 2863, 2703, 2551,//24-31
2408, 2273, 2145, 2025, 1911, 1804, 1703, 1607,//32-39
1517, 1432, 1351, 1276, 1204, 1136, 1073, 1012,//40-47
956, 902, 851, 804, 758, 716, 676, 638,//48-55
602, 568, 536, 506, 478, 451, 426, 402,//56-63
379, 358, 338, 319, 301, 284, 268, 253,//64-71
239, 225, 213, 201, 190, 179, 169, 159,//72-79
150, 142, 134, 127, 119, 113, 106, 100,//80-87
95, 89, 84, 80, 75, 71, 67, 63,//88-95
60, 56, 53, 50, 47, 45, 42, 40,//96-103
38, 36, 34, 32, 30, 28, 27, 25,//104-111
24, 22, 21, 20, 19, 18, 17, 16,//112-119
15, 14, 13, 13, 12, 11, 11, 10,//120-127
0//128(off)
};


        enum Ch { A, B, C};

        private void set_ch(Ch addr, uint note)
        {
            byte addru = (byte)0x00;
            byte addrd = (byte)0x00;
            byte datau = (byte)0x00;
            byte datad = (byte)0x00;

            //上位/下位8bitに分ける
            datad = (byte)(noteNumber[note] & 0xFF);
            datau = (byte)((noteNumber[note]) >> 8);

            Console.WriteLine("data: " + Convert.ToString(noteNumber[note], 2));
            Console.WriteLine("datau: " + Convert.ToString(datau, 2) + "   datad: " + Convert.ToString(datad, 2));

            if(addr == Ch.A)
            {
                addru = 0x01;
                addrd = 0x00;
            }
            if(addr == Ch.B)
            {
                addru = 0x03;
                addrd = 0x02;
            }
            if (addr == Ch.C)
            {
                addru = 0x05;
                addrd = 0x04;
            }

            byte[] data = { (byte)'D', (byte)0x00, (byte)0x00 };
            
            data[1] = addru;
            data[2] = datau;
            serialPort1.Write(data, 0, 3);
            System.Threading.Thread.Sleep(1);

            data[1] = addrd;
            data[2] = datad;
            serialPort1.Write(data, 0, 3);
            System.Threading.Thread.Sleep(1);

        }

        private void delay(int time)
        {
            System.Threading.Thread.Sleep((int)(time*0.5));
        }



    }
}
