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

        public Passos Passos { get; set; }

        public Arquivo()
        {
            
        }

        public Arquivo(string nome, Passos passos)
        {
            this.Nome = nome;
            this.Passos = passos;
        }
    }
}
