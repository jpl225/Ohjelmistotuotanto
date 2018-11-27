using System;

namespace Tehtavia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sinulla on mahdollisuus muuntaa eri yksiköitä toisiksi \n");
            Console.Write("seuraavasti: \n\t1. Mailit kilometreiksi ja painvastoin");
            Console.Write("\n\t2.Celciukset Fahrenheiteiksi ja painvastoin");
            Console.Write("\n\t3.Kilogrammat paunoiksi ja painvastoin");
            Console.Write("\n\t4.Tuumat senteiksi ja painvastoin");
            Console.Write("\n\t5.Gallonat litroiksi ja painvastoin");
            Console.Write("\n\t6.Neliojalat neliometreiksi ja painvastoin");
            Console.Write("\nMinka valitset? ");
            char valinta = Convert.ToChar(Console.ReadLine());

            switch (valinta)
            {
                case '1':
                    Console.Write("Annatko Mailit vai kilometrit (M / K)?");
                    Char pituusvalinta = Convert.ToChar(Console.ReadLine());
                    switch (pituusvalinta) {
                        case 'm':
                        case 'M':
                            Console.Write("Anna mailit: ");
                            int mailit = Convert.ToInt32(Console.ReadLine());
                            double kilometrit = (mailit * 1.6093);
                            Console.Write(mailit + " mailia on " + kilometrit + "kilometria\n");
                            break;
                        case 'k':
                        case 'K':
                            Console.Write("Anna kilometrit: ");
                            int km = Convert.ToInt32(Console.ReadLine());
                            double miles = (km / 1.6093);
                            Console.Write(km + " kilometria on " + miles + " mailia\n");
                            break;
                        default:
                            Console.Write("En ymmärrä syötettäsi!");
                            break;
                    }
                    break;
                case '2':
                    Console.Write("Annatko Celsiukset vai Fahrenheitit (C / F)?");
                    Char lampovalinta = Convert.ToChar(Console.ReadLine());
                    switch (lampovalinta)
                    {
                        case 'c':
                        case 'C':
                            Console.Write("Anna celciukset: ");
                            int celsiukset = Convert.ToInt32(Console.ReadLine());
                            double fahrenheit = celsiukset * 1.8 + 32;
                            Console.Write(celsiukset + "celsiusta on " + fahrenheit + " fahrenheitia\n");
                            break;
                        case 'f':
                        case 'F':
                            Console.Write("Anna Fahrenheitit: ");
                            int fh = Convert.ToInt32(Console.ReadLine());
                            double celsius = fh / 1.8 - 32;
                            Console.Write(fh + " fahrenheitia on " + celsius + " celsiusta\n");
                            break;
                        default:
                            Console.Write("En ymmärrä syötettäsi!");
                            break;
                    }
                    break;
                case '3':
                    Console.Write("Annatko kilogrammat vai paunat (K / P)?");
                    Char painovalinta = Convert.ToChar(Console.ReadLine());
                    switch (painovalinta)
                    {
                        case 'k':
                        case 'K':
                            Console.Write("Anna kilogrammat: ");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            double paunat = (kilo * 2.2046);
                            Console.Write(kilo + " kiloa on " + paunat + "paunaa\n");
                            break;
                        case 'p':
                        case 'P':
                            Console.Write("Anna paunat: ");
                            int lb = Convert.ToInt32(Console.ReadLine());
                            double kiloa = (lb / 2.2046);
                            Console.Write(lb + " paunaa on " + kiloa + " kiloa\n");
                            break;
                        default:
                            Console.Write("En ymmärrä syötettäsi!");
                            break;
                    }
                    break;
                case '4':
                    Console.Write("Annatko Tuumat vai sentit (T / S)?");
                    Char mittavalinta = Convert.ToChar(Console.ReadLine());
                    switch (mittavalinta)
                    {
                        case 't':
                        case 'T':
                            Console.Write("Anna tuumat: ");
                            int tuumat = Convert.ToInt32(Console.ReadLine());
                            double sentit = tuumat * 2.54;
                            Console.Write(tuumat + "tuumaa on " + sentit + " senttia\n");
                            break;
                        case 's':
                        case 'S':
                            Console.Write("Anna sentit: ");
                            int sentti = Convert.ToInt32(Console.ReadLine());
                            double tuuma = sentti / 2.54;
                            Console.Write(sentti + " senttia on " + tuuma + " tuumaa\n");
                            break;
                        default:
                            Console.Write("En ymmärrä syötettäsi!");
                            break;
                    }
                    break;
                case '5':
                    Console.Write("Annatko gallonat vai litrat (G / L)?");
                    Char nestevalinta = Convert.ToChar(Console.ReadLine());
                    switch (nestevalinta)
                    {
                        case 'g':
                        case 'G':
                            Console.Write("Anna gallonat: ");
                            int gallona = Convert.ToInt32(Console.ReadLine());
                            double litraa = (gallona * 3.79);
                            Console.Write(gallona + " gallonaa on " + litraa + "litraa\n");
                            break;
                        case 'l':
                        case 'L':
                            Console.Write("Anna litrat: ");
                            int litrat = Convert.ToInt32(Console.ReadLine());
                            double gallonaa = (litrat / 3.79);
                            Console.Write(litrat + " litraa on " + gallonaa + " gallonaa\n");
                            break;
                        default:
                            Console.Write("En ymmärrä syötettäsi!");
                            break;
                    }
                    break;
                case '6':
                    Console.Write("Annatko neliojalat ja neliometrit (J / M)?");
                    Char alavalinta = Convert.ToChar(Console.ReadLine());
                    switch (alavalinta)
                    {
                        case 'j':
                        case 'J':
                            Console.Write("Anna neliojalat: ");
                            int jalat = Convert.ToInt32(Console.ReadLine());
                            double metria = jalat / 10.764;
                            Console.Write(jalat + "neliojalkaa on " + metria + " neliometria\n");
                            break;
                        case 'M':
                        case 'm':
                            Console.Write("Anna neliometrit: ");
                            int metrit = Convert.ToInt32(Console.ReadLine());
                            double jalkaa = metrit * 10.764;
                            Console.Write(metrit + " neliometria on " + jalkaa + " neliojalkaa\n");
                            break;
                        default:
                            Console.Write("En ymmärrä syötettäsi!");
                            break;
                    }
                    break;
                default:
                    Console.Write("En ymmärrä syötettäsi!");
                    break;

            }

        }
    }
}
