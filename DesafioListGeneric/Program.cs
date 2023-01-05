List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

VerificaNomes();
void VerificaNomes()
{
    int i = 0;

    foreach (string item in nomesDosEscolhidos)
    {
        if (item.Equals("Anakin Wayne"))
        {
            Console.WriteLine("O nome escolhido é: " + item);
            i++;
        }

    }
    if (i == 0)
    {
        Console.WriteLine("O nome pesquisado não existe na lista!");
    }
}


