using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Classe responsável por aplicação de regras de negócio e tratativasp referente ao Form1.
*/

namespace PaygoLogValidator
{
    public class FormBO
    {
        public static string VerificaEhCriaPastaNoDiretorio(string diretorio)
        {
            string retorno = string.Empty;

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
                retorno = "Pasta criada";
            }
            else if (Directory.Exists(diretorio))
            {
                retorno = "A pasta já existe";
            }
            else
            {
                retorno = "Erro ao criar pasta.";
            }

            return retorno;
        }
    }
}
