using System;

namespace ConsoleApp3
{
    class Peli
    {
        static void Main()
        {
            int kokonaisluku_nappaimistolta;
            int yksi_iso_kokonaisluku;

            Console.Write(
                "\n Tämä on tietokonepeli. Ole hyva ja syota "
              + "\n kokonaisluku valilta  1 ... 2147483646 : ");

            kokonaisluku_nappaimistolta = Convert.ToInt32(Console.ReadLine());

            yksi_iso_kokonaisluku = kokonaisluku_nappaimistolta + 1;

            Console.Write("\n Sina syotit luvun " + kokonaisluku_nappaimistolta + "."
                        + "\n Minun lukuni on " + yksi_iso_kokonaisluku + "."
                        + "\n Olen pahoillani, sina havisit, mina voitin. The game is over.\n");
        }
    }
}
