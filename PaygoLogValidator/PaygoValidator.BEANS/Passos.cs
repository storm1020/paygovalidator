using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Passos
    {
        public int numero { get; set; }

        public List<string> conteudo { get; set; }

        public bool status { get; set; }

        public bool obrigatorio { get; set; }

        public Passos()
        {

        }

        public Passos(int Numero, List<string> conteudo, bool status, bool obrigatorio)
        {
            this.numero = numero;
            this.conteudo = conteudo;
            this.status = status;
            this.obrigatorio = obrigatorio;
        }

        public List<string> ValidarSePassoEhValido(List<string> conteudo)
        {
            List<string> lstRetorno = conteudo;            

            return conteudo;
        }

        //Verificar se o conteudo da leitura é valido.
        //Adicionar a lista de conteudo.
        //Identificar a numeração do passo.
        //Entender se é obrigatório ou não (mapiar de alguma forma a obrigatoriedade do passo utilizando um enum ou algo que possa inserir um valor e uma nomenclatura).
        //Validar se existe a mensagem de teste Ok, ou seja, validar o Status do teste.

    }
}
