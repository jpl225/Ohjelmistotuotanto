using System;
using System.Threading;

namespace ConsoleApp12
{
class Opiskelija
    {
        string nimi;
        string osoite;
        long opiskelijaNumero;
        string puhelinNumero;
        string kurssit;

        public void muutaNimi(string uusiNimi)
        {
            nimi = uusiNimi;
        }

        public void muutaOsoite(string uusiOsoite)
        {
            osoite = uusiOsoite;
        }

        public void lisaaPuhelin(string uusiPuhelin)
        {
            puhelinNumero = puhelinNumero + " " + uusiPuhelin;
        }

        public void lisaaKurssi(string uusiKurssi)
        {
            kurssit = kurssit + ", " + uusiKurssi;
        }

        public void tulostaOpiskelija()
        {
            Console.WriteLine("Opiskelijanumero: \t" + opiskelijaNumero);
            Console.WriteLine("Nimi: \t\t\t" + nimi);
            Console.WriteLine("Osoite: \t\t" + osoite);
            Console.WriteLine("Puhelin: \t\t" + puhelinNumero);
            Console.WriteLine("Kurssit: \t\t" + kurssit + "\n\n");
        }

        long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        //Oletuskonstruktori
        public Opiskelija()
        {
            opiskelijaNumero = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Thread.Sleep(1);
            nimi = "";
            osoite = "";
            puhelinNumero = "";
            kurssit = "";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija Datanomi01 = new Opiskelija();
            Opiskelija Datanomi02 = new Opiskelija();
            Datanomi02.tulostaOpiskelija();
            Opiskelija Datanomi03 = new Opiskelija();
            Datanomi03.tulostaOpiskelija();
            Opiskelija Datanomi04 = new Opiskelija();
            Datanomi04.tulostaOpiskelija();
            Opiskelija Datanomi05 = new Opiskelija();
            Datanomi05.tulostaOpiskelija();

            Datanomi01.muutaNimi("Jyri Lindroos");
            Datanomi01.muutaOsoite("Talonpojankatu 6");
            Datanomi01.lisaaPuhelin("040-444-5566");
            Datanomi01.lisaaKurssi("Ohjelmiston toteuttaminen");
            Datanomi01.lisaaKurssi("Photoshop");
            Datanomi01.lisaaKurssi("3D-sovellusohjelmat");
            Datanomi01.lisaaKurssi("Yto 1.4 Hyv. Lähihoit");
            Datanomi01.tulostaOpiskelija();

        }
    }
}
