using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public class Rechteck : Figuren, IRotatable
    {
        private float seiteA { get; set; } = 75;
        private float seiteB { get; set; } = 50;
        private float diganoalenleange { get; set; } = 90.13f;
        private float umfang { get; set; } = 250;
        private int winkelABCD { get; set; } = 90;

        public Rechteck(float A, float B, float x, float y)
        {
            this.Name = "Rechteck";
            this.seiteA = A;
            this.seiteB = B;
            this.PostitionX = x;
            this.PostitionY = y;

            diganoalenleange = (float)Math.Sqrt(A * A + B * B);
            umfang = seiteA * 2 + seiteB * 2;
        }

        public override void PrintPosition()
        {
            float untereRechteX = PostitionX + seiteA;
            float untereRechteY = PostitionY + seiteB;
            Console.WriteLine($"Die Position der oberen linken Ecke des {Name} ist bei X={PostitionX}, Y={PostitionY}");
            Console.WriteLine($"Die Position der unteren rechten Ecke des {Name} ist bei X={untereRechteX}, Y={untereRechteY}");
        }

        public override void PrintArea()
        {
            float area = seiteA * seiteB;
            Console.WriteLine($"Die Fläche des {Name} beträgt {area} ^2"); 
        }

        public override void PrintUmfang()
        {
            Console.WriteLine($"Der Umfang des {Name} beträgt {umfang}"); 
        }

        public void Diagonalenleange(float A, float B)
        {
            Console.WriteLine($"Die Länge der Diagonale des {Name} beträgt {diganoalenleange}");
        }

        public void Rotate()
        {
            Console.WriteLine($"{Name} wurde um 90 Grad im Uhrzeigersinn gedreht.");
        }
    }
}
