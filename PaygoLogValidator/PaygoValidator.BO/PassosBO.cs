using PaygoLogValidator.PaygoValidator.BEANS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BO
{
    public class PassosBO : Passos
    {
        public bool VerificarSePassoEhObrigatorio(int numero)
        {
            return true;
        }
    }
}
