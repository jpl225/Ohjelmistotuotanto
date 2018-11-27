using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarjesta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmainen luku: ");
            int eka = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nAnna toinen luku: ");
            int toka = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nAnna kolmas luku: ");
            int kolmas = Convert.ToInt32(Console.ReadLine());
            if((eka > toka) && (eka > kolmas))
            {
                Console.WriteLine("Ensimmäinen luku: " + eka + " oli suurin");
            }
            else if(toka > kolmas)
            {
                Console.WriteLine("Toinen luku: " + toka + " oli suurin");
            }
            else
            {
                Console.WriteLine("Kolmas luku: " + kolmas + " oli suurin");
            }

        }
    }
}
