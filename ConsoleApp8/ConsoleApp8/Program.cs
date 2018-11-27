using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna viikonpäivän numero (1-7): ");
            int viikonpaivannro;
            viikonpaivannro = Convert.ToInt32(Console.ReadLine());
            switch(viikonpaivannro)
            {
                case 1:
                    Console.WriteLine("Maanantai");
                    break;
                case 2:
                    Console.WriteLine("Tiistai");
                    break;
                case 3:
                    Console.WriteLine("Keskiviikko");
                    break;
                case 4:
                    Console.WriteLine("Torstai");
                    break;
                case 5:
                    Console.WriteLine("Perjantai");
                    break;
                case 6:
                    Console.WriteLine("Lauantai");
                    break;
                default:
                    Console.WriteLine("Sunnuntai");
                    break;
            }
        }
    }
}
