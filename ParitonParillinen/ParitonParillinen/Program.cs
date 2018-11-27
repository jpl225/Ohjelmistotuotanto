using System;

namespace ParitonParillinen
{
    class ParitonParillinen
    {
        static void Main()
        {
            int kokonaisluku_nappaimistolta;

            Console.Write("\n Tama ohjelma pystyy nakemaan, onko kokonaisluku"
                        + "\n parillinen vai pariton. Ole hyva ja anna kokonaisluku: ");

            kokonaisluku_nappaimistolta = Convert.ToInt32(Console.ReadLine());

            if(kokonaisluku_nappaimistolta == 0)
            {
                Console.Write("\n " + kokonaisluku_nappaimistolta + " ei ole parillinen eika pariton.\n");
            }
            else if ((kokonaisluku_nappaimistolta % 2) == 0)
            {
                Console.Write("\n " + kokonaisluku_nappaimistolta + " on parillinen.\n");
            }
            else
            {
                Console.Write("\n " + kokonaisluku_nappaimistolta + " on pariton. \n");
            }
        }
    }

}
