
using Exercicios.MaiorIdade;

int maior=0, menor=0;

Pessoas pessoa1 = new Pessoas();

Console.Write("Digite seu nome: ");
pessoa1.Nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
pessoa1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("\n");


Pessoas pessoa2 = new Pessoas();
Console.Write("Digite seu nome: ");
pessoa2.Nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("\n");


Pessoas pessoa3 = new Pessoas();
Console.Write("Digite seu nome: ");
pessoa3.Nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
pessoa3.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("\n");



if (pessoa2.Idade < pessoa1.Idade && pessoa3.Idade < pessoa1.Idade)
{
    pessoa1.ExibirDados();
}

if (pessoa1.Idade < pessoa2.Idade && pessoa3.Idade < pessoa2.Idade)
{
    pessoa2.ExibirDados();
}
if (pessoa1.Idade < pessoa3.Idade && pessoa2.Idade < pessoa3.Idade)
{
    pessoa3.ExibirDados();
}










