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
            //GERA UMA CHAVE RANDOM
            //Cria uma lista de string
            List<char> str = new List<char>();
            Random random = new Random();
            int i = 0;

            while (i < 50)
            {
                //atribui um caracter random (ASCII do valor 50 à 100) na variável C
                char c = (char)random.Next(50, 100);

                // Adiciona o caracter (c) na lista de string
                str.Add(c);
                i++;
            }
            //Transforma o STR em um array que pode ser lido (chave final)
            txtKey.Text = new string(str.ToArray());
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            //CRIPTOGRAFA E DESCRIPTOGRAFA

            //Verifica se a chave é maior que a mensagem
            if (!(txtKey.Text.Length < txtMsg.Text.Length))
            {
                //Cria uma lista onde é será armazenado a mensagem criptografada
                List<char> encryptedText = new List<char>();
                int i = 0;

                foreach(char c in txtMsg.Text)
                {
                    //usa xor de bit a bit do caracter da mensagem e da chave e armazena
                    int character = (int)c ^ (int)txtKey.Text[i];

                    //adiciona o char do inteiro "character"
                    encryptedText.Add((char)character);
                    i++;
                }

                //Mostra a mensagem criptografada/descriptografada
                txtMsg.Text = new string(encryptedText.ToArray());
            }
            else
            {
                MessageBox.Show("The key must be larger than the message !","Fatal Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
