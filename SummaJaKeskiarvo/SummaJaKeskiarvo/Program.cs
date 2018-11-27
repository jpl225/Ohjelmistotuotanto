using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaJaKeskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 1;
            int temp, summa = 0;
            float keskiarvo;
            do
            {
                Console.Write("Anna " + luku + ". luku: ");
                temp = Convert.ToInt32(Console.ReadLine());
                summa = summa + temp;
                luku++;
            } while (luku < 11);
            keskiarvo = summa / 10;
            Console.WriteLine("Lukujen summa on: " + summa + " ja keskiarvo: " + keskiarvo);
        }
    }
}
