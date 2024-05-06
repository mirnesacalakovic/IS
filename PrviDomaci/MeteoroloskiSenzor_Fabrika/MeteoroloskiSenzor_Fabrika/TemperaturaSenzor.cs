using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoroloskiSenzor_Fabrika
{
    public class TemperaturaSenzor : IMeteoroloskiSenzor
    {
        public void PrikupiPodatke()
        {
            Console.WriteLine("Prikupljanje podataka o temperaturi.");
        }
    }
}
