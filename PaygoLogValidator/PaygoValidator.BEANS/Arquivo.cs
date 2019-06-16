using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Arquivo
    {
        public string Nome { get; set; }

        public string Extensao { get; set; }

        public Passos Passos { get; set; }

        public Arquivo()
        {
            
        }

        public Arquivo(string nome, Passos passos)
        {
            this.Nome = nome;
            this.Passos = passos;
        }

        public void VerificaSeArquivoEstaVazio()
        {

        }

        public void VerificaSeArquivoEhNullo()
        {

        }

        public void VerificaExtensaoDoArquivo()
        {

        }

        public void RetornaExtensaoDoArquivo()
        {

        }

        public void LerArquivo()
        {

        }

        //Criar arquivo novo de resultado final.
        //Inserir arquivo no mesmo diretório que baixou o outro arquivo de log.
    }
}
