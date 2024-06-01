using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class VlaznostSenzor : Senzor
    {
        protected override double PrikupiPodatke()
        {
            double vlaznost = 55.0;
            Console.WriteLine("Prikupljanje podataka o vlaznosti...");
            return vlaznost;    
        }

        protected override string ProcesirajPodatke(double data)
        {
            Console.WriteLine("Procesiranje podataka o vlaznosti...");
            return $"Vlaznost: {data}%";
        }
    }
}
