using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimet = new string[10];
            string pyyda = "";
            int x = 1;
            while (pyyda != ".")
            {
                Console.Write("Anna " + x + ".s nimi: ");
                pyyda = Console.ReadLine();
                if (pyyda != ".")
                {
                    nimet[x-1] =pyyda;
                    x++;
                    if(x>10)
                    {
                        pyyda = ".";
                    }
                }
            }
            Console.Write("Antamasi nimet olivat: \n");
            for(int y = 0; y < nimet.Length; y++ )
            {
                Console.Write(nimet[y] + "\t");
            }
            
        }
    }
}
