namespace ExceptionHandling
{
    class MeineException : Exception
    {
        public MeineException() : base("Dies ist mein Fehler.") { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool wdh;
            int zahl = 0;

            do
            {
                wdh = false;

                try
                {
                    string eingabe = Console.ReadLine();
                    zahl = int.Parse(eingabe);

                    if (zahl == 0)
                        throw new MeineException();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Du musst eine Zahl eingeben. " + ex.Message);
                    wdh = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Deine Zahl ist zu groß/klein.");
                    wdh = true;

                    throw;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ein unbekannter Fehler ist eingetreten. " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Wird immer angezeigt");
                }


            } while (wdh);

            Console.WriteLine(zahl * 2);
        }
    }
}