using System.Runtime.Intrinsics.X86;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); 
            Console.WriteLine("Hallo Mars");

            int Alter;
            Alter = 32;

            string Stadt = "Berlin";

            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);

            int DoppeltesAlter = Alter * 2;
            Console.WriteLine(DoppeltesAlter);


            char Textzeichen = 'A';

            bool wahrheitswert = true;

            double Kosten = 67.123;
            Console.WriteLine(Kosten);

            string Satz = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);
            Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".");

            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);

            int a = 12;
            int b = 45;
            Console.WriteLine($"{a} + {b} = {a+b}");

            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt);


            string bsp = $"Dies ist ein \t\"Tabulator\" und dies ein \n{{Zeilenumbruch}}";
            Console.WriteLine(bsp);

            string path = "C:\\Programme\\Programm.exe";
            Console.WriteLine(path);


            string verbatim = @"Dies ist ein    Tabulator und dies ein
Zeilenumbruch";
            Console.WriteLine(verbatim);

            path = @"C:\Programme\Programm.exe";
            Console.WriteLine(path);


            Console.WriteLine("Bitte gib deinen Namen ein:");
            string eingabe = Console.ReadLine();

            Console.WriteLine($"Dein Name ist also {eingabe}.");

            Console.WriteLine("Bitte gib deine Lieblingszahl ein:");
            string zahlAlsString = Console.ReadLine();
            int zahl = int.Parse(zahlAlsString);
            zahl = zahl * 2;
            Console.WriteLine(zahl);


            int intZahl = 34;
            double doubleZahl = intZahl;

            doubleZahl = 132.65;
            intZahl = (int)doubleZahl;

            Console.WriteLine(intZahl);


        }
    }
}

