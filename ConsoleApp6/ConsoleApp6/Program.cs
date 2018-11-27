using System;

namespace ConsoleApp6
{
    class SuurinKokonaisluku
    {
        static void Main()
        {
            Console.Write("\n *Tama ohjelma pystyy loytamaan suurimman kokonaisluvun kolmasta"
                        + "\n kokonaisluvusta, jotka syotat nappaimistolta. \n\n");

            Console.Write(" Ole hyva ja syota ensimmainen kokonaisluku:  ");
            int ensimmainen_kokonaisluku = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Ole hyva ja syota toinen kokonaisluku: ");
            int toinen_kokonaisluku = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Ole hyva ja syota kolmas kokonaisluku:  ");
            int kolmas_kokonaisluku = Convert.ToInt32(Console.ReadLine());

            int suurin_kokonaisluku_loytyi;

            if (ensimmainen_kokonaisluku > toinen_kokonaisluku)
            {
                suurin_kokonaisluku_loytyi = ensimmainen_kokonaisluku;
            }
            else
            {
                suurin_kokonaisluku_loytyi = toinen_kokonaisluku;
            }

            if (kolmas_kokonaisluku > suurin_kokonaisluku_loytyi)
            {
                suurin_kokonaisluku_loytyi = kolmas_kokonaisluku;
            }

            Console.Write("\n Suurin kokonaisluku on "
                        + suurin_kokonaisluku_loytyi + ".\n");
        }
    }
}
