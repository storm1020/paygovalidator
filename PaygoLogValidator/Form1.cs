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
            List<string> testeUm = new List<string>();
            string msgTeste = string.Empty;

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

                try
                {
                    if (File.Exists(fileName))
                    {
                        using (Stream entrada = ofd.OpenFile())
                        using (StreamReader sr = new StreamReader(entrada))
                        {
                            var linha = sr.ReadLine();

                            if (!string.IsNullOrWhiteSpace(linha))
                            {
                                while (linha != null)
                                {
                                    if (linha.Contains("Passo 1:"))
                                    {

                                        while (!linha.Contains("Passo 2:"))
                                        {
                                            testeUm.Add(linha = sr.ReadLine());
                                        }
                                    }
                                    else if (linha.Contains("Passo 2:"))
                                    {
                                        while (!linha.Contains("Passo 3:"))
                                        {

                                        }
                                    }

                                    linha = sr.ReadLine();
                                }
                            }
                        }

                        // Valida o objeto que recebeu o passo
                        foreach (var item in testeUm)
                        {
                            var resultado = item.Substring(17).Trim();

                            if (resultado.Equals("Passo OK."))
                            {
                                msgTeste = "Passo 1 OK";
                            }
                        }

                        // Valida a msg preenchida pelo método que processou o objeto do passo.
                        if (msgTeste.Contains("OK"))
                        {
                            MessageBox.Show(msgTeste);
                        }

                        MessageBox.Show("FIM");
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