using OOP_Beispiel;

//vgl. M06f_OOP_Beispiel

namespace TesteOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            ////Deklarierung von Lebewesen-Variablen und Instanziierung von neuen Lebewesen-Objekten per Konstruktor
            //OOP_Beispiel.Lebewesen lebewesen1;
            //lebewesen1 = new Lebewesen("Hugo Schmidt", "Pizza", new DateTime(2002, 2, 12), 185);
            //Lebewesen lebewesen2 = new Lebewesen("Bello", "Knochen", new DateTime(2020, 3, 15), 50);

            ////Lesezugriff auf Property per Getter
            //Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            ////Schreibzugriff auf Property per Setter
            //lebewesen1.Name = "Anna Schmidt";

            //Console.WriteLine("Lebewesen1 heißt " + lebewesen1.Name);
            //Console.WriteLine("Lebewesen2 heißt " + lebewesen2.Name);

            //Console.WriteLine(lebewesen1.Geburtsdatum);
            //Console.WriteLine(lebewesen2.Alter);

            ////Aufruf von klasseneigenen Funktionen
            //lebewesen1.Wachse();
            //lebewesen2.Wachse();
            //Lebewesen kind = lebewesen1.ProduziereNachwuchs("Maria");
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

            ////Instanziierung eines Objekts der vererbenden Klasse
            //Lebewesen lebewesen = new Lebewesen("Bello", "Fleisch", new DateTime(2007, 4, 23), 70);
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);
            //Mensch mensch2 = (Mensch)mensch.ProduziereNachwuchs("Maria");
            ////Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            //Console.WriteLine(mensch.Alter);
            //Console.WriteLine(mensch.Name);

            ////Aufruf einer Property der abgeleiteten Klasse
            //Console.WriteLine(mensch.Vorname);

            ////Ausgabe der (überschriebenen) ToString()-Methoden
            //Console.WriteLine(lebewesen);
            //Console.WriteLine(mensch);
            //Console.WriteLine(mensch2);

            ////Aufruf einer Property eines abhängigen Objekts
            //Console.WriteLine(mensch2.Mutter.Alter);

            #endregion

            #region Modul 09: Polymorphismus

            ////Deklaration einer Bsp-Variablen
            //Lebewesen lebewesen;
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);

            ////Zuweisung des abgeleiteten Objekts zu Variable der Mutterklasse
            //lebewesen = mensch;

            ////Aufruf der unten stehenden Methode mit Übergabe eines Menschen in einem Lebewesen-Übergabeparameter
            //ÄndereName(mensch, "Rainer");

            ////Tests des Laufzeittyps (des beinhalteten Objekts)
            //if (lebewesen.GetType() == typeof(Mensch))
            //    Console.WriteLine("Lebewesen ist ein Mensch");

            //if (lebewesen is Mensch)
            //    Console.WriteLine("Lebewesen ist ein Mensch");

            ////überschriebene Methoden werden trotzdem ausgeführt
            //Console.WriteLine(lebewesen.ToString());

            //if (lebewesen is Mensch)
            //{
            //    //Rückcast des abgeleiteten Objekts aus Mutterklassevariablen in abgeleitete Variable
            //    Mensch mensch2 = (Mensch)lebewesen;
            //    //Alternativer Cast
            //    mensch2 = lebewesen as Mensch;
            //}

            ////Aufruf einer überschriebenen Methode durch eine Basisklassenvariable (Funktion des Laufzeittypen wird ausgeführt)
            //Console.WriteLine(lebewesen.ToString());

            ////Aufruf einer abstrakten Methode
            //lebewesen.Essen();

            #endregion

            Mensch mensch = new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189);

            mensch.Job = "Programierer";
            mensch.Gehalt = 3600;

            IArbeitend arbeitendesObjekt = mensch;

            arbeitendesObjekt.Auszahlung();

            Gehaltserhöhung(mensch);
            Gehaltserhöhung(arbeitendesObjekt);

            Mensch neuerMensch = (Mensch)mensch.Clone();
        }

        public static void Gehaltserhöhung(IArbeitend arbeitend)
        {
            arbeitend.Gehalt += 100;

            if (arbeitend is Mensch)
                (arbeitend as Mensch).Essen();
        }

        //Bsp-Methode für Übergabe eines Lebewesens (kann auch spezifische, abgeleitete Objekte, z.B. Mensch, empfangen)
        public static void ÄndereName(Lebewesen lebewesen, string neuerName)
        {
            lebewesen.Name = neuerName;
        }
    }
}