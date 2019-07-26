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
        public List<string> ConteudoArquivo { get; set; }
        private string diretorio = @"C:\pgValidator";
        private string diretorioResult = @"C:\pgValidator\Result";

        public Arquivo()
        {

        }

        public Arquivo(string nome, string extensao, Passos passos, TipoArquivo[] tipoArquivo, List<string> conteudoArquivo)
        {
            this.Nome = nome;
            this.Extensao = extensao;
            this.Passos = passos;
            this.TipoArquivo = tipoArquivo;
            this.ConteudoArquivo = conteudoArquivo;
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

        public Dictionary<int, string> RetornaConteudoArquivoRf(string pathArquivo, OpenFileDialog objOpenFile, int numeroLinha)
        {
            Dictionary<int, string> conteudoArquivo = new Dictionary<int, string>();

            try
            {
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

                        conteudoArquivo.Add(contadorLinha, linha);

                        contadorLinha++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
                throw;
            }

            return conteudoArquivo;
        }

        public List<string> RetornaConteudoArquivo(string pathArquivo, OpenFileDialog objOpenFile, int numeroLinha)
        {
            List<string> conteudoArquivo = new List<string>();

            try
            {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
                throw;
            }

            return conteudoArquivo;

        }
    }
}