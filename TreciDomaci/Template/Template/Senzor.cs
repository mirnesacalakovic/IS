using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Template
{
    public abstract class Senzor
    {
        public void ProcitajPodatke()
        {
            var data = PrikupiPodatke();
            var processedData = ProcesirajPodatke(data);
            PrikaziPodatke(processedData);
        }

        private void PrikaziPodatke(string processedData)
        {
            Console.WriteLine($"Displaying data: {processedData}");
        }

        protected abstract string ProcesirajPodatke(double data);
        protected abstract double PrikupiPodatke();
    }
}
