using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overflow_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            short result;
            try { 
            num1 = 30;
            num2 = 60;
            result = Convert.ToInt16(num1 * num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}