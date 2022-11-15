using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    public class Lebewesen
    {
        private string name = "Hugo Meier";
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length > 0)
                    this.name = value;
            }
        }

        public string Lieblingsnahrung { get; private set; }

        public DateTime Geburtsdatum { get; set; }

        public int Alter
        {
            get { return (DateTime.Now - this.Geburtsdatum).Days / 365; }
        }

        public int Größe { get; set; }

        public Lebewesen(string name, string nahrung, DateTime geburtsdatum, int größe)
        {
            this.name = name;
            this.Lieblingsnahrung = nahrung;
            this.Geburtsdatum = geburtsdatum;
            this.Größe = größe;
        }

        public Lebewesen()
        {

        }

        public void Wachse()
        {
            this.Größe += 5;
        }

        public Lebewesen ProduziereLebewesen(string neuerName)
        {
            return new Lebewesen(neuerName, "Babynahrung", DateTime.Now, 30);
        }

    }
}
