using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Arquivo
    {
        public string Nome;
        public int[] Indice = new int[55];
        public string Status;
        public List<string> Conteudo;
    }
}
