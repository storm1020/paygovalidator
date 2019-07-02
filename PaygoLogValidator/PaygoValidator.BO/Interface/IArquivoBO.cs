using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BO
{
    interface IArquivoBO
    {
        bool VerificaSeExistePastaNoDiretorio(string diretorio);

        bool ValidaSeArquivoExisteNoDiretorio(string nomeArquivo);

        string RetornaExtensaoDoArquivo(string nomeArquivo);
    }
}
