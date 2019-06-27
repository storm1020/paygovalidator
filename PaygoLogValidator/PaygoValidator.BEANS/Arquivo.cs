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

        public void CriarPastaNoDiretorio(string diretorio)
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

        public List<string> LerArquivo(string nomeArquivo, string diretorio, OpenFileDialog objOpenFile)
        {
            List<string> arquivoRetorno = new List<string>();

            try
            {
                if (ValidaSeArquivoExisteNoDiretorio(nomeArquivo))
                {
                    using (Stream stm = objOpenFile.OpenFile())
                    using (StreamReader str = new StreamReader(stm))
                    {
                        var linha = str.ReadLine();

                        while (!string.IsNullOrEmpty(linha))
                        {

                        }
                    }

                    MessageBox.Show("Leitura finalizada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
            }

            return arquivoRetorno;
        }

        private bool ValidaSeArquivoExisteNoDiretorio(string nomeArquivo)
        {
            bool existeArquivo = true;

            if (!File.Exists(nomeArquivo))
            {
                existeArquivo = false;
                MessageBox.Show("O arquivo não existe, ou é inválido!");
            }

            return existeArquivo;
        }

        public void VerificaSeArquivoEstaVazio()
        {

        }

        public void VerificaSeArquivoEhNullo()
        {

        }

        public bool VerificaExtensaoDoArquivo(string nomeArquivo)
        {
            bool arquivoLog = true;

            if (!nomeArquivo.Contains("log"))
            {
                arquivoLog = false;
                MessageBox.Show("Por favor, selecione um arquivo de log.");
            }

            return arquivoLog;
        }

        //Criar arquivo novo de resultado final.
        //Inserir arquivo no mesmo diretório que baixou o outro arquivo de log.
    }
}
