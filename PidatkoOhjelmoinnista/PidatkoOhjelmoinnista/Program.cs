using System;

namespace PidatkoOhjelmoinnista
{
    class Tykkaa
    {
        static void Main()
        {
            char character_from_keyboard;

            Console.Write("\n Pidatko C# ohjelmointikielesta?"
                        + "\n Ole hyva ja vastaa joko K tai E :  ");

            character_from_keyboard = Convert.ToChar(Console.ReadLine());

            if ((character_from_keyboard == 'K') ||
                 (character_from_keyboard == 'k'))
            {
                Console.Write("\n Se on mukava kuulla. \n");
            }
            else if ((character_from_keyboard == 'E') ||
                      (character_from_keyboard == 'e'))
            {
                Console.Write("\n Hoh, mutta minapa pidan sinusta!. "
                            + "\n Toivottavasti vaihdat mielipiteesi pian!.\n");
            }
            else
            {
                Console.Write("\n En ymmarra \""
                            + character_from_keyboard + "\".\n");
            }
        }
    }

}
