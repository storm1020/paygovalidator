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

        private string diretorioResult = @"C:\pgValidator\Result";

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

        public string DiretorioResult
        {
            get { return diretorioResult; }
        }

        public void CriarPastaNoDiretorio(string diretorio)
        {
            if (!VerificaSeExistePastaNoDiretorio(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
                Directory.CreateDirectory(DiretorioResult);
                MessageBox.Show("Pastas criadas com sucesso!");
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
                if (ValidaSeArquivoExisteNoDiretorio(nomeArquivo) && ValidarExtensaoDoArquivo(nomeArquivo))
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

        private bool ValidarExtensaoDoArquivo(string nomeArquivo)
        {
            bool arquivoLog = true;

            if (!nomeArquivo.Contains("log"))
            {
                arquivoLog = false;
                MessageBox.Show("Por favor, selecione um arquivo de log.");
            }

            return arquivoLog;
        }

        public string RetornaExtensaoDoArquivo(string nomeArquivo)
        {
            string extensaoArquivo = string.Empty;

            string[] spltNomeArquivo = nomeArquivo.Split('.');

            if (ValidarExtensaoDoArquivo(nomeArquivo))
            {
                for (int i = 0; i < spltNomeArquivo.Length; i++)
                {
                    switch (spltNomeArquivo[i])
                    {
                        case "log":
                            extensaoArquivo = spltNomeArquivo[i];
                            break;
                    }
                }
            }

            return extensaoArquivo;
        }

        public string RetornaNomeDoArquivo(string nomeArquivo)
        {
            string rtnNmArquivo = string.Empty;
            string[] nmSplt = nomeArquivo.Split('\\');

            rtnNmArquivo = nmSplt[2];

            return rtnNmArquivo;
        }

        private void CriarArquivoDeRetorno(List<string> resultList, string diretorio, string nomeArquivo)
        {

        }
    }
}
