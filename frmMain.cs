using System;
using System.Text;
using System.Windows.Forms;

namespace TS_Packet_Translator
{
    public partial class frmMain : Form
    {
        byte maskByte;
        public frmMain()
        {
            InitializeComponent();
        }

        private string convert(string number)
        {
            return (int.Parse(number, System.Globalization.NumberStyles.HexNumber) ^ maskByte).ToString("X2");
        }

        private string newConvert(string data)
        {
            StringBuilder strOut = new StringBuilder();
            string strTemp = data.Trim().ToUpperInvariant();

            strTemp = strTemp.Replace("\r\n", " XX ");
            strTemp = strTemp.Replace("\r", " XX ");
            strTemp = strTemp.Replace("\n", " XX ");
            while (strTemp.IndexOf("  ") != -1)
            {
                strTemp = strTemp.Replace("  ", " ");
            }

            string[] arrTemp = strTemp.Split(' ');

            foreach (string eachByte in arrTemp)
            {
                if (eachByte.Length == 2)
                {
                    if (eachByte == "XX")
                    {
                        strOut.Append(Environment.NewLine);
                    }
                    else
                    {
                        strOut.Append(convert(eachByte));
                        strOut.Append(" ");
                    }
                }
            }

            string strOut2 = strOut.ToString();
            strOut2 = strOut2.Replace(" " + Environment.NewLine, Environment.NewLine).Trim();
            return strOut2.Replace(" F4 44", Environment.NewLine + "F4 44");
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            maskByte = byte.Parse(txtMask.Text);

            rtbAfter.Clear();
            rtbAfter.AppendText(newConvert(rtbBefore.Text));
            if (chkClear.Checked)
            {
                rtbBefore.Clear();
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            maskByte = byte.Parse(txtMask.Text);

            rtbBefore.Clear();
            rtbBefore.AppendText(newConvert(rtbAfter.Text));
            if (chkClear.Checked)
            {
                rtbAfter.Clear();
            }
        }
    }
}
