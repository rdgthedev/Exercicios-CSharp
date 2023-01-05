using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais.Animais
{
    public class Animal
    {
        public string Nome { get; set; }

        private string tipoAnimal;



        public string TipoAnimal 
        {
            get
            {
                return tipoAnimal;
            }
            set
            {
                if(value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
                    tipoAnimal = value; 
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Você digitou um animal inválido!");
                    Console.WriteLine("Só aceitamos animais dos tipos: Cachorro, Gato e Peixe.");
                }
            } 
        }
  


    }
}
