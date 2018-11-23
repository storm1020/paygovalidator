using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaygoLogValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\pgValidator";

            // Quando true, verificar diretório e criar pasta.
            if (checkBox1.Checked == true)
            {
                string msg = BO.VerificaEhCriaPastaNoDiretorio(ofd.InitialDirectory = @"C:\pgValidator");
                MessageBox.Show(msg);
            }

            // Após clique de "OK" ou "SALVAR" no diretório.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                // Leitura arquivo
                if (File.Exists(fileName))
                {
                    using (Stream entrada = ofd.OpenFile())
                    using (StreamReader sr = new StreamReader(entrada))
                    {
                        string linha = sr.ReadLine();

                        while (linha != null)
                        {
                            linha = sr.ReadLine();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo não existe");
                }

            }
            else
            {
                MessageBox.Show("Aguardando arquivo");
            }
        }
    }
}
