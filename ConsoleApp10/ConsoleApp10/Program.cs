using System;

namespace Elain
{
    class Elain
    {
        string lajinNimi;
        string nimi;
        string vatsanSisalto;

        // Oletuskonstruktori
        public Elain()
        {
            lajinNimi = "";
            nimi = "";
            vatsanSisalto = "";
        }

        // Kuormitettu konstruktori 1.
        public Elain(string annettuElaimenNimi)
        {
            lajinNimi = annettuElaimenNimi;
            vatsanSisalto = "";
        }

        // Kuormitettu konstruktori 2.
        public Elain(string annettuElaimenNimi, string annettuNimi, string annettuVatsanSisalto)
        {
            lajinNimi = annettuElaimenNimi;
            nimi = annettuNimi;
            vatsanSisalto = annettuVatsanSisalto;
        }

        public void syota(string syotaElainta)
        {
            vatsanSisalto = vatsanSisalto + ", " + syotaElainta;
        }

        public void muutaNimi(string uusiNimi)
        {
            nimi = uusiNimi;
        }

        public void puhu()
        {
            Console.Write("\n Hei, olen " + lajinNimi + " ja nimeni on "+ nimi + ". \n ja olen syonyt "
                          + vatsanSisalto + "\n");
        }

    }

    class ElainTesti
    {
        public static void Main(string[] args)
        {
            Elain kissa_olento = new Elain("Kissa");
            Elain koira_olento = new Elain("Koira", "Richard Leijonamieli the IIIrd", "Hau-Hau Champion Kana-Riisiä");

            kissa_olento.syota("kalaa");
            koira_olento.syota("luita");

            kissa_olento.syota("ankkasuikaletta");
            koira_olento.syota("possunkorvaa");

            kissa_olento.muutaNimi("porri");
            koira_olento.muutaNimi("Raksy");

            kissa_olento.puhu();
            koira_olento.puhu();

        }

    }
}
