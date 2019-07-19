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
    public class Arquivo : ArquivoBO, IArquivoBO
    {
        private IArquivoBO iArquivo = new ArquivoBO();

        public string Nome { get; set; }

        public string Extensao { get; set; }

        public Passos Passos { get; set; }

        public TipoArquivo[] TipoArquivo { get; set; }

        private string diretorio = @"C:\pgValidator";

        private string diretorioResult = @"C:\pgValidator\Result";

        public Arquivo()
        {

        }

        public Arquivo(string nome, string extensao, Passos passos)
        {
            this.Nome = nome;
            this.Extensao = extensao;
            this.Passos = passos;
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
            if (!iArquivo.VerificaSeExistePastaNoDiretorio(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
                Directory.CreateDirectory(DiretorioResult);
                MessageBox.Show("Pastas criadas com sucesso!");
            }
        }

        public List<string> RetornaConteudoArquivo(string pathArquivo, OpenFileDialog objOpenFile, int numeroLinha)
        {
            List<string> conteudoArquivo = new List<string>();

            using (Stream stream = objOpenFile.OpenFile())
            using (StreamReader arquivo = new StreamReader(stream, Encoding.UTF8, true))
            {
                for (int i = 0; i < numeroLinha; i++)
                {
                    arquivo.ReadLine();
                }

                int contadorLinha = 0;

                while (!arquivo.EndOfStream)
                {
                    string linha = arquivo.ReadLine();

                    conteudoArquivo.Add(linha);

                    contadorLinha++;
                }

                arquivo.Close();

                return conteudoArquivo;
            }

        }


        public string LerArquivo(string nomeArquivo, string diretorio, OpenFileDialog objOpenFile, Arquivo arquivo, Passos passos)
        {
            string conteudoAtual = string.Empty;

            try
            {
                if (iArquivo.ValidaSeArquivoExisteNoDiretorio(nomeArquivo))
                {
                    using (Stream stm = objOpenFile.OpenFile())
                    using (StreamReader str = new StreamReader(stm))
                    {
                        conteudoAtual = str.ReadLine();



                    }

                    MessageBox.Show("Leitura finalizada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
            }

            return conteudoAtual;

        }

        public string RetornaExtensaoDoArquivo(string nomeArquivo)
        {
            return iArquivo.RetornaExtensaoDoArquivo(nomeArquivo);
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