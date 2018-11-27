using System;

namespace ConsoleApp4
{
    class Lisayksia
    {
        static void Main()
        {
            int joku_kokonaisluku = 1234;

            Console.Write("\n ");
            Console.Write("xxxx" + joku_kokonaisluku + "zzzz");
            Console.Write("\n ");
            Console.Write("xxxx" + joku_kokonaisluku + joku_kokonaisluku + "zzzz");
            Console.Write("\n ");
            Console.Write("xxxx" + (joku_kokonaisluku + joku_kokonaisluku) + "zzzz");
            Console.Write("\n ");
            Console.Write(joku_kokonaisluku + joku_kokonaisluku + "xxxx" + "zzzz");
            Console.Write("\n ");
            Console.Write(joku_kokonaisluku + (joku_kokonaisluku + "xxxx") + "zzzz");
            Console.Write("\n ");
            Console.Write("xxxx" + "zzzz" + joku_kokonaisluku + (joku_kokonaisluku + 1));
            Console.Write("\n ");
            Console.Write("xxxx" + "zzzz" + joku_kokonaisluku + joku_kokonaisluku + 1);

        }
    }

}
