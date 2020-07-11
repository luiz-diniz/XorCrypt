using System;
using System.Windows.Forms;

namespace XorCrypt
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            txtKeySize.Enabled = false;
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbAutoSizeKey.Checked)
                {
                    if (!String.IsNullOrEmpty(txtEncryptDecrypt.Text))
                    {
                        int textSize = txtEncryptDecrypt.Text.Length;
                        int keySize = textSize + 1;
                        txtKey.Text = Executor.Executor.GenerateKey(keySize); 
                    }
                    else
                    {
                        throw new Exception("Insert a text in order to generate a key based on the text size.");
                    }
                }
                else
                {
                    if(!String.IsNullOrEmpty(txtKey.Text))
                    {
                        int keySize = Convert.ToInt32(txtKeySize.Text);
                        txtKey.Text = Executor.Executor.GenerateKey(keySize);
                    }
                    else
                    {
                        throw new Exception("Please, insert the size of the key.\nIf you don't wanna define that, check Auto Size key.");
                    }          
                }          
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtEncryptDecrypt.Text = Executor.Executor.EncryptDecryptText(txtKey.Text, txtEncryptDecrypt.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAutoSizeKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoSizeKey.Checked)
                txtKeySize.Enabled = false;
            else
                txtKeySize.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smReport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/luiz-diniz/XorCrypt");
        }

        private void smInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Write the text you wanna Ecrypt/Decrypt.\n\n2. Generate a key that will Ecrypt/Decrypt the text.\n" +
                "   2.1 You can generate an auto size key or define the size manually. I recommend to use the AutoSize Feature if you don't know the size of the text.\n\n" +
                "3. Once you have the key, you just have to Encrypt/Decrypt the text.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}