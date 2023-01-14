using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatoer
{
    public partial class Form1 : Form
    {
        private Dictionary<UInt32, UInt32> DicStoreDataBits = new Dictionary<UInt32, UInt32>();
        public Form1()
        {
            InitializeComponent();
            txtAnswer.Text = "0";
            //StoreBitsData = new UInt32[32];
            BitsData = new UInt32[32];
            StoreDataBits();
        }

        public void StoreDataBits()
        {
            //UInt32 base1 = 2;
            //UInt32 result = 0;
            //void FindPower(UInt32 Data)
            //{
            //    if(Data==0)
            //    {
            //        result = 1;
            //    }
            //    else
            //    {
            //        result = Data * base1;
            //    }

        
            //    DicStoreDataBits.Add(Data, result);

            //}

            //for (UInt32 i = 0; i < 32; i++)
            //{
            //    FindPower(i);
            //}
            DicStoreDataBits.Add(0, 1);
            DicStoreDataBits.Add(1, 2);
            DicStoreDataBits.Add(2, 4);
            DicStoreDataBits.Add(3, 8);
            DicStoreDataBits.Add(4, 16);
            DicStoreDataBits.Add(5, 32);
            DicStoreDataBits.Add(6, 64);
            DicStoreDataBits.Add(7, 128);
        }

        //private ObservableCollection<DecimalValue> resultDecimal;
        public enum Bit
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Eleven,
            Twelve,
            Thirteen,
            Fourteen,
            Fifteen,
            Sixteen,
            Seventeen,
            Eighteen,
            Nineteen,
            Twenty,
            Twenty_One,
            Twenty_Two,
            Twenty_Three,
            Twenty_Four,
            Twenty_Five,
            Twenty_Six,
            Twenty_Seven,
            Twenty_Eight,
            Twenty_Nine,
            Thirty,
            Thirty_One
        }
        #region Field
        
        private UInt32[] BitsData;
        private string OffBit = "0";
        private string OnBit = "1";
        private bool Status= false;
        private Bit BitsName;
        private  static UInt32 DecimalResult = 0;
        private int Count = 0;
        #endregion EndField


        private void BitCalculation(object sender, EventArgs e)
        {
            
            

            // Section 1 
            if (Status && BitsName==Bit.Zero)
            {
                BitsData[0] = 1;
                Count = 0;
            }
            else
            {
                BitsData[0] = 0;
            }

            if (Status && BitsName == Bit.One)
            {
                BitsData[1] = 2;
                Count = 1;
            }
            else
            {
                BitsData[1] = 0;
            }

            if (Status && BitsName == Bit.Two)
            {
                BitsData[2] = 4;
                Count = 2;
            }
            else
            {
                BitsData[2] = 0;
            }

            if (Status && BitsName == Bit.Three)
            {
                BitsData[3] = 8;
                Count = 3;
            }
            else
            {
                BitsData[3] = 0;
            }

            if (Status && BitsName == Bit.Four)
            {
                BitsData[4] = 16;
                Count = 4;
            }
            else
            {
                BitsData[4] = 0;
            }

            if (Status && BitsName == Bit.Five)
            {
                BitsData[5] = 32;
                Count = 5;
            }
            else
            {
                BitsData[5] = 0;
            }

            if (Status && BitsName == Bit.Six)
            {
                BitsData[6] = 64;
                Count = 6;
            }
            else
            {
                BitsData[6] = 0;
            }
            if (Status && BitsName == Bit.Seven)
            {
                BitsData[7] = 128;
                Count = 7;
            }
            else
            {
                BitsData[7] = 0;
            }
            // Section 2
            if (Status && BitsName == Bit.Eight)
            {
                BitsData[8] = 256;
                Count = 8;
            }
            else
            {
                BitsData[8] = 0;
            }

            if (Status && BitsName == Bit.Nine)
            {
                BitsData[9] = 512;
                Count = 9;
            }
            else
            {
                BitsData[9] = 0;
            }

            if (Status && BitsName == Bit.Ten)
            {
                BitsData[10] = 1024;
                Count = 10;
            }
            else
            {
                BitsData[10] = 0;
            }

            if (Status && BitsName == Bit.Eleven)
            {
                BitsData[11] = 2048;
                Count = 11;
            }
            else
            {
                BitsData[11] = 0;
            }

            if (Status && BitsName == Bit.Twelve)
            {
                BitsData[12] = 4096;
                Count = 12;
            }
            else
            {
                BitsData[12] = 0;
            }

            if (Status && BitsName == Bit.Thirteen)
            {
                BitsData[13] = 8192;
                Count = 13;
            }
            else
            {
                BitsData[13] = 0;
            }

            if (Status && BitsName == Bit.Fourteen)
            {
                BitsData[14] = 16384;
                Count = 14;
            }
            else
            {
                BitsData[14] = 0;
            }
            if (Status && BitsName == Bit.Fifteen)
            {
                BitsData[15] = 32768;
                Count = 15;
            }
            else
            {
                BitsData[15] = 0;
            }
            // Section 3
            if (Status && BitsName == Bit.Sixteen)
            {
                BitsData[16] = 65536;
                Count = 16;
            }
            else
            {
                BitsData[16] = 0;
            }

            if (Status && BitsName == Bit.Seventeen)
            {
                BitsData[17] = 131072;
                Count = 17;
            }
            else
            {
                BitsData[17] = 0;
            }

            if (Status && BitsName == Bit.Eighteen)
            {
                BitsData[18] = 262144;
                Count = 18;
            }
            else
            {
                BitsData[18] = 0;
            }

            if (Status && BitsName == Bit.Nineteen)
            {
                BitsData[19] = 524288;
                Count = 19;
            }
            else
            {
                BitsData[19] = 0;
            }

            if (Status && BitsName == Bit.Twenty)
            {
                BitsData[20] = 1048576;
                Count = 20;
            }
            else
            {
                BitsData[20] = 0;
            }

            if (Status && BitsName == Bit.Twenty_One)
            {
                BitsData[21] = 2097152;
                Count = 21;
            }
            else
            {
                BitsData[21] = 0;
            }

            if (Status && BitsName == Bit.Twenty_Two)
            {
                BitsData[22] = 4194304;
                Count = 22;
            }
            else
            {
                BitsData[22] = 0;
            }
            if (Status && BitsName == Bit.Twenty_Three)
            {
                BitsData[23] = 8388608;
                Count = 23;
            }
            else
            {
                BitsData[23] = 0;
            }
            // Section 4
            if (Status && BitsName == Bit.Twenty_Four)
            {
                BitsData[24] = 16777216;
                Count = 24;
            }
            else
            {
                BitsData[24] = 0;
            }

            if (Status && BitsName == Bit.Twenty_Five)
            {
                BitsData[25] = 4194304;
                Count = 25;
            }
            else
            {
                BitsData[25] = 0;
            }

            if (Status && BitsName == Bit.Twenty_Six)
            {
                BitsData[26] = 67108864;
                Count = 26;
            }
            else
            {
                BitsData[26] = 0;
            }

            if (Status && BitsName == Bit.Twenty_Seven)
            {
                BitsData[27] = 134217728;
                Count = 27;
            }
            else
            {
                BitsData[27] = 0;
            }

            if (Status && BitsName == Bit.Twenty_Eight)
            {
                BitsData[28] = 268435456;
                Count = 28;
            }
            else
            {
                BitsData[28] = 0;
            }

            if (Status && BitsName == Bit.Twenty_Nine)
            {
                BitsData[29] = 536870912;
                Count = 29;
            }
            else
            {
                BitsData[29] = 0;
            }

            if (Status && BitsName == Bit.Thirty)
            {
                BitsData[30] = 1073741824;
                Count = 30;
            }
            else
            {
                BitsData[30] = 0;
            }
            if (Status && BitsName == Bit.Thirty_One)
            {
                BitsData[31] = 2147483648;
                Count = 31;
            }
            else
            {
                BitsData[31] = 0;
            }
            ConvertToDecimal(BitsData);
        }

        private void ConvertToDecimal(UInt32 [] Data)
        {
            string result = txtAnswer.Text;
           
            for (int i=0;i<=Count;i++)
            {
                if(i==Count)
                {
                    DecimalResult = DecimalResult + Data[i];
                }
                
            }
            
            txtAnswer.Text = DecimalResult.ToString();
        }

        private void lblbit0_Click(object sender, EventArgs e)
        {
            if(lblbit0.Text=="0")
            {
                Status = true;
                BitsName = Bit.Zero;
                lblbit0.Text = OnBit;
               
            }
            else
            {
                Status = false;
                BitsName = Bit.Zero;
                DecimalResult = DecimalResult - DicStoreDataBits[0];
                lblbit0.Text = OffBit;
               
            }
            
        }

        private void lblbit1_Click(object sender, EventArgs e)
        {
            if (lblbit1.Text == "0")
            {
                Status = true;
                BitsName = Bit.One;
                lblbit1.Text = OnBit;
               
            }
            else
            {
                Status = false;
                BitsName = Bit.One;
                DecimalResult = DecimalResult - DicStoreDataBits[1];
                lblbit1.Text = OffBit;
            
            }
            
        }

        private void lblbit2_Click(object sender, EventArgs e)
        {
            if (lblbit2.Text == "0")
            {
                Status = true;
                BitsName = Bit.Two;
                lblbit2.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Two;
                DecimalResult = DecimalResult - DicStoreDataBits[2];
                lblbit2.Text = OffBit;
            }
        }

        private void lblbit3_Click(object sender, EventArgs e)
        {
            if (lblbit3.Text == "0")
            {
                Status = true;
                BitsName = Bit.Three;
                lblbit3.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Three;
                DecimalResult = DecimalResult - DicStoreDataBits[3];
                lblbit3.Text = OffBit;
            }
            
        }

        private void lblbit4_Click(object sender, EventArgs e)
        {
            if (lblbit4.Text == "0")
            {
                Status = true;
                BitsName = Bit.Four;
                lblbit4.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Four;
                lblbit4.Text = OffBit;
            }
           
        }

        private void lblbit5_Click(object sender, EventArgs e)
        {
            if (lblbit5.Text == "0")
            {
                Status = true;
                BitsName = Bit.Five;
                lblbit5.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Five;
                lblbit5.Text = OffBit;
            }
            
        }

        private void lblbit6_Click(object sender, EventArgs e)
        {
            if (lblbit6.Text == "0")
            {
                Status = true;
                BitsName = Bit.Six;
                lblbit6.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Six;
                lblbit6.Text = OffBit;
            }
            
        }

        private void lblbit7_Click(object sender, EventArgs e)
        {
            if (lblbit7.Text == "0")
            {
                Status = true;
                BitsName = Bit.Seven;
                lblbit7.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Seven;
                lblbit7.Text = OffBit;
            }
            
        }

        private void lblbit8_Click(object sender, EventArgs e)  
        {
            if (lblbit8.Text == "0")
            {
                Status = true;
                BitsName = Bit.Eight;
                lblbit8.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Eight;
                lblbit8.Text = OffBit;
            }
        }

        private void lblbit9_Click(object sender, EventArgs e)
        {
            if (lblbit9.Text == "0")
            {
                Status = true;
                BitsName = Bit.Nine;
                lblbit9.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Nine;
                lblbit9.Text = OffBit;
            }
        }

        private void lblbit10_Click(object sender, EventArgs e)
        {
            if (lblbit10.Text == "0")
            {
                Status = true;
                BitsName = Bit.Ten;
                lblbit10.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Ten;
                lblbit10.Text = OffBit;
            }
        }

        private void lblbit11_Click(object sender, EventArgs e)
        {
            if (lblbit11.Text == "0")
            {
                Status = true;
                BitsName = Bit.Eleven;
                lblbit11.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Eleven;
                lblbit11.Text = OffBit;
            }
        }

        private void lblbit12_Click(object sender, EventArgs e)
        {
            if (lblbit12.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twelve;
                lblbit12.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twelve;
                lblbit12.Text = OffBit;
            }
        }

        private void lblbit13_Click(object sender, EventArgs e)
        {
            if (lblbit13.Text == "0")
            {
                Status = true;
                BitsName = Bit.Thirteen;
                lblbit13.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Thirteen;
                lblbit13.Text = OffBit;
            }
        }

        private void lblbit14_Click(object sender, EventArgs e)  
        {
            if (lblbit14.Text == "0")
            {
                Status = true;
                BitsName = Bit.Fourteen;
                lblbit14.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Fourteen;
                lblbit14.Text = OffBit;
            }
        }

        private void lblbit15_Click(object sender, EventArgs e)
        {
            if (lblbit15.Text == "0")
            {
                Status = true;
                BitsName = Bit.Fifteen;
                lblbit15.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Fifteen;
                lblbit15.Text = OffBit;
            }
        }

        private void lblbit16_Click(object sender, EventArgs e)
        {
            if (lblbit16.Text == "0")
            {
                Status = true;
                BitsName = Bit.Sixteen;
                lblbit16.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Sixteen;
                lblbit16.Text = OffBit;
            }
        }

        private void lblbit17_Click(object sender, EventArgs e)
        {
            if (lblbit17.Text == "0")
            {
                Status = true;
                BitsName = Bit.Seventeen;
                lblbit17.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Seventeen;
                lblbit17.Text = OffBit;
            }
        }

        private void lblbit18_Click(object sender, EventArgs e)
        {
            if (lblbit18.Text == "0")
            {
                Status = true;
                BitsName = Bit.Eighteen;
                lblbit18.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Eighteen;
                lblbit18.Text = OffBit;
            }
        }

        private void lblbit19_Click(object sender, EventArgs e)
        {
            if (lblbit19.Text == "0")
            {
                Status = true;
                BitsName = Bit.Nineteen;
                lblbit19.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Nineteen;
                lblbit19.Text = OffBit;
            }
        }

        private void lblbit20_Click(object sender, EventArgs e)
        {
            if (lblbit20.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty;
                lblbit20.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty;
                lblbit20.Text = OffBit;
            }
        }

        private void lblbit21_Click(object sender, EventArgs e)
        {
            if (lblbit21.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_One;
                lblbit21.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_One;
                lblbit21.Text = OffBit;
            }
        }

        private void lblbit22_Click(object sender, EventArgs e)  
        {
            if (lblbit22.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Two;
                lblbit22.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Two;
                lblbit22.Text = OffBit;
            }
        }

        private void lblbit23_Click(object sender, EventArgs e)
        {
            if (lblbit23.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Three;
                lblbit23.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Three;
                lblbit23.Text = OffBit;
            }
        }

        private void lblbit24_Click(object sender, EventArgs e)
        {
            if (lblbit24.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Four;
                lblbit24.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Four;
                lblbit24.Text = OffBit;
            }
        }

        private void lblbit25_Click(object sender, EventArgs e)
        {
            if (lblbit25.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Five;
                lblbit25.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Five;
                lblbit25.Text = OffBit;
            }
        }

        private void lblbit26_Click(object sender, EventArgs e)
        {
            if (lblbit26.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Six;
                lblbit26.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Six;
                lblbit26.Text = OffBit;
            }
        }

        private void lblbit27_Click(object sender, EventArgs e)
        {
            if (lblbit27.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Seven;
                lblbit27.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Seven;
                lblbit27.Text = OffBit;
            }
        }

        private void lblbit28_Click(object sender, EventArgs e)
        {
            if (lblbit28.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Eight;
                lblbit28.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Eight;
                lblbit28.Text = OffBit;
            }
        }

        private void lblbit29_Click(object sender, EventArgs e)
        {
            if (lblbit29.Text == "0")
            {
                Status = true;
                BitsName = Bit.Twenty_Nine;
                lblbit29.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Twenty_Nine;
                lblbit29.Text = OffBit;
            }
        }

        private void lblbit30_Click(object sender, EventArgs e)
        {
            if (lblbit30.Text == "0")
            {
                Status = true;
                BitsName = Bit.Thirty;
                lblbit30.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Thirty;
                lblbit30.Text = OffBit;
            }
        }

        private void lblbit31_Click(object sender, EventArgs e)
        {
            if (lblbit31.Text == "0")
            {
                Status = true;
                BitsName = Bit.Thirty_One;
                lblbit31.Text = OnBit;
            }
            else
            {
                Status = false;
                BitsName = Bit.Thirty_One;
                lblbit31.Text = OffBit;
            }
        }
    }
}
