using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Huffman;
using System.Collections;

namespace DNAAndRNSEncryption
{

    public partial class frmMain : Form
    {
        public class DNAType
        {
            public string DNAItem { get; set; }
            public string DNACode { get; set; }
        }

        public class RNSPic
        {
            private int _DecimalNumber;
            private int _PixelIndex;
            public int DecimalNumber 
            {
                get
                {
                    return _DecimalNumber;
                }
                set
                {
                    _DecimalNumber = value;
                    R = _DecimalNumber % 7;
                    G = _DecimalNumber % 8;
                    B = _DecimalNumber % 9;
                    Alpha = _DecimalNumber % 3;

                    x =( _DecimalNumber % 1024)+2;
                }
            }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
            public int Alpha { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public int PixelIndex {
                get
                {
                    return _PixelIndex;
                }
                set
                {
                    _PixelIndex = value;
                    y = 20 * _PixelIndex + 12;
                }
            }
        }

        public List<DNAType> DNA1=new List<DNAType>();

        public frmMain()
        {
            InitializeComponent();
            DNA1.Add(new DNAType { DNAItem = "A", DNACode = "00" });
            DNA1.Add(new DNAType { DNAItem = "C", DNACode = "01" });
            DNA1.Add(new DNAType { DNAItem = "G", DNACode = "10" });
            DNA1.Add(new DNAType { DNAItem = "T", DNACode = "11" });
        }

        public string ConvertBinaryStringToDNASequnce(string input)
        {
            string result=string.Empty;
            for (int i = 0; i <= input.Length - 2; i+=2)
            {
                string dnaCode = input[i].ToString() + input[i + 1].ToString();
                result += (from q in DNA1 where q.DNACode == dnaCode select q).SingleOrDefault().DNAItem;
            }
             return result;
        }

        public byte[] ConvertStringToByte(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }

        public string ConvertByteToString(byte[] byt)
        {
            char[] Result= new char[byt.Length];
            Int16 i = 0;
            foreach(byte Index in byt)
            {
                Result[i]= Convert.ToChar(Index);
                i++;
            }
            return new string(Result);
        }

        public byte[] ConvertBinaryStringToByte(string input)
        {
            var bytesAsStrings =
                input.Select((c, i) => new { Char = c, Index = i })
                     .GroupBy(x => x.Index / 8)
                     .Select(g => new string(g.Select(x => x.Char).ToArray()));
            return bytesAsStrings.Select(s => Convert.ToByte(s, 2)).ToArray();
        }
      
        public string Format(byte[] data)
        {
            string result = string.Empty;
            foreach (byte value in data)
            {
                Application.DoEvents();
                string binarybyte = Convert.ToString(value, 2);
                while (binarybyte.Length < 8)
                {
                    binarybyte = "0" + binarybyte;
                }
                result += binarybyte;
            }
            return result;
        }

        private string CompStrings(string DNASeq, string PasswordBit)
        {
            string result = "";
            int j = 0;
            for (int i = 0; i <= DNASeq.Length - 1; i++)
            {
                Application.DoEvents();
                if (PasswordBit[j]=='1')
                {
                    switch(DNASeq[i])
                    {
                        case 'A':
                            result += "T";
                            break;
                        case 'T':
                            result += "A";
                            break;
                        case 'C':
                            result += "G";
                            break;
                        case 'G':
                            result += "C";
                            break;

                    }
                }
                else
                {
                    result += DNASeq[i];
                }

                j++;
                if (j >= PasswordBit.Length)
                {
                    j = 0;
                }
            }
            return result;
        }
        private string XORStrings(string PlainTextBit,string PasswordBit)
        {
            string result="";
            int j = 0;
            for (int i = 0; i <= PlainTextBit.Length - 1; i++)
            {
                var PlainText = PlainTextBit[i] == '1' ? true : false;
                var Password = PasswordBit[j] == '1' ? true : false;

                result += PlainText ^ Password ? "1" : "0";
                j++;
                if (j>=PasswordBit.Length)
                {
                    j = 0;
                }
                Application.DoEvents();
            }
            return result;
        }

        public static string GetBits(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Encoding.Unicode.GetBytes(input))
            {
                sb.Append(Convert.ToString(b, 2));
                Application.DoEvents();
            }
            return sb.ToString();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtPlainTextBit.Text = Format(ConvertStringToByte(txtPlainText.Text.Trim()));
            lblPlainText.Text = txtPlainText.Text.Length.ToString() + " Character";
            lblPlainTextbit.Text = txtPlainTextBit.Text.Length.ToString() + " Bits";
            txtPassword.Text = Format(ConvertStringToByte(txtPassword.Text.Trim()));
            lblPassword.Text = txtPassword.Text.Length.ToString();
            
            txtDNASequnceString.Text = ConvertBinaryStringToDNASequnce(txtPlainTextBit.Text.Trim());
            lblDNASequnce.Text = txtDNASequnceString.Text.Length.ToString() + " Characters";

            txtStep1.Text = CompStrings(txtDNASequnceString.Text, txtPassword.Text);
            lblDNASequnceBit.Text = txtStep1.Text.Length.ToString() + " Characters";

            txtDNASequnceBinary.Text = Format(ConvertStringToByte(txtStep1.Text));
            lblPlainTextMatrix.Text = txtDNASequnceBinary.Text.Length.ToString() + " Bits";

            txtStep2.Text = XORStrings(txtDNASequnceBinary.Text, txtPassword.Text);
            lblPasswordMatrix.Text = txtStep2.Text.Length.ToString() + " Bits";

            ////var Str = ConvertByteToString(ConvertBinaryStringToByte(txtStep2.Text));
            txtResult.Text = ConvertBinaryStringToDNASequnce(txtStep2.Text);
            label9.Text = txtResult.Text.Length.ToString() + " Characters";

            var R =ConvertBinaryStringToDNASequnce(XORStrings(Format(ConvertStringToByte(CompStrings(ConvertBinaryStringToDNASequnce(Format(ConvertStringToByte(txtPlainText.Text.Trim()))), Format(ConvertStringToByte(txtPassword.Text.Trim()))))),Format(ConvertStringToByte(txtPassword.Text.Trim()))));

            HuffmanTree huffmanTree = new HuffmanTree();
            huffmanTree.Build(R);
            BitArray encoded = huffmanTree.Encode(R);
            string Huf="";
            foreach (bool bit in encoded)
            {
                //txtHuffman.Text += ((bit ? 1 : 0) + "");
                Huf+= ((bit ? 1 : 0) + "");
                Application.DoEvents();
            }
            //label10.Text = txtHuffman.Text.Length.ToString() + " Bits";

            int index = 0;
            string result = "";
            int BitCount = 10;
            while (index <= Huf.Length - BitCount)
            {
                var Dec = Huf.Substring(index, BitCount);
                index += BitCount;
                result += "," + Convert.ToInt32(Dec, 2).ToString();
                Application.DoEvents();
            }

            //txtResultString.Text = ConvertByteToString(ConvertBinaryStringToByte(txtHuffman.Text));
            txtResultString.Text = result;
            //label12.Text=txtResultString.Text.Split(',').Length.ToString()+ " Pixels";

            List<RNSPic> RNS= new List<RNSPic>();
            int Index=1;
            foreach(string pixel in txtResultString.Text.Split(','))
            {
                if (!String.IsNullOrEmpty(pixel))
                {
                    RNS.Add(new RNSPic 
                    {
                        DecimalNumber=Convert.ToInt32(pixel),
                        PixelIndex=Index++
                    });
                }
            }

            frmResult ResultForm = new frmResult();
            ResultForm.Pic = RNS;
            ResultForm.Show();
        }
    }
}
