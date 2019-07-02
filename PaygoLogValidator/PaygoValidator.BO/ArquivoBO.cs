using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaygoLogValidator.PaygoValidator.BO
{
    public class ArquivoBO : IArquivoBO
    {
        bool IArquivoBO.VerificaSeExistePastaNoDiretorio(string diretorio)
        {
            bool existePasta = false;

            if (Directory.Exists(diretorio))
            {
                MessageBox.Show("A pasta já existe no caminho selecionado.");
                existePasta = true;
                return existePasta;
            }
            else
            {
                existePasta = false;
                return existePasta;
            }
        }

        bool IArquivoBO.ValidaSeArquivoExisteNoDiretorio(string nomeArquivo)
        {
            bool existeArquivo = true;

            if (!File.Exists(nomeArquivo))
            {
                existeArquivo = false;
                MessageBox.Show("O arquivo não existe, ou é inválido!");
            }
            else
            {
                existeArquivo = ValidarExtensaoDoArquivo(nomeArquivo);
            }

            return existeArquivo;
        }

        string IArquivoBO.RetornaExtensaoDoArquivo(string nomeArquivo)
        {
            string extensaoArquivo = string.Empty;

            string[] spltNomeArquivo = nomeArquivo.Split('.');

            if (ValidarExtensaoDoArquivo(nomeArquivo))
            {
                for (int i = 0; i < spltNomeArquivo.Length; i++)
                {
                    switch (spltNomeArquivo[i])
                    {
                        case "log":
                            extensaoArquivo = spltNomeArquivo[i];
                            break;
                    }
                }
            }

            return extensaoArquivo;
        }

        private static bool ValidarExtensaoDoArquivo(string nomeArquivo)
        {
            bool arquivoLog = true;

            if (!nomeArquivo.Contains("log"))
            {
                arquivoLog = false;
                MessageBox.Show("Por favor, selecione um arquivo de log.");
            }

            return arquivoLog;
        }
    }
}