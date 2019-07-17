using PaygoLogValidator.PaygoValidator.BEANS;
using PaygoLogValidator.PaygoValidator.BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaygoLogValidator.PaygoValidator.BO
{
    public class PassosBO : IPassosBO
    {
        string IPassosBO.VerificaSeExistePassoNaLinha(string conteudoLinha)
        {
            string content = string.Empty;

            if (conteudoLinha.Contains("Passo"))
            {
                content = RetornaApenasDescricaoDaLinhaDoPasso(conteudoLinha);
            }

            return content;
        }

        bool IPassosBO.VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(TipoArquivo[] tipoArquivo, int indice)
        {
            bool opcional = false;

            switch (indice)
            {
                case 13:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComDesconto(tipoArquivo));
                    break;

                case 14:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComDesconto(tipoArquivo));
                    break;

                case 15:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComDesconto(tipoArquivo));
                    break;

                case 16:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComDesconto(tipoArquivo));
                    break;

                case 17:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComDesconto(tipoArquivo));
                    break;

                case 20:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

                case 22:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

                case 24:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

                case 49:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

                case 50:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

                case 53:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

                case 54:
                    opcional = ValidaOpcionalidadeDoTesteAposAtribuicao(RetornarTipoDeArquivoComEcf(tipoArquivo));
                    break;

            }

            return opcional;
        }

        private static bool ValidaOpcionalidadeDoTesteAposAtribuicao(bool rst)
        {
            bool opcional = false;

            if (rst)
            {
                opcional = false;
            }
            else
            {
                opcional = true;
            }

            return opcional;
        }

        private static bool RetornarTipoDeArquivoComDesconto(TipoArquivo[] tipoArquivo)
        {
            string vlComDesconto = Convert.ToString(TipoArquivo.COM_DESCONTO);
            bool validarComDesconto = false;

            foreach (var strTipoArquivo in tipoArquivo)
            {
                string vlTipoArquivo = strTipoArquivo.ToString();
                if (vlTipoArquivo.Contains(vlComDesconto))
                {
                    validarComDesconto = true;
                }
            }

            return validarComDesconto;
        }

        private static bool RetornarTipoDeArquivoComEcf(TipoArquivo[] tipoArquivo)
        {
            string vlComEcf = Convert.ToString(TipoArquivo.COM_ECF);
            bool validarComEcf = false;

            foreach (var strTipoArquivo in tipoArquivo)
            {
                string vlTipoArquivo = strTipoArquivo.ToString();
                if (vlTipoArquivo.Contains(vlComEcf))
                {
                    validarComEcf = true;
                }
            }

            return validarComEcf;
        }

        private static string RetornaApenasDescricaoDaLinhaDoPasso(string conteudoLinha)
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
