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

        private string VerificaSeExistePassoNaLinha(string conteudoLinha)
        {
            string content = string.Empty;

            if (conteudoLinha.Contains("Passo"))
            {
                content = TrataLinhaParaRetornarApenasOhPasso(conteudoLinha);
            }

            return content;
        }

        private string TrataLinhaParaRetornarApenasOhPasso(string conteudoLinha)
        {
            string conteudoTratado = string.Empty;

            if (!string.IsNullOrEmpty(conteudoLinha))
            {
                conteudoTratado = conteudoLinha.Substring(24, 8).Trim();
            }

            return conteudoTratado;
        }

        private bool ValidaIndiceDoMetodo(int indice)
        {
            bool ehMaiorQueZero = false;

            if (indice > 0)
            {
                ehMaiorQueZero = true;
            }

            return ehMaiorQueZero;
        }

        private void VerificarObrigatoriedadeDosTestes()
        {

        }

        private void TrataPassoPorIndice(int indice)
        {
            if (ValidaIndiceDoMetodo(indice))
            {

            }
        }

        public int RetornaIndiceDoPasso(string linha, Arquivo arquivo)
        {
            int indice = 0;

            string passo = VerificaSeExistePassoNaLinha(linha);

            switch (passo)
            {
                case "Passo 1:":
                    arquivo.passos.indice = 1;
                    break;

                case "Passo 2:":
                    arquivo.passos.indice = 2;
                    break;

                case "Passo 3:":
                    arquivo.passos.indice = 3;
                    break;

                case "Passo 4:":
                    arquivo.passos.indice = 4;
                    break;

                case "Passo 5:":
                    arquivo.passos.indice = 5;
                    break;

                case "Passo 6:":
                    arquivo.passos.indice = 6;
                    break;

                case "Passo 7:":
                    arquivo.passos.indice = 7;
                    break;

                case "Passo 8":
                    arquivo.passos.indice = 8;
                    break;

                case "Passo 9":
                    arquivo.passos.indice = 9;
                    break;

                case "Passo 10":
                    arquivo.passos.indice = 10;
                    break;

                case "Passo 11":
                    arquivo.passos.indice = 11;
                    break;

                case "Passo 12":
                    arquivo.passos.indice = 12;
                    break;

                case "Passo 13":
                    arquivo.passos.indice = 13;
                    break;

                case "Passo 14":
                    arquivo.passos.indice = 14;
                    break;

                case "Passo 15":
                    arquivo.passos.indice = 15;
                    break;

                case "Passo 16":
                    arquivo.passos.indice = 16;
                    break;

                case "Passo 17":
                    arquivo.passos.indice = 17;
                    break;

                case "Passo 18":
                    arquivo.passos.indice = 18;
                    break;

                case "Passo 19":
                    arquivo.passos.indice = 19;
                    break;

                case "Passo 20":
                    arquivo.passos.indice = 20;
                    break;

                case "Passo 21":
                    arquivo.passos.indice = 21;
                    break;

                case "Passo 22":
                    arquivo.passos.indice = 22;
                    break;

                case "Passo 23":
                    arquivo.passos.indice = 23;
                    break;

                case "Passo 24":
                    arquivo.passos.indice = 24;
                    break;

                case "Passo 25":
                    arquivo.passos.indice = 25;
                    break;

                case "Passo 26":
                    arquivo.passos.indice = 26;
                    break;

                case "Passo 27":
                    arquivo.passos.indice = 27;
                    break;

                case "Passo 28":
                    arquivo.passos.indice = 28;
                    break;

                case "Passo 29":
                    arquivo.passos.indice = 29;
                    break;

                case "Passo 30":
                    arquivo.passos.indice = 30;
                    break;

                case "Passo 31":
                    arquivo.passos.indice = 31;
                    break;

                case "Passo 32":
                    arquivo.passos.indice = 32;
                    break;

                case "Passo 33":
                    arquivo.passos.indice = 33;
                    break;

                case "Passo 34":
                    arquivo.passos.indice = 34;
                    break;

                case "Passo 35":
                    arquivo.passos.indice = 35;
                    break;

                case "Passo 36":
                    arquivo.passos.indice = 36;
                    break;

                case "Passo 37":
                    arquivo.passos.indice = 37;
                    break;

                case "Passo 38":
                    arquivo.passos.indice = 38;
                    break;

                case "Passo 39":
                    arquivo.passos.indice = 39;
                    break;

                case "Passo 40":
                    arquivo.passos.indice = 40;
                    break;

                case "Passo 41":
                    arquivo.passos.indice = 41;
                    break;

                case "Passo 42":
                    arquivo.passos.indice = 42;
                    break;

                case "Passo 43":
                    arquivo.passos.indice = 43;
                    break;

                case "Passo 44":
                    arquivo.passos.indice = 44;
                    break;

                case "Passo 45":
                    arquivo.passos.indice = 45;
                    break;

                case "Passo 46":
                    arquivo.passos.indice = 46;
                    break;

                case "Passo 47":
                    arquivo.passos.indice = 47;
                    break;

                case "Passo 48":
                    arquivo.passos.indice = 48;
                    break;

                case "Passo 49":
                    arquivo.passos.indice = 49;
                    break;

                case "Passo 50":
                    arquivo.passos.indice = 50;
                    break;

                case "Passo 51":
                    arquivo.passos.indice = 51;
                    break;

                case "Passo 52":
                    arquivo.passos.indice = 52;
                    break;

                case "Passo 53":
                    arquivo.passos.indice = 53;
                    break;

                case "Passo 54":
                    arquivo.passos.indice = 54;
                    break;

                case "Passo 55":
                    arquivo.passos.indice = 55;
                    break;
            }

            return indice;
        }

        //Entender se é obrigatório ou não (mapiar de alguma forma a obrigatoriedade do passo utilizando um enum ou algo que possa inserir um valor e uma nomenclatura).
        //Identificar a numeração do passo.
        //Verificar se o conteudo da leitura é valido.
        //Adicionar a lista de conteudo.
        //Validar se existe a mensagem de teste Ok, ou seja, validar o Status do teste.

    }
}
