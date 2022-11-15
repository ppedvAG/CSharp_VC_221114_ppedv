using OOP_Beispiel;

namespace TesteOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OOP_Beispiel.Lebewesen lw = new Lebewesen("Anna", "Lasagne", new DateTime(1992, 4, 12), 175);
            Lebewesen lw2 = new Lebewesen("Hugo", "Kartoffeln", new DateTime(1999, 12, 2), 160);

            lw.Name = "Maria";
            Console.WriteLine(lw.Name);
            Console.WriteLine(lw2.Name);

            Console.WriteLine(lw.Geburtsdatum);
            Console.WriteLine(lw.Alter);

            Console.WriteLine(lw.Größe);
            lw.Wachse();
            Console.WriteLine(lw.Größe);

            lw2 = lw.ProduziereLebewesen("Mario");
        }
    }
}