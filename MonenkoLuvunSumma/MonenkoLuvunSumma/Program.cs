using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonenkoLuvunSumma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monenko ensimmäisen luvun summan haluat? ");
            int luku = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            for (int i = 1; i <= luku; i++)
            {
                Console.Write(i + "\t");
                summa = summa + i;
            }
            Console.WriteLine("\nLukujen summa = " + summa + "\n");
        }
    }
}
