using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PaygoLogValidator.PaygoValidator.BO;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Arquivo : ArquivoBO
    {
        public string nome { get; set; }

        public string extensao { get; set; }

        public Passos passos { get; set; }

        private string diretorio = @"C:\pgValidator";

        public Arquivo()
        {

        }

        public Arquivo(string nome, string extensao, Passos passos)
        {
            this.nome = nome;
            this.extensao = extensao;
            this.passos = passos;
        }

        public string Diretorio
        {
            get { return diretorio; }
        }

        public void CriarPastaNoDiretorio()
        {
            if (!VerificaSeExistePastaNoDiretorio(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
                MessageBox.Show("Pasta criada com sucesso!");
            }
        }

        private bool VerificaSeExistePastaNoDiretorio(string diretorio)
        {
            bool existePasta = false;

            if (Directory.Exists(diretorio))
            {
                MessageBox.Show("A pasta já existe no caminho selecionado.");
                existePasta = true;
                return existePasta;
            }
            else
            {
                existePasta = false;
                return existePasta;
            }
        }

        public List<string> LerArquivo(string nomeArquivo)
        {
            List<string> arquivoRetorno = new List<string>();

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
            }

            return arquivoRetorno;
        }

        private bool ValidaSeArquivoExisteNoDiretorio(string nomeArquivo)
        {
            bool existeArquivo = false;

            if (File.Exists(nomeArquivo))
            {
                existeArquivo = true;
            }

            return existeArquivo;
        }

        public void VerificaSeArquivoEstaVazio()
        {

        }

        public void VerificaSeArquivoEhNullo()
        {

        }

        public void VerificaExtensaoDoArquivo()
        {

        }

        public void RetornaExtensaoDoArquivo()
        {

        }


        //Criar arquivo novo de resultado final.
        //Inserir arquivo no mesmo diretório que baixou o outro arquivo de log.
    }
}
