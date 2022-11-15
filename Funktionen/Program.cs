namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = Addiere(3, 6);
            Console.WriteLine(summe);

            double dblSumme = Addiere(2.4, 6.3);
            Console.WriteLine(dblSumme);

            summe = Addiere(1, 2, d: 34);

            summe = BildeSumme(2, 5, 7, 9, -34, 678);

            summe = AddiereUndSubtrahiere(50, 23, out int diff);
            Console.WriteLine(diff);


            string eingabe = Console.ReadLine();
            if (int.TryParse(eingabe, out int result))
            {
                Console.WriteLine(result *2);
            }

        }

        static int Addiere(int a, int b)
        {
            return a + b;
        }

        static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }

        static double Addiere(double a, double b)
        {
            return a + b;
        }

        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (var item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;

            return a + b;
        }
    }
}