using System;

namespace testausta
{
    using System;
    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Anna kuukauden numero: ");
            string line = Console.ReadLine();
            int numero;
            try
            {
                numero = Int32.Parse(line);
                if (numero > 0 && numero <= 12)
                    {
                        switch (numero)
                        {
                            case (4):
                            case (6):
                            case (9):
                            case (11):
                                Console.WriteLine("30 päivää");
                                break;
                            case (2):
                                Console.WriteLine("28 tai 29 päivää");
                                break;
                            default:
                                Console.WriteLine("31 päivää");
                                break;
                        }
                    }

                else
                {
                   Console.WriteLine("Numero ei ole kuukauden numero");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("{0} ei ole numero", line);
            }

        }
    }
}
