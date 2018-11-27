using System;

namespace Kahdentoistakertotaulu
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x<28; x++)
            {
                Console.WriteLine();
                for(int y = 1; y < 15; y++)
                {
                    Console.Write("\t" + y * x);
                }
            }Console.WriteLine();
        }
    }
}
