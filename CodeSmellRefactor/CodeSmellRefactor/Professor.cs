using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Professor : Pessoa
    {
        public string Materia { get; set; }

        //Uso da herança
        public Professor(string nome, int idade, string endereco, string telefone, string email, string materia)
            : base(nome, idade, endereco, telefone, email)
        {
            this.Materia = materia;
        }

        public override void ImprimeInformacoes()
        {
            base.ImprimeInformacoes();
            Console.WriteLine("Matéria: {0}", this.Materia);
        }
    }

}
