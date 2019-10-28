using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XorCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            List<char> keyText = new List<char>();
            Random random = new Random();
            int i = 0;

            for(i = 0;i < 50;i++)
            {
                char c = (char)random.Next(50, 100);
                keyText.Add(c);
            }

            txtKey.Text = new string(keyText.ToArray());
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Length > txtMsg.Text.Length)
            {
                List<char> encryptedText = new List<char>();
                int i = 0;

                foreach(char c in txtMsg.Text)
                {
                    int character = c ^ txtKey.Text[i];
                    encryptedText.Add((char)character);
                    i++;
                }

                txtMsg.Text = new string(encryptedText.ToArray());
            }
            else
            {
                MessageBox.Show("The key must be larger than the message !","Fatal Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
