using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ensimmaistalukua
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            for(int i=1; i <= 10; i++)
            {
                Console.Write(i + "\t");
                summa = summa + i;
            }
            Console.WriteLine("\nLukujen summa = " + summa + "\n");
        }
    }
}
