using PaygoLogValidator.PaygoValidator.BO;
using PaygoLogValidator.PaygoValidator.BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Passos : PassosBO, IPassosBO
    {
        private IPassosBO iPassos = new PassosBO();

        public int indice { get; set; }

        public List<string> conteudo { get; set; }

        public bool status { get; set; }

        public bool opcional { get; set; }

        public Passos()
        {

        }

        public Passos(int indice, List<string> conteudo, bool status, bool opcional)
        {
            this.indice = indice;
            this.conteudo = conteudo;
            this.status = status;
            this.opcional = opcional;
        }

        public int RetornaIndiceDoPasso(string linha)
        {
            string passo = iPassos.VerificaSeExistePassoNaLinha(linha);

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

        public bool RetornaObrigatoriedadeDoPasso(int indicePasso, TipoArquivo[] tipoArquivo)
        {
            bool opcional = false;

            switch (indicePasso)
            {
                case 1:
                    opcional = false;
                    break;

                case 2:
                    opcional = true;
                    break;

                case 3:
                    opcional = true;
                    break;

                case 4:
                    opcional = true;
                    break;


                case 5:
                    opcional = false;
                    break;

                case 7:
                    opcional = false;
                    break;

                case 8:
                    opcional = false;
                    break;

                case 9:
                    opcional = false;
                    break;

                case 10:
                    opcional = false;
                    break;

                case 11:
                    opcional = false;
                    break;

                case 12:
                    opcional = false;
                    break;

                //Validar tipo de arquivo, teste de SAQUE - Desconto..
                case 13:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                //Validar tipo de arquivo, teste de DESCONTO.
                case 14:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                //Validar tipo de arquivo, teste de DESCONTO.
                case 15:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                //Validar tipo de arquivo, teste de valor REAJUSTADO - Desconto..
                case 16:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                //Validar tipo de arquivo, teste de valor REAJUSTADO - Desconto..
                case 17:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                case 18:
                    opcional = false;
                    break;

                case 19:
                    opcional = false;
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 20:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                case 21:
                    opcional = false;
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 22:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                case 23:
                    opcional = false;
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 24:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                case 25:
                    opcional = false;
                    break;

                case 26:
                    opcional = false;
                    break;

                case 27:
                    opcional = false;
                    break;

                case 28:
                    opcional = false;
                    break;

                case 29:
                    opcional = false;
                    break;

                case 30:
                    opcional = true;
                    break;

                case 32:
                    opcional = false;
                    break;

                case 33:
                    opcional = false;
                    break;

                case 34:
                    opcional = false;
                    break;

                case 35:
                    opcional = false;
                    break;

                case 36:
                    opcional = false;
                    break;

                case 37:
                    opcional = false;
                    break;

                case 38:
                    opcional = false;
                    break;

                case 39:
                    opcional = false;
                    break;

                case 40:
                    opcional = false;
                    break;

                case 41:
                    opcional = false;
                    break;

                case 42:
                    opcional = false;
                    break;

                case 43:
                    opcional = false;
                    break;

                case 44:
                    opcional = false;
                    break;

                case 46:
                    opcional = false;
                    break;

                case 47:
                    opcional = false;
                    break;

                case 48:
                    opcional = false;
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 49:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 50:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                case 51:
                    opcional = false;
                    break;

                case 52:
                    opcional = false;
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 53:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                //Validar tipo de arquivo, só se utilizar ECF.
                case 54:
                    opcional = iPassos.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(tipoArquivo, indicePasso);
                    break;

                case 55:
                    opcional = false;
                    break;

            }

            return opcional;
        }

        public List<string> RetornaConteudoDoPasso(string linha, int indice)
        {
            List<string> conteudo = new List<string>();

            while (RetornaIndiceDoPasso(linha) != indice)
            {
                conteudo.Add(linha);
            }

            return conteudo;
        }

        private bool VerificaSeExisteMensagemPassoOk(string conteudoLinha)
        {
            bool passoOk = false;

            string conteudoLinhaTratado = RetornaApenasMensagemDeStatus(conteudoLinha);

            if (conteudoLinhaTratado.Contains("Passo OK"))
            {
                passoOk = true;
            }

            return passoOk;
        }

        private bool VerificaSeExisteMensagemPassoComErro(string conteudoLinha)
        {
            bool passoComErro = false;

            string conteudoLinhaTratado = RetornaApenasMensagemDeStatus(conteudoLinha);

            if (conteudoLinhaTratado.Contains("Passo com erro"))
            {
                passoComErro = true;
            }

            return passoComErro;
        }

        private string RetornaApenasMensagemDeStatus(string conteudoLinha)
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

        private bool VerificaSeIndiceEhMaiorQueZero(int indice)
        {
            bool indiceValido = false;

            if (indice > 0)
            {
                indiceValido = true;
            }

            return indiceValido;
        }

    }
}
