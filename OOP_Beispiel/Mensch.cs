using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    //Mensch erbt mittels des :-Zeichens von der Lebewesen-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    public class Mensch : Lebewesen
    {
        //Zusätzliche Mensch-eigene Eigenschaften
        public string Vorname { get; private set; }
        public Mensch Mutter { get; set; }


        //Mensch-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Personklasse aufruft. Dieser erstellt dann ein Lebewesen, gibt diese
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public Mensch(string vorname, string nachname, string lieblingsnahrung, DateTime geburtsdatum, int größe) : base(nachname, lieblingsnahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
        }

        public override string ToString()
        {
            return $"Der Mensch {this.Vorname} " +  base.ToString();
        }

        public sealed override Lebewesen ProduziereNachwuchs(string kindname)
        {
            return new Mensch(kindname, this.Name, "Babynahrung", DateTime.Now, 30) { Mutter = this };
        }
    }
}
