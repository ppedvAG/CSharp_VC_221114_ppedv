using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    //Mensch erbt mittels des :-Zeichens von der Lebewesen-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    //Mensch implementiert Interfaces, welche dieser Klasse zusätzliche Eigenschaften verleihen
    public class Mensch : Lebewesen, IArbeitend, ICloneable
    {
        //Zusätzliche Mensch-eigene Eigenschaften
        public string Vorname { get; set; }
        public Mensch Mutter { get; set; }

        //Durch IArbeitend verlangte Eigenschaften
        public int Gehalt { get; set; } = 3500;
        public string Job { get; set; }

        //Mensch-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Personklasse aufruft. Dieser erstellt dann ein Lebewesen, gibt diese
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public Mensch(string vorname, string nachname, string lieblingsnahrung, DateTime geburtsdatum, int größe) : base(nachname, lieblingsnahrung, geburtsdatum, größe)
        {
            this.Vorname = vorname;
        }

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        //Mittels BASE kann ein Rückbezug zur nächst-höheren Klasse hergestellt werden.
        //Mit SEALED kann eine Überschreibung durch Kindklassen verindert werden.
        public sealed override string ToString()
        {
            string ausgabe = $"Der Mensch {this.Vorname} " + base.ToString();
            if (this.Mutter != null)
                ausgabe = ausgabe + $" Die Mutter ist {this.Mutter.Vorname} {this.Mutter.Name}.";
            return ausgabe;
        }

        public override Lebewesen ProduziereNachwuchs(string kindname)
        {
            return new Mensch(kindname,this.Name, "Muttermilch", DateTime.Now, 30) { Mutter=this};
        }

        //Durch Mutterklasse erzwungene (weil dort abstrakte) Methode
        public override void Essen()
        {
            Console.WriteLine($"{this.Vorname} konsumiert {this.Lieblingsnahrung}.");
        }

        //Durch IArbeitend verlangte Methode
        public void Auszahlung()
        {
            Console.WriteLine($"{this.Vorname} {this.Name} hat {this.Gehalt}€ für {this.Job} bekommen.");
        }

        //Durch IClonable verlangte Methode (Bsp für .NET-eigenes Interface)
        ///Diese Methode erlaubt die Erstellung einer Kopie dieses Objekts
        public object Clone()
        {
            //Durch .MemberwiseClone() werden alle Wertetypen des Originalobjekts kopiert
            Mensch neuerMensch = (Mensch)this.MemberwiseClone();
            //Referenzen müssen manuell neu zugewiesen werden oder ebenfalls über IClonable verfügen und durch .Clone() kopiert werden
            neuerMensch.Mutter = this.Mutter;
            return neuerMensch;
        }

        //Alternativ zu IClonable kann ein Kopierkonstruktor zur Dublizierung verwendet werden. Hier werden die Werte und Referenzen koiert und übertragen
        public Mensch(Mensch alterMensch)
        {
            this.Vorname = alterMensch.Vorname;
            this.Name = alterMensch.Name;
            //...
        }
    }
}
