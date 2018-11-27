using System;

namespace Nappaimistotesti
{
    class Jossittelua
    {
        static void Main()
        {
            char annettu_merkki;

            Console.Write("\n Ole hyva ja anna jokin merkki:  ");

            annettu_merkki = Convert.ToChar(Console.ReadLine());

            if (annettu_merkki < ' ')
            {
                Console.Write("\n Tuo on tulostumaton merkki \n");
            }
            else if (annettu_merkki >= '0' && annettu_merkki <= '9')
            {
                Console.Write("\n Annoit numeron "
                            + annettu_merkki + ". \n ");
            }
            else if (annettu_merkki >= 'A' && annettu_merkki <= 'Z')
            {
                Console.Write("\n " + annettu_merkki
                            + " on iso kirjain. \n");
            }
            else if (annettu_merkki >= 'a' && annettu_merkki <= 'z')
            {
                Console.Write("\n " + annettu_merkki
                            + " pieni kirjain. \n");
            }
            else
            {
                Console.Write("\n " + annettu_merkki
                            + " on erikoismerkki. \n");
            }
        }
    }
}
