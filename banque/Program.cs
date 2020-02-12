using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banque
{
    class Program
    {
        static void Main(string[] args)
        {
            SimulateurBanque simulateur = new SimulateurBanque();
            simulateur.Simuler();
        }
    }
}
