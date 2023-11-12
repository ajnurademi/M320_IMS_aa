using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fussball_uebung
{
    public class Resultat
    {
        public readonly int toreHeim, toreGast;

        public Resultat(int a, int b) { toreHeim = a; toreGast = b; }

        public override string ToString()
        {
            return $"{toreHeim} : {toreGast}";
        }

    }
}
