namespace Delegates
{
    public delegate int MeinDelegate(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate delegateVariable;

            delegateVariable = Addiere;

            int erg = delegateVariable(12, 56);
            Console.WriteLine(erg);

            delegateVariable = Subtrahiere;
            erg = delegateVariable(12, 56);
            Console.WriteLine(erg);

            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;

            Console.WriteLine(delegateVariable(12, 56));

            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable -= Addiere;


            Func<int, int, int> meinFunc = Addiere;

            FühreAus(meinFunc);
            FühreAus(Subtrahiere);


            List<string> Städteliste = new List<string> { "München", "Berlin", "Hamburg", "Hannover", "Köln" };
            string gefundeneStadt;

            gefundeneStadt = Städteliste.Find(FindeStadtMitH);
            Console.WriteLine(gefundeneStadt);

            gefundeneStadt = Städteliste.Find
                (
                    delegate (string Stadt)
                    {
                        return Stadt.StartsWith('H');
                    }
                );

            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith('H'); });

            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith('H'));

            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Abbruchtaste gedrückt");
            };

            Console.ReadKey();
        }


        public static bool FindeStadtMitH(string stadt)
        {
            return stadt.StartsWith('H');
        }

        public static void FühreAus(Func<int, int, int> zusätzlicheLogik)
        {
            Console.WriteLine(zusätzlicheLogik(23, 67));
        }

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }
        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}