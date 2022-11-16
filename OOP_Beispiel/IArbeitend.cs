using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Beispiel
{
    public interface IArbeitend
    {
        int Gehalt { get; set; }

        string Job { get; set; }

        void Auszahlung();
    }
}
