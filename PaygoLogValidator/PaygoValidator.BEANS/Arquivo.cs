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
        public Dictionary<int, string> ConteudoArquivo { get; set; }
        private string diretorio = @"C:\pgValidator";
        private string diretorioResult = @"C:\pgValidator\Result";

        public Arquivo()
        {

        }

        public Arquivo(string nome, string extensao, Passos passos, TipoArquivo[] tipoArquivo, Dictionary<int, string> conteudoArquivo)
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

        public Dictionary<int, string> RetornaConteudoArquivo(string pathArquivo, OpenFileDialog objOpenFile, int numeroLinha)
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

        //public List<string> RetornaConteudoArquivo(string pathArquivo, OpenFileDialog objOpenFile, int numeroLinha)
        //{
        //    List<string> conteudoArquivo = new List<string>();

        //    try
        //    {
        //        using (Stream stream = objOpenFile.OpenFile())
        //        using (StreamReader arquivo = new StreamReader(stream, Encoding.UTF8, true))
        //        {
        //            for (int i = 0; i < numeroLinha; i++)
        //            {
        //                arquivo.ReadLine();
        //            }

        //            int contadorLinha = 0;

        //            while (!arquivo.EndOfStream)
        //            {
        //                string linha = arquivo.ReadLine();

        //                conteudoArquivo.Add(linha);

        //                contadorLinha++;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
        //        throw;
        //    }

        //    return conteudoArquivo;

        //}

        public int RetornaIndiceDaLinhaQueContemTeste(Dictionary<int, string> conteudoArquivoJaPopulado)
        {
            int nmrLinha = 0;

            foreach (var item in conteudoArquivoJaPopulado)
            {
                if (ExisteIndiceDeTeste(item.Value))
                {
                    nmrLinha = item.Key;

                    break;
                }
            }

            return nmrLinha;
        }

        public bool ExisteIndiceDeTeste(string linhaAtual)
        {
            if (RetornaIndiceDeTesteDeAcordoComConteudoDaLinha(linhaAtual) > 0)
            {
                return true;
            }

            return false;
        }

        private int RetornaIndiceDeTesteDeAcordoComConteudoDaLinha(string linha)
        {
            int indice = 0;

            string passo = VerificaSeExisteDescricaoDePassoNaLinha(linha);

            switch (passo)
            {
                case "Passo 1:":
                    indice = 1;
                    break;

                case "Passo 2:":
                    indice = 2;
                    break;

                case "Passo 3:":
                    indice = 3;
                    break;

                case "Passo 4:":
                    indice = 4;
                    break;

                case "Passo 5:":
                    indice = 5;
                    break;

                case "Passo 7:":
                    indice = 7;
                    break;

                case "Passo 8":
                    indice = 8;
                    break;

                case "Passo 9":
                    indice = 9;
                    break;

                case "Passo 10":
                    indice = 10;
                    break;

                case "Passo 11":
                    indice = 11;
                    break;

                case "Passo 12":
                    indice = 12;
                    break;

                case "Passo 13":
                    indice = 13;
                    break;

                case "Passo 14":
                    indice = 14;
                    break;

                case "Passo 15":
                    indice = 15;
                    break;

                case "Passo 16":
                    indice = 16;
                    break;

                case "Passo 17":
                    indice = 17;
                    break;

                case "Passo 18":
                    indice = 18;
                    break;

                case "Passo 19":
                    indice = 19;
                    break;

                case "Passo 20":
                    indice = 20;
                    break;

                case "Passo 21":
                    indice = 21;
                    break;

                case "Passo 22":
                    indice = 22;
                    break;

                case "Passo 23":
                    indice = 23;
                    break;

                case "Passo 24":
                    indice = 24;
                    break;

                case "Passo 25":
                    indice = 25;
                    break;

                case "Passo 26":
                    indice = 26;
                    break;

                case "Passo 27":
                    indice = 27;
                    break;

                case "Passo 28":
                    indice = 28;
                    break;

                case "Passo 29":
                    indice = 29;
                    break;

                case "Passo 30":
                    indice = 30;
                    break;

                case "Passo 32":
                    indice = 32;
                    break;

                case "Passo 33":
                    indice = 33;
                    break;

                case "Passo 34":
                    indice = 34;
                    break;

                case "Passo 35":
                    indice = 35;
                    break;

                case "Passo 36":
                    indice = 36;
                    break;

                case "Passo 37":
                    indice = 37;
                    break;

                case "Passo 38":
                    indice = 38;
                    break;

                case "Passo 39":
                    indice = 39;
                    break;

                case "Passo 40":
                    indice = 40;
                    break;

                case "Passo 41":
                    indice = 41;
                    break;

                case "Passo 42":
                    indice = 42;
                    break;

                case "Passo 43":
                    indice = 43;
                    break;

                case "Passo 44":
                    indice = 44;
                    break;

                case "Passo 46":
                    indice = 46;
                    break;

                case "Passo 47":
                    indice = 47;
                    break;

                case "Passo 48":
                    indice = 48;
                    break;

                case "Passo 49":
                    indice = 49;
                    break;

                case "Passo 50":
                    indice = 50;
                    break;

                case "Passo 51":
                    indice = 51;
                    break;

                case "Passo 52":
                    indice = 52;
                    break;

                case "Passo 53":
                    indice = 53;
                    break;

                case "Passo 54":
                    indice = 54;
                    break;

                case "Passo 55":
                    indice = 55;
                    break;
            }

            return indice;
        }

        private string VerificaSeExisteDescricaoDePassoNaLinha(string conteudoLinha)
        {
            string content = string.Empty;

            if (conteudoLinha.Contains("Passo"))
            {
                content = RetornaConteudoDaLinhaAtualQueContemOhPasso(conteudoLinha);
            }

            return content;
        }

        private string RetornaConteudoDaLinhaAtualQueContemOhPasso(string conteudoLinha)
        {
            string conteudoTratado = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(conteudoLinha))
                {
                    conteudoTratado = conteudoLinha.Substring(24, 8).Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}: {1}", "Houve um erro ao tentar tratar o conteudo de uma linha, verifique a mensagem", ex.Message.ToString()));

                throw;
            }

            return conteudoTratado;

        }
    }
}