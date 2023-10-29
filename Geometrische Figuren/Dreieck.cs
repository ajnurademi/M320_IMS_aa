using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public class Dreieck : Figuren, IRotatable
    {
        private float Grundseite { get; set; } = 75;
        private float SeiteB { get; set; } = 75;
        private float SeiteC { get; set; } = 75;
        private float hoehe { get; set; } = 20;
        private static float winkelSumme { get; set; } = 180;

        public Dreieck(float A, float B, float C, float hoehe, float x, float y)
        {
            Name = "Dreieck";
            this.Grundseite = A;
            this.SeiteB = B;
            this.SeiteC = C;
            this.hoehe = hoehe;
            this.PostitionX = x;
            this.PostitionY = y;
        }

        public override void PrintArea()
        {
            float area = 0.5f * Grundseite * hoehe;
            Console.WriteLine($"Die Fläche des {Name} beträgt {area}  ^2");
        }

        public override void PrintUmfang()
        {
            float umfang = Grundseite + SeiteB + SeiteC;
            Console.WriteLine($"Der Umfang des {Name} beträgt {umfang}");
        }

        public void Rotate()
        {
            Console.WriteLine($"{Name} wurde um 90 Grad im Uhrzeigersinn gedreht.");
        }
    }
}
