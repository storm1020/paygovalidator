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
