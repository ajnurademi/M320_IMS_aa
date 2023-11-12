using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fussball_uebung
{
    public class Spiel
    {
        Fussballmannschaft heimmannschaft;
        Fussballmannschaft gastmannschaft;
        Resultat resultat;
        

        public Spiel(Fussballmannschaft heimM, Fussballmannschaft GastM)
        {
            this.heimmannschaft = heimM;
            this.gastmannschaft = GastM;

        }

        public void FussballSpiel() 
        {
            Console.WriteLine("Der Schiedrichter pfeifft das Spiel an");

            for(int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int zufall = random.Next(0, 1);

                switch (zufall)
                {
                    case 0: heimmannschaft.Spielzug();
                        break;
                    case 1:
                        gastmannschaft.Spielzug();
                        break;
                }
            }
        }

        public void ResultatAnDerKonsole()
        {
            Console.WriteLine($"{heimmannschaft.Name} {resultat} {gastmannschaft.Name}"); ;
        }

    }
}
