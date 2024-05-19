using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoroloskiSenzor_Adapter
{
    public class TemperaturaSenzorAdapter : IMeteoroloskiSenzor
    {
        private readonly TemperaturaSenzor temperaturaSenzor;
        public TemperaturaSenzorAdapter(TemperaturaSenzor temperaturaSenzor)
        {
            this.temperaturaSenzor = temperaturaSenzor;
        }

        public void PrikupiPodatke()
        {
            temperaturaSenzor.PrikupiPodatkeTemperature();
        }
    }
}
