using PaygoLogValidator.PaygoValidator.BEANS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BO.Interface
{
    interface IPassosBO
    {
        string VerificaSeExistePassoNaLinha(string conteudoLinha);

        bool VerificarObrigatoriedadeDeAcordoComTipoDeArquivo(TipoArquivo[] tipoArquivo, int indice);
    }
}
