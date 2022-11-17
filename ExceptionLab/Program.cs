﻿namespace ExceptionLab
{
    public enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

    class Program
    {
        static void Main(string[] args)
        {
            //Variable, welche Wiederholung definiert
            bool wiederholen;
            //Schleife für Wiederholung
            do
            {
                wiederholen = false;

                //Eingabe durch Benutzer
                string eingabe = GetEingabe();

                //Try-Block für Code, welche möglicherweise Fehler verursacht
                try
                {
                    Term term = new Term(eingabe);

                    int ergebnis = BerechneTerm(term);

                    Console.WriteLine($"\t={ergebnis}");
                }
                //Catch-Blöcke zur Bearbeitung der Fehler
                catch (OverflowException)
                {
                    Console.WriteLine("Eine deiner Zahlen ist zu groß oder zu klein.\n");
                    //Variablenzuweisung für Wiederholung
                    wiederholen = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du hast ein nicht-erlaubtes Zeichen verwendet.\n");
                    wiederholen = true;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Du hast versucht durch 0 zu teilen.\n");
                    wiederholen = true;
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Du hast ein nicht-erlaubtes Rechenzeichen verwendet.\n");
                    wiederholen = true;
                }
                catch (Exception)
                {

                }
            } while (wiederholen);
        }

        static string GetEingabe()
        {
            Console.WriteLine("Bitte gib einen Term mit zwei Zahlen und einem Grundrechenoperator (+ - * /) ein (z.B.: 25+13):");
            return Console.ReadLine();
        }

        static int BerechneTerm(Term term)
        {
            switch (term.Operation)
            {
                case Rechenoperation.Addition:
                    return term.Zahl1 + term.Zahl2;
                case Rechenoperation.Subtraktion:
                    return term.Zahl1 - term.Zahl2;
                case Rechenoperation.Multiplikation:
                    return term.Zahl1 * term.Zahl2;
                default:
                    //Teilung kann DivideByZeroException verursachen
                    return term.Zahl1 / term.Zahl2;
            }
        }
    }

    class Term
    {
        public string Eingabe { get; set; }
        public int Zahl1 { get; set; }
        public int Zahl2 { get; set; }
        public Rechenoperation Operation { get; set; }

        public Term(string term)
        {
            this.Eingabe = term;
            this.Operation = this.GetRechenoperation();

            //SplitTerm kann Null zurückgeben (führt bei Zugriff auf Array in nächster Zeile zu NullReferenceException)
            string[] zahlen = this.SplitTerm();

            //Parsing kann FormatExceptions und OverflowExceptions verursachen
            this.Zahl1 = int.Parse(zahlen[0]);
            this.Zahl2 = int.Parse(zahlen[1]);
        }

        private Rechenoperation GetRechenoperation()
        {
            if (this.Eingabe.Contains('+'))
                return Rechenoperation.Addition;
            else if (this.Eingabe.Contains('-'))
                return Rechenoperation.Subtraktion;
            else if (this.Eingabe.Contains('*'))
                return Rechenoperation.Multiplikation;
            else if (this.Eingabe.Contains('/'))
                return Rechenoperation.Division;
            else
                return 0;
        }

        private string[] SplitTerm()
        {
            switch (this.Operation)
            {
                case Rechenoperation.Addition:
                    return this.Eingabe.Split('+');
                case Rechenoperation.Subtraktion:
                    return this.Eingabe.Split('-');
                case Rechenoperation.Multiplikation:
                    return this.Eingabe.Split('*');
                case Rechenoperation.Division:
                    return this.Eingabe.Split('/');
            }
            return null; //Null-Rückgabe kann später eine NullReferenceException verursachen
        }
    }
}

