using OOP_Beispiel;

//vgl. M06f_OOP_Beispiel

namespace TesteOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            //Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            OOP_Beispiel.Lebewesen lebewesen1;
            lebewesen1 = new Lebewesen("Hugo Schmidt", "Pizza", new DateTime(2002, 2, 12), 185);
            Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 3, 15), 50);

            //Lesezugriff auf Property per Getter
            Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            //Schreibzugriff auf Property per Setter
            lebewesen1.Name = "Anna Schmidt";

            Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            Console.WriteLine("Lebewesen2 heißt " + lebewesen2.Name);

            Console.WriteLine(lebewesen1.Geburtsdatum);
            Console.WriteLine(lebewesen2.Alter);

            //Aufruf von klasseneigenen Funktionen
            lebewesen1.Wachse();
            lebewesen2.Wachse();
            Lebewesen kind = lebewesen1.ProduziereNachwuchs("Maria");
            #endregion

            #region Modul 07: Statische Member und GC

            ////Variablendklaration
            //Lebewesen lebewesen;

            ////Schleife zur neubelegung der Variablen (um die GarbageCOllection zu demonstrieren)
            //for (int i = 0; i < 10; i++)
            //{
            //    //Neuzuweisung der Varablen (alte Objekte werden derefernziert -> Destruktor wird ausgeführt)
            //    lebewesen = new Lebewesen();
            //    lebewesen.Name = $"LW{i}";
            //}

            ////Manueller Aufruf der GC und Programmpause, bis alle Destruktoren beendet wurden
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            ////Aufruf eines statischen Members der Person-Klasse
            //Console.WriteLine(Lebewesen.AnzahlLebewesen);
            //Lebewesen.ZeigeAnzahlLebewesen();

            #endregion

            #region Modul 08: Vererbung

            //Instanziierung eines Objekts der vererbenden Klasse
            Lebewesen lebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23), 70);
            //Instanziierung eines Objekts der abgeleiteten Klasse
            Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);
            //Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            Console.WriteLine(mensch.Alter);
            Console.WriteLine(mensch.Name);

            //Aufruf einer Property der abgeleiteten Klasse
            Console.WriteLine(mensch.Vorname);


            Console.WriteLine(lebewesen);
            Console.WriteLine(mensch);

            #endregion

        }
    }
}