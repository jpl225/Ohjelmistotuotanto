using System;
using System.Collections.Generic;

namespace Listaesimerkki
{
    class Program
    {
        static void Main()
        {
            string kurssi = "";
            string paivays;
            string nimi;
            DateTime paiv;
            int arvosana;
            List<kurssisuoritus> ks = new List<kurssisuoritus>();
            while (kurssi != ".")
            {
                Console.Write("Anna arvioitava kurssi: ");
                kurssi = Console.ReadLine();
                if (kurssi != ".")
                {
                    Console.Write("Anna arviointipäivä: ");
                    paivays = Console.ReadLine();
                    Console.Write("Anna arvioitava henkilö: ");
                    nimi = Console.ReadLine();
                    Console.Write("Anna arvosana: ");
                    arvosana = Int32.Parse(Console.ReadLine());
                    paiv = Convert.ToDateTime(paivays);

                    ks.Add(new kurssisuoritus() { course = kurssi, name = nimi, dat = paiv, grade = arvosana });

                }
                Console.WriteLine();

            }


            Console.WriteLine();
            foreach (kurssisuoritus erote in ks)
            {
                Console.WriteLine(erote);
            }

        }
        public class kurssisuoritus
        {
            public string course
            {
                get; set;
            }
            public string name
            {
                get; set;
            }
            public DateTime dat
            {
                get; set;
            }
            public int grade
            {
                get; set;
            }
            public override string ToString()
            {
                return "Kurssi: " + course + "\t nimi: " + name + "\t päiväys: " + dat.ToString("dd.MM.yyyy") + "\t arvosana: " + grade;
            }
        }
    }
}
