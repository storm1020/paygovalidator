using PaygoLogValidator.PaygoValidator.BEANS;
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
                string msg = FormBO.VerificaEhCriaPastaNoDiretorio(ofd.InitialDirectory = @"C:\pgValidator");
                MessageBox.Show(msg);
            }

            // Após clique de "OK" ou "SALVAR" no diretório.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;

                // Leitura arquivo
                try
                {
                    if (File.Exists(fileName))
                    {
                        using (Stream entrada = ofd.OpenFile())
                        using (StreamReader sr = new StreamReader(entrada))
                        {
                            var linha = sr.ReadLine();
                            List<string> testeUm = new List<string>();

                            if (!string.IsNullOrEmpty(linha))
                            {
                                while (linha != null)
                                {
                                    string teste = linha.Substring(18).Trim();

                                    if (teste.Equals(">>>>> Passo 1:"))
                                    {

                                        while (!linha.Equals("180522 150534 306 >>>>> Passo 2:"))
                                        {
                                            testeUm.Add(linha = sr.ReadLine());
                                        }
                                      
                                        //do
                                        //{
                                        //    testeUm.Add(linha = sr.ReadLine());
                                            
                                        //} while (!linha.Equals("180522 150534 306 >>>>> Passo 2:"));
                                    }

                                    linha = sr.ReadLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Arquivo não existe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Falha ao processar: {0}", ex.Message));
                }
                

            }
            else
            {
                MessageBox.Show("Aguardando arquivo");
            }
        }
    }
}
