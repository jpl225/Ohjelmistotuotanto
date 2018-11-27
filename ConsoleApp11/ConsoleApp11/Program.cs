using System;

namespace ConsoleApp11
{
    class Pressat
    {
        // instanssit eli muuttujat
        string nimi;
        DateTime syntymapaiva;
        DateTime virkaanastumispaiva;
        DateTime virastaAstumispaiva;
        string puolue;

        // metodit
        public void syotaNimi(string uusiNimi)
        {
            nimi = uusiNimi;
        }

        public void syotaPuolue(string uusiPuolue)
        {
            puolue = uusiPuolue;
        }

        public void syotaSyntymapaiva(string uusiSyntymapaiva)
        {
            syntymapaiva = DateTime.Parse(uusiSyntymapaiva);
        }

        public void syotaVirkaanastumispaiva(string uusiVirkaanastumispaiva)
        {
            virkaanastumispaiva = DateTime.Parse(uusiVirkaanastumispaiva);
        }

        public void syotaVirastaAstumispaiva(string uusiVirastaAstumispaiva)
        {
            virastaAstumispaiva = DateTime.Parse(uusiVirastaAstumispaiva);
        }

        public void tulosta()
        {
            Console.Write("Presidentin nimi: " + nimi + " ja hän on syntynyt: " + String.Format("{0:d}", syntymapaiva)
            + "\n Hän astui virkaan " + String.Format("{0:d}", virkaanastumispaiva) + " ja astui virasta " + String.Format("{0:d}", virastaAstumispaiva) +
                " \n ja hän edusti " + puolue + " puoluetta. \n\n");
        }

        // Oletuskonstruktori
        public Pressat()
        {
            nimi = "";
            syntymapaiva = DateTime.Parse("1/1/1900");
            virkaanastumispaiva = DateTime.Parse("1/1/1900");
            virastaAstumispaiva = DateTime.Parse("1/1/1900");
            puolue = "";
        }

        // Rasitettu konstruktori
        public Pressat(string uusiNimi, string uusiSyntymapaiva, string uusiVAP, string uusiViAsP, string uusiPuolue)
        {
            nimi = uusiNimi;
            syntymapaiva = DateTime.Parse(uusiSyntymapaiva);
            virkaanastumispaiva = DateTime.Parse(uusiVAP);
            virastaAstumispaiva = DateTime.Parse(uusiViAsP);
            puolue = uusiPuolue; 
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Pressat Paasikivi = new Pressat();
            Paasikivi.syotaNimi("Juho Kusti Paasikivi");
            Paasikivi.syotaSyntymapaiva("27/11/1870");
            Paasikivi.syotaVirkaanastumispaiva("11/3/1946");
            Paasikivi.syotaVirastaAstumispaiva("1/3/1956");
            Paasikivi.syotaPuolue("Kokoomus");

            Pressat Kekkonen = new Pressat("Urho Kaleva Kekkonen", "1/9/1900", "1/3/1956", "27/10/1981", "Keskusta");
            Paasikivi.tulosta();
            Kekkonen.tulosta();
        }
    }
}
