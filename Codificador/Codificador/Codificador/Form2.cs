using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codificador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ruta = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = openFileDialog.FileName;
                string leer = File.ReadAllText(ruta);
                txtTexto.Text = leer;
            }

            

        }

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTexto.Text) || String.IsNullOrEmpty(txtContaseña.Text))
            {
                MessageBox.Show("Cuadros de texo vacios");
            }
            else
            {
                string texto = txtTexto.Text, contraseña = txtContaseña.Text, final;

                char[] arrayTexto = texto.ToCharArray(), arrayConta = contraseña.ToCharArray(), enc = new char[0x186A0];
                int x, y;
                for (int i = 0, n = 0; i < arrayTexto.Length; i++, n++)
                {
                    x = 0;
                    if (n == arrayConta.Length)
                    {
                        n = 0;
                    }
                    x = (int)arrayTexto[i]; y = (int)arrayConta[n];
                    x -= y;
                    enc[i] = (char)(x);

                }

                final = string.Join("", enc);



                using (StreamWriter outputFile = new StreamWriter("C:\\Users\\DIEGO\\Desktop\\Decodificado.txt"))
                {
                    outputFile.WriteLine(final);
                    MessageBox.Show("Terminado");
                    txtTexto.Text = " "; txtTexto.Focus();
                    txtContaseña.Text = " ";
                }
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
