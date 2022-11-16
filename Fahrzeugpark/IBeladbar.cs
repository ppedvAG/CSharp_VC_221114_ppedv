using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //Interface zur Definition einer 'Beladungsfähigkeit' (vgl. Schiff-Klasse zur Implementierung)
    public interface IBeladbar
    {
        Fahrzeug Ladung { get; set; }

        void Belade(Fahrzeug fz);

        Fahrzeug Entlade();
    }
}
