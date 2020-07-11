using System;
using System.Windows.Forms;

namespace XorCrypt
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            //Core.GerarKey
            try
            {
                int keySize = Convert.ToInt32(txtKeySize.Text);
                txtKey.Text = Executor.Executor.GenerateKey(keySize);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEncryptDecrypt_Click(object sender, EventArgs e)
        {
            //Core.Encrypt
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbAutoSizeKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoSizeKey.Checked)
                txtKeySize.Enabled = false;
            else
                txtKeySize.Enabled = true;
        }
    }
}