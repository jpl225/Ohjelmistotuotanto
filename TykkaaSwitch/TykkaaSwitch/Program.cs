using System;

namespace TykkaaSwitch
{
    class Likecss
    {
        static void Main()
        {
            char merkki_nappaimistolta;

            Console.Write("\n Pidatko C# ohjelmointikielestä?"
                        + "\n Ole hyva ja vastaa joko K tai E :  ");

            merkki_nappaimistolta = Convert.ToChar(Console.ReadLine());

            switch (merkki_nappaimistolta)
            {
                case 'K':
                case 'k':
                    Console.Write("\n Tuo on mukava kuulla. \n");
                    break;
                case 'E':
                case 'e':
                    Console.Write("\n Hoh, mutta minapa pidan sinusta!. "
                                + "\n Toivottavasti muutat mielesi pian!.\n");
                    break;
                default:
                    Console.Write("\n En ymmarra merkkia \""
                                + merkki_nappaimistolta + "\".\n");
                    break;
            }
        }
    }

}
