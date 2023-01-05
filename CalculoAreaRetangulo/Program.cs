

using CalculoAreaRetangulo.DadosRetangulo;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa para calcular a área de um retângulo");
        Console.WriteLine("----------------------------------------------");


        Console.Write("\nDigite o valor da base: ");
        Retangulo retangulo1 = new Retangulo();
        retangulo1.BaseRetangulo = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor da altura: ");
        retangulo1.AlturaRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("\n");

        if (retangulo1.AlturaRetangulo == 0 || retangulo1.BaseRetangulo == 0 || retangulo1.AlturaRetangulo < 0 || retangulo1.BaseRetangulo < 0)
        {
            Console.WriteLine("Você digitou um número inválido!");
            Console.WriteLine("Digite um número que seja maior que 0 e positivo!");
        }
        else 
        { 
            Console.WriteLine("A área do retângulo é: " + retangulo1.CalculaArea());
        }

    }
}