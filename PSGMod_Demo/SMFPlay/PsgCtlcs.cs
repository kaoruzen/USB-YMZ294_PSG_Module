using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace SMFPlay
{
    class PsgCtlcs
    {
        private SerialPort COMPORT;
        public enum Ch { A, B, C };

        public uint[] noteNumber = {
                        /*15289, 14431, */13621, 12856, 12135, 11454, 10811, 10204,//0-7
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
                        0,0,0//128(off)
                        };


        public PsgCtlcs(string comport)
        {
            COMPORT = new SerialPort(comport);

            try
            {
                COMPORT.Open();
            }
            catch
            {
                new Exception("Failed to open com port.");
                return;
            }

                byte[] data = { (byte)'D', 0x00, 0x00 };

            //ICのリセット
            Reset();

            // Mixer
            data[1] = 0x07;
            data[2] = 0x38; //0x38
            COMPORT.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);

            // Mixer Volume A
            data[1] = 0x08;
            data[2] = 0x0F;
            COMPORT.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);

            // Mixer Volume B
            data[1] = 0x09;
            data[2] = 0x0F;
            COMPORT.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);

            // Mixer Volume C
            data[1] = 0x0A;
            data[2] = 0x0F;
            COMPORT.Write(data, 0, 3);
            System.Threading.Thread.Sleep(10);
        }

        public void Set(Ch addr, uint note)
        {
            if (!COMPORT.IsOpen)
            {
                try
                {
                    COMPORT.Open();
                }
                catch
                {
                    new Exception("Error control COMPORT");
                    return;
                }
            }

            byte addru = (byte)0x00;
            byte addrd = (byte)0x00;
            byte datau = (byte)0x00;
            byte datad = (byte)0x00;

            //上位/下位8bitに分ける
            datad = (byte)(noteNumber[note] & 0xFF);
            datau = (byte)((noteNumber[note]) >> 8);

            //Console.WriteLine("data: " + Convert.ToString(noteNumber[note], 2));
            //Console.WriteLine("datau: " + Convert.ToString(datau, 2) + "   datad: " + Convert.ToString(datad, 2));

            if (addr == Ch.A)
            {
                addru = 0x01;
                addrd = 0x00;
            }
            if (addr == Ch.B)
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
            COMPORT.Write(data, 0, 3);
            System.Threading.Thread.Sleep(1);

            data[1] = addrd;
            data[2] = datad;
            COMPORT.Write(data, 0, 3);
            System.Threading.Thread.Sleep(1);

        }

        public void Reset()
        {
            if (!COMPORT.IsOpen) 
            {
                try
                {
                    COMPORT.Open();
                }
                catch
                {
                    new Exception("Error control COMPORT");
                    return;
                }
            }
            COMPORT.Write("R");
            System.Threading.Thread.Sleep(10);
        }


        public void Dispose()
        {
            if (COMPORT.IsOpen)
            {
                COMPORT.Close();
            }
        }

    }
}
