namespace fussball_uebung
{
    public class Program
    {
        static void Main(string[] args)
        {
            Torwart torwartAlllstars = new Torwart("Jörg");
            List<Feldspieler> feldspielerAllstars = new List<Feldspieler>
            {
                new Feldspieler("Sepp"), new Feldspieler("Ruedi"), new Feldspieler("Köbi"), new Feldspieler("Hübi"),
                new Feldspieler("Ronaldo"), new Feldspieler("Heiri"), new Feldspieler("Urs"),
                new Feldspieler("Mario"), new Feldspieler("Horst"), new Feldspieler("Ronaldinho")
            };
            Torwart torwartFcsg = new Torwart("Zigi");
            List<Feldspieler> feldspielerFcsg = new List<Feldspieler>
            {
                new Feldspieler("Görtler"), new Feldspieler("Sutter"), new Feldspieler("Schubert"), new Feldspieler("Geubbels"),
                new Feldspieler("Fazliji"), new Feldspieler("Stevanovic"), new Feldspieler("Quintilla"),
                new Feldspieler("Diaby"), new Feldspieler("Möller"), new Feldspieler("Lüchinger")
            };

            Fussballmannschaft heimmnaschaft;
            Fussballmannschaft gastmannschaft;
            //    {
            //     new Fussballmannschaft("AllStars", torwartAlllstars, feldspielerAllstars),
            //     new Fussballmannschaft("FCSG", torwartFcsg, feldspielerFcsg)
            //    };
            //Spiel spiel = new Spiel(heimmnaschaft, gastmannschaft);
            //spiel.FussballSpiel();
            //spiel.ResultatAnDerKonsole();


        }
    }
}