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
using PaygoLogValidator.PaygoValidator.BEANS;
using PaygoLogValidator.PaygoValidator.BO.Interface;

namespace PaygoLogValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Arquivo DefineTipoDeValidacao(Arquivo arquivo)
        {
            if (checkValidarDesconto.Checked && checkEcf.Checked)
            {
                TipoArquivo[] comDescontoEhEcf = { TipoArquivo.COM_DESCONTO, TipoArquivo.COM_ECF };
                arquivo.tipoArquivo = comDescontoEhEcf;
            }
            else if (checkEcf.Checked && !checkValidarDesconto.Checked)
            {
                TipoArquivo[] apenasEcf = { TipoArquivo.COM_ECF, TipoArquivo.SEM_DESCONTO };
                arquivo.tipoArquivo = apenasEcf;
            }
            else if (!checkEcf.Checked && checkValidarDesconto.Checked)
            {
                TipoArquivo[] apenasDesconto = { TipoArquivo.SEM_ECF, TipoArquivo.COM_DESCONTO };
                arquivo.tipoArquivo = apenasDesconto;
            }
            else
            {
                TipoArquivo[] semDescontoEhEcf = { TipoArquivo.SEM_DESCONTO, TipoArquivo.SEM_ECF };
                arquivo.tipoArquivo = semDescontoEhEcf;
            }

            return arquivo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            Arquivo arquivo = new Arquivo();
            arquivo.passos = new Passos();

            if (ckbCriarPasta.Checked)
            {
                arquivo.CriarPastaNoDiretorio(arquivo.Diretorio);
            }

            arquivo = DefineTipoDeValidacao(arquivo);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                arquivo.nome = arquivo.RetornaNomeDoArquivo(openFile.FileName);
                arquivo.extensao = arquivo.RetornaExtensaoDoArquivo(arquivo.nome);
                List<string> conteudoArquivo = arquivo.LerArquivo(openFile.FileName, arquivo.Diretorio, openFile, arquivo);
                arquivo.passos.conteudo = conteudoArquivo;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um arquivo de log.");
            }

            #region old - leitura.
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //arquivo.nome = openFileDialog.FileName;

            //try
            //{
            //    if (File.Exists(arquivo.nome))
            //    {
            //        using (Stream entrada = openFileDialog.OpenFile())
            //        using (StreamReader sr = new StreamReader(entrada))
            //        {
            //            var linha = sr.ReadLine();

            //            #region old
            //            //if (!string.IsNullOrWhiteSpace(linha))
            //            //{
            //            //    while (linha != null)
            //            //    {
            //            //        if (linha.Contains("Passo 1:"))
            //            //        {

            //            //            while (!linha.Contains("Passo 2:"))
            //            //            {
            //            //                testeUm.Add(linha = sr.ReadLine());
            //            //            }
            //            //        }
            //            //        else if (linha.Contains("Passo 2:"))
            //            //        {
            //            //            while (!linha.Contains("Passo 3:"))
            //            //            {

            //            //            }
            //            //        }

            //            //        linha = sr.ReadLine();
            //            //    }
            //            //}
            //            #endregion
            //        }

            //        #region old
            //        // Valida o objeto que recebeu o passo
            //        //foreach (var item in testeUm)
            //        //{
            //        //    var resultado = item.Substring(17).Trim();

            //        //    if (resultado.Equals("Passo OK."))
            //        //    {
            //        //        msgTeste = "Passo 1 OK";
            //        //    }
            //        //}

            //        // Valida a msg preenchida pelo método que processou o objeto do passo.
            //        //if (msgTeste.Contains("OK"))
            //        //{
            //        //    MessageBox.Show(msgTeste);
            //        //}
            //        #endregion

            //        MessageBox.Show("FIM");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Arquivo não existe");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(string.Format("Falha ao processar: {0}", ex.Message));
            //}
            //}
            //else
            //{
            // MessageBox.Show("Aguardando arquivo");
            //}
            //}
            //}
            #endregion
        }
    }
}