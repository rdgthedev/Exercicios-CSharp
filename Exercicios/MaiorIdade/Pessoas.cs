using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.MaiorIdade
{
    public class Pessoas
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoas()
        {
            
            this.Nome = "";
            this.Idade = 0;
        }

        public Pessoas(string nome, int idade)
        {

            this.Nome = nome;
            this.Idade = idade;
        }
        public void ExibirDados()
        {
            Console.WriteLine("A pessoa mais velha é:");
            Console.WriteLine("\nNome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }

    }
}
