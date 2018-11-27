using System;

namespace ConsoleApp2
{
    class Summa
    {
        static void Main()
        {
            float ensimmainen_kokonaisluku;
            int toinen_kokonaisluku;
            int kahden_kokonaisluvun_summa;

            Console.Write("\n Ole hyva ja syota kokonaisluku:      ");
            ensimmainen_kokonaisluku = Convert.ToSingle(Console.ReadLine());

            Console.Write("\n Ole hyva ja syota toinen kokonaisluku: ");
            toinen_kokonaisluku = Convert.ToInt32(Console.ReadLine());

            kahden_kokonaisluvun_summa = (int)ensimmainen_kokonaisluku + toinen_kokonaisluku;

            Console.Write("\n Kokonaislukujen summa on " +
                           kahden_kokonaisluvun_summa + "\n");
        }
    }
}
