using ControleDeAnimais.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAnimais.GerenciadorDeAnimais
{

    public class GerenciadorDeAnimais
    {
        public static int TotalGatos { get; set; }
        public static int TotalCachorros { get; set; }
        public static int TotalPeixes { get; set; }
        public void ExibirAnimais()
        {
            Console.WriteLine("O total de cachorros é: " + TotalCachorros);

            Console.WriteLine("O total de gatos é: " + TotalGatos);

            Console.WriteLine("O total de peixes é: " + TotalPeixes);
        }
    }
}
