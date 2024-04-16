using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ac3
{
    public class Consum
    {
        //Any,Codi comarca,Comarca,Població,Domèstic xarxa,Activitats econòmiques i fonts pròpies,Total,Consum domèstic per càpita
        public int Any { get; set; }
        public int CodComarca { get; set; }
        public string Comarca { get; set; }
        public int Poblacio { get; set; }
        public int XarxaDomestica { get; set; }
        public int ActivitatsEconomiques { get; set; }
        public int Total { get; set; }
        public float ConsumPerCapita { get; set; }

        public override string ToString()
        {
            return Any + " " + CodComarca + " " + Comarca + " " + Poblacio + " " + XarxaDomestica + " " + ActivitatsEconomiques + " " + Total + " " + ConsumPerCapita;
        }

    }
}
