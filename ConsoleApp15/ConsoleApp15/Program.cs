using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string etunimi="", sukunimi, lahiosoite, postinro, postitp, puhelin, sahkoposti;
            List<osoitetiedot> os = new List<osoitetiedot>();
            int x = 1;
            while (etunimi != ".")
            {
                if(etunimi != ".") { 
                if (x < 3)
                {
                    Console.Write("Anna " + x + ".n etunimi: ");
                }
                else
                {
                    Console.Write("Anna " + x + ".s etunimi: ");
                
                etunimi = Console.ReadLine();
                Console.Write("Anna sukunimi: ");
                sukunimi = Console.ReadLine();
                Console.Write("Anna lähiosoite: ");
                lahiosoite = Console.ReadLine();
                Console.Write("Anna postinumero: ");
                postinro = Console.ReadLine();
                Console.Write("Anna postitoimipaikka: ");
                postitp = Console.ReadLine();
                Console.Write("Anna puhelin: ");
                puhelin = Console.ReadLine();
                Console.Write("Anna sähköposti: ");
                sahkoposti = Console.ReadLine();
                os.Add(new osoitetiedot() { firstname = etunimi, lastname = sukunimi, address = lahiosoite, postalcode = postinro, postalarea = postitp, phonenumber = puhelin, email = sahkoposti });
                }
                Console.WriteLine();
                x++;
                }
            }
            Console.WriteLine();
            foreach (osoitetiedot eroitetaan in os)
            {
                Console.WriteLine(eroitetaan);
                Console.WriteLine();
            }
        }
    }

    public class osoitetiedot
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string postalcode { get; set; }
        public string postalarea { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "Etunimi: " + firstname + "\tSukunimi: " + lastname
                + "\nPostiosoite: " + address + " " + postalcode + " " + postalarea
                + "\nPuhelin :" + phonenumber + " Sähköposti: " + email;
        }
    }
}
