using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public class Quadrat : Rechteck
    {
        public Quadrat(float seite, float x, float y) : base(seite, seite, x, y)
        {
            this.Name = "Quadrat";
        }
    }
}
