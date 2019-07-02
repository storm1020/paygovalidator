using PaygoLogValidator.PaygoValidator.BO;
using PaygoLogValidator.PaygoValidator.BO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Passos
    {
        private IPassosBO iPassos = new PassosBO();

        public int indice { get; set; }

        public List<string> conteudo { get; set; }

        public bool status { get; set; }

        public bool obrigatoriedade { get; set; }

        public Passos()
        {

        }

        public Passos(int indice, List<string> conteudo, bool status, bool obrigatorio)
        {
            this.indice = indice;
            this.conteudo = conteudo;
            this.status = status;
            this.obrigatoriedade = obrigatorio;
        }

        //Entender se é obrigatório ou não (mapiar de alguma forma a obrigatoriedade do passo utilizando um enum ou algo que possa inserir um valor e uma nomenclatura).
        //Identificar a numeração do passo.
        //Verificar se o conteudo da leitura é valido.
        //Adicionar a lista de conteudo.
        //Validar se existe a mensagem de teste Ok, ou seja, validar o Status do teste.

    }
}
