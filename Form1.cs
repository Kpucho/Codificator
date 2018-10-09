using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Codificador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text, contraseña = txtContaseña.Text, final;

            char[] arrayTexto = texto.ToCharArray(), arrayConta = contraseña.ToCharArray(), enc = new char[75];
            int x, y;
            for(int i = 0, n = 0; i < arrayTexto.Length; i++, n++)
            {
                x = 0;
                if(n == arrayConta.Length)
                {
                    n = 0;
                }
                x = (int)arrayTexto[i]; y = (int)arrayConta[n];
                x += y;
                enc[i] = (char)(x);

            }

            final =  string.Join("", enc);


            
            using(StreamWriter outputFile = new StreamWriter("Path"))
            {
                outputFile.WriteLine(final);
                MessageBox.Show("Terminado");
                txtTexto.Text = " "; txtTexto.Focus();
                txtContaseña.Text = " ";
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
