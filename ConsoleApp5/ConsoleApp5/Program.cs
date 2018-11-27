using System;

namespace ConsoleApp5
{
    class Muotoiluja
    {
        static void Main()
        {
            int joku_kokonaisluku = 123456;

            Console.Write("\n{0, 9:D}   right justified", joku_kokonaisluku);
            Console.Write("\n{0,-9:D}   left justified", joku_kokonaisluku);
            Console.Write("\n{0, 9:X}   right hexadecimal", joku_kokonaisluku);
            Console.Write("\n{0,-9:X}   left hexadecimal", joku_kokonaisluku);
            Console.Write("\n{0, 0:D}  no printing field", joku_kokonaisluku);
            Console.Write("\n{0, 0:X}  hexadecimal", joku_kokonaisluku);
            Console.Write("\n{0, 0:x}  hexadecimal lowercase", joku_kokonaisluku);
            Console.Write("\n{0, 0:D12}  leading zeroes", joku_kokonaisluku);
            Console.Write("\n{0, 0:X12}  hexadecimal", joku_kokonaisluku);
            Console.Write("\n{0, 0:N}  digit grouping", joku_kokonaisluku);
            Console.Write("\n{0, 0:C}  currency value", joku_kokonaisluku);
            Console.Write("\n");
            Console.Write("\n" + joku_kokonaisluku.ToString().PadLeft(9));
            Console.Write("\n" + joku_kokonaisluku.ToString().PadRight(9));
            Console.Write("\n" + joku_kokonaisluku.ToString("X").PadLeft(9));
            Console.Write("\n" + joku_kokonaisluku.ToString("X").PadRight(9));
            Console.Write("\n" + joku_kokonaisluku.ToString());
            Console.Write("\n" + joku_kokonaisluku.ToString("X"));
            Console.Write("\n" + joku_kokonaisluku.ToString("x"));
            Console.Write("\n" + joku_kokonaisluku.ToString("D12"));
            Console.Write("\n" + joku_kokonaisluku.ToString("X12"));
            Console.Write("\n" + joku_kokonaisluku.ToString("N"));

        }
    }

}
