using ControleDeAnimais.Animais;
using ControleDeAnimais.GerenciadorDeAnimais;

class Program {

    static void Main(string[] args)
    {
       
            Animal animal1 = new Animal();
            Console.Write("Digite o nome do 1° animal: ");
            animal1.Nome = Console.ReadLine();
            Console.Write("Digite o tipo de animal: ");
            animal1.TipoAnimal = Console.ReadLine();
            Console.WriteLine("\n");
        while(animal1.TipoAnimal != "Cachorro" && animal1.TipoAnimal != "Gato" && animal1.TipoAnimal != "Peixe")
        {

            Console.Write("Digite o nome do 1° animal: ");
            animal1.Nome = Console.ReadLine();
            Console.Write("Digite o tipo de animal: ");
            animal1.TipoAnimal = Console.ReadLine();
            Console.WriteLine("\n");
        }

      



        Animal animal2 = new Animal();
        Console.Write("Digite o nome do 2° animal: ");
        animal2.Nome = Console.ReadLine();
        Console.Write("Digite o tipo de animal: ");
        animal2.TipoAnimal = Console.ReadLine();
        Console.WriteLine("\n");
        while (animal2.TipoAnimal != "Cachorro" && animal2.TipoAnimal != "Gato" && animal2.TipoAnimal != "Peixe")
        {
            Console.Write("Digite o nome do 2° animal: ");
            animal2.Nome = Console.ReadLine();
            Console.Write("Digite o tipo de animal: ");
            animal2.TipoAnimal = Console.ReadLine();
            Console.WriteLine("\n");
        }


            Animal animal3 = new Animal();
        Console.Write("Digite o nome do 3° animal: ");
        animal3.Nome = Console.ReadLine();
        Console.Write("Digite o tipo de animal: ");
        animal3.TipoAnimal = Console.ReadLine();
        Console.WriteLine("\n");
        while (animal3.TipoAnimal != "Cachorro" && animal3.TipoAnimal != "Gato" && animal3.TipoAnimal != "Peixe")
        {
            Console.Write("Digite o nome do 3° animal: ");
            animal3.Nome = Console.ReadLine();
            Console.Write("Digite o tipo de animal: ");
            animal3.TipoAnimal = Console.ReadLine();
            Console.WriteLine("\n");
        }



        Animal animal4 = new Animal();
        Console.Write("Digite o nome do 4° animal: ");
        animal4.Nome = Console.ReadLine();
        Console.Write("Digite o tipo de animal: ");
        animal4.TipoAnimal = Console.ReadLine();
        Console.WriteLine("\n");
        while (animal4.TipoAnimal != "Cachorro" && animal4.TipoAnimal != "Gato" && animal4.TipoAnimal != "Peixe")
        {
            Console.Write("Digite o nome do 4° animal: ");
            animal4.Nome = Console.ReadLine();
            Console.Write("Digite o tipo de animal: ");
            animal4.TipoAnimal = Console.ReadLine();
            Console.WriteLine("\n");
        }



        Animal animal5 = new Animal();
        Console.Write("Digite o nome do 5° animal: ");
        animal5.Nome = Console.ReadLine();
        Console.Write("Digite o tipo de animal: ");
        animal5.TipoAnimal = Console.ReadLine();
        Console.WriteLine("\n");
        while (animal5.TipoAnimal != "Cachorro" && animal5.TipoAnimal != "Gato" && animal5.TipoAnimal != "Peixe")
        {
            Console.Write("Digite o nome do 5° animal: ");
            animal5.Nome = Console.ReadLine();
            Console.Write("Digite o tipo de animal: ");
            animal5.TipoAnimal = Console.ReadLine();
            Console.WriteLine("\n");
        }


        if (animal1.TipoAnimal == "Cachorro")
        {
            GerenciadorDeAnimais.TotalCachorros++;
        }
        if (animal2.TipoAnimal == "Cachorro")
        {
            GerenciadorDeAnimais.TotalCachorros++;
        }
        if (animal3.TipoAnimal == "Cachorro")
        {
            GerenciadorDeAnimais.TotalCachorros++;
        }
        if (animal4.TipoAnimal == "Cachorro")
        {
            GerenciadorDeAnimais.TotalCachorros++;
        }
        if (animal5.TipoAnimal == "Cachorro")
        {
            GerenciadorDeAnimais.TotalCachorros++;
        }

        if (animal1.TipoAnimal == "Gato")
        {
            GerenciadorDeAnimais.TotalGatos++;
        }
        if (animal2.TipoAnimal == "Gato")
        {
            GerenciadorDeAnimais.TotalGatos++;
        }
        if (animal3.TipoAnimal == "Gato")
        {
            GerenciadorDeAnimais.TotalGatos++;
        }
        if (animal4.TipoAnimal == "Gato")
        {
            GerenciadorDeAnimais.TotalGatos++;
        }
        if (animal5.TipoAnimal == "Gato")
        {
            GerenciadorDeAnimais.TotalGatos++;
        }


        if (animal1.TipoAnimal == "Peixe")
        {
            GerenciadorDeAnimais.TotalPeixes++;
        }
        if (animal2.TipoAnimal == "Peixe")
        {
            GerenciadorDeAnimais.TotalPeixes++;  
        }
        if (animal3.TipoAnimal == "Peixe")
        {
            GerenciadorDeAnimais.TotalPeixes++;   
        }
        if (animal4.TipoAnimal == "Peixe")
        {
            GerenciadorDeAnimais.TotalPeixes++;   
        }
        if (animal5.TipoAnimal == "Peixe")
        {
            GerenciadorDeAnimais.TotalPeixes++;
        }

        if(GerenciadorDeAnimais.TotalCachorros == 0)
        {
            Console.WriteLine("Não há nenhum cachorro!");
        }


        if (GerenciadorDeAnimais.TotalGatos == 0)
        {
            Console.WriteLine("Não há nenhum gato!");
        }


        if (GerenciadorDeAnimais.TotalPeixes == 0)
        {
            Console.WriteLine("Não há nenhum peixe!");
        }

        GerenciadorDeAnimais exibir = new GerenciadorDeAnimais();
        exibir.ExibirAnimais();
    }
}