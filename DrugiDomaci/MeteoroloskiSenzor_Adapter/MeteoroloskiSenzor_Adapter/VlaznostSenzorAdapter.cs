using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoroloskiSenzor_Adapter
{
    public class VlaznostSenzorAdapter : IMeteoroloskiSenzor
    {
        private readonly VlaznostSenzor vlaznostSenzor;

        public VlaznostSenzorAdapter(VlaznostSenzor vlaznostSenzor)
        {
            this.vlaznostSenzor = vlaznostSenzor;
        }

        public void PrikupiPodatke()
        {
            vlaznostSenzor.PrikupiPodatkeVlaznosti();
        }
    }
}
