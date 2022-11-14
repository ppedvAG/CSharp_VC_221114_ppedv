using System.Reflection.Metadata;

namespace Arrays_Bedingungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 2, 4, 78, -123, 0, -8, 11111 };
            Console.WriteLine(zahlen[2]);
            zahlen[2] = 1234;
            Console.WriteLine(zahlen[2]);

            string[] worte = new string[5];

            zahlen = new int[] { 2, 4 };

            Console.WriteLine(zahlen.Contains(2));
            Console.WriteLine(zahlen.Contains(45));

            Console.WriteLine(zahlen.Length);


            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);



            int a = 23;
            int b = 23;

            if(a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
            }
            else if(a > b)
            {
               Console.WriteLine("A ist größer als B");
            }
            else
                Console.WriteLine("A ist gleich B");


            string name1 = "Hans";
            string name2 = "Hans";

            if(name1.Equals(name2))
                Console.WriteLine("Gleich");


            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";
        }
    }
}