using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmellRefactor
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        //Criação do construtor Pessoa
        public Pessoa(string nome, int idade, string endereco, string telefone, string email)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
        }
        public virtual void ImprimeInformacoes()
        {
            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("Idade: {0}", this.Idade);
            Console.WriteLine("Endereço: {0}", this.Endereco);
            Console.WriteLine("Telefone: {0}", this.Telefone);
            Console.WriteLine("E-mail: {0}", this.Email);
        }
    }
}
