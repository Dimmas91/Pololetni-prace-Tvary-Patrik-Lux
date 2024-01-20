Console.WriteLine("Vyberte geometrický tvar (1 - trojúhelník, 2 - obdélník, 3 - čtverec): ");
int volba = int.Parse(Console.ReadLine());

Console.WriteLine("Zadejte délky stran (min. 5): ");
int strana1 = int.Parse(Console.ReadLine());
int strana2 = 0, strana3 = 0;

Console.WriteLine("Zadejte znaky pro kreslení obrazce: ");
string znaky = Console.ReadLine();

if (volba == 1)
{
    Console.WriteLine("Zadejte délku druhé strany: ");
    strana2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Zadejte délku třetí strany: ");
    strana3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Vykreslení trojúhelníku:");

    for (int i = 1; i <= strana1; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(znaky + " ");
        }
        Console.WriteLine();
    }
}
else if (volba == 2)
{
    Console.WriteLine("Zadejte délku druhé strany: ");
    strana2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Vykreslení obdélníku:");

    for (int i = 1; i <= strana1; i++)
    {
        for (int j = 1; j <= strana2; j++)
        {
            Console.Write(znaky + " ");
        }
        Console.WriteLine();
    }
}
else if (volba == 3)
{
    Console.WriteLine("Vykreslení čtverce:");

    for (int i = 1; i <= strana1; i++)
    {
        for (int j = 1; j <= strana1; j++)
        {
            Console.Write(znaky + " ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Neplatná volba.");
}

Console.ReadLine();