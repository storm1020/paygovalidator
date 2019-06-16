using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Passos
    {
        public int Numero { get; set; }

        public List<string> Conteudo { get; set; }

        public bool Status { get; set; }

        public bool Obrigatorio { get; set; }

        public Passos()
        {

        }

        public Passos(int Numero, List<string> Conteudo, bool Status, bool Obrigatorio)
        {
            this.Numero = Numero;
            this.Conteudo = Conteudo;
            this.Status = Status;
            this.Obrigatorio = Obrigatorio;
        }
    }
}
