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
                content = RetornaApenasOhPasso(conteudoLinha);
            }

            return content;
        }

        bool IPassosBO.ValidaOpcionalidadeDoTesteAposAtribuicao(bool rst)
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

        bool IPassosBO.RetornarTipoDeArquivoComDesconto(TipoArquivo[] tipoArquivo)
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

        bool IPassosBO.RetornarTipoDeArquivoComEcf(TipoArquivo[] tipoArquivo)
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

        private static string RetornaApenasOhPasso(string conteudoLinha)
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
