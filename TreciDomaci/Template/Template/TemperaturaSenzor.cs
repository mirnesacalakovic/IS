using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class TemperaturaSenzor : Senzor
    {
        protected override double PrikupiPodatke()
        {
            double temperature = 22.5;
            Console.WriteLine("Prikupljanje temperature...");
            return temperature;
        }

        protected override string ProcesirajPodatke(double data)
        {
            Console.WriteLine("Procesuiranje podataka o temperaturi...");
            return $"Temperatura: {data}°C";
        }
    }
}
