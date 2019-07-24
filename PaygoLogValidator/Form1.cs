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
                arquivo.TipoArquivo = comDescontoEhEcf;
            }
            else if (checkEcf.Checked && !checkValidarDesconto.Checked)
            {
                TipoArquivo[] apenasEcf = { TipoArquivo.COM_ECF, TipoArquivo.SEM_DESCONTO };
                arquivo.TipoArquivo = apenasEcf;
            }
            else if (!checkEcf.Checked && checkValidarDesconto.Checked)
            {
                TipoArquivo[] apenasDesconto = { TipoArquivo.SEM_ECF, TipoArquivo.COM_DESCONTO };
                arquivo.TipoArquivo = apenasDesconto;
            }
            else
            {
                TipoArquivo[] semDescontoEhEcf = { TipoArquivo.SEM_DESCONTO, TipoArquivo.SEM_ECF };
                arquivo.TipoArquivo = semDescontoEhEcf;
            }

            return arquivo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            Arquivo objArquivo = new Arquivo();
            Passos objPassos = new Passos();

            if (ckbCriarPasta.Checked)
            {
                objArquivo.CriarPastaNoDiretorio(objArquivo.Diretorio);
            }

            objArquivo = DefineTipoDeValidacao(objArquivo);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = objArquivo.RetornaNomeDoArquivo(openFile.FileName);
                string extensaoArquivo = objArquivo.RetornaExtensaoDoArquivo(nomeArquivo);
                List<string> conteudoArquivo = objArquivo.RetornaConteudoArquivo(openFile.FileName, openFile, 0);
                objPassos.Teste(conteudoArquivo);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um arquivo de log.");
            }
        }
    }
}