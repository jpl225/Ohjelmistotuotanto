using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosiNega
{
    class Program
    {
        static void Main(string[] args)
        {
            // alustetaan kokonaislukumuuttuja luku ja annetaan sen arvoksi 0
            int luku = 0; 
            // kirjoitetaan ohjeet käyttäjälle, että hän osaa käyttää ohjelmaa
            Console.Write("Tämä ohjelma tarkistaa, millaisia lukuja annat, eli");
            Console.Write("\nonko ne positiivisia vai negatiivisia. Kun haluat");
            Console.Write("\nlopettaa, anna luku 999");
            // tehdään ikuinen looppi, kunnes käyttäjä lopettaa sen painamalla 999
            while(luku != 999)
            {
                // Pyydetään käyttäjältä syötettä
                Console.Write("\nAnna luku: ");
                // Muutetaan tekstisyöte kokonaislukumuuttujaksi
                luku = Convert.ToInt32(Console.ReadLine());
                // Tarkastetaan, onko annettu muuttuja 0
                if(luku == 0)
                {
                    // Kirjoitetaan sitaattien sisään normaali teksti ja plussan kanssa yhdistetään siihen
                    // pyydetty muuttuja 'luku' ja sitten taas sitaateilla normaalia tekstiä plussan kanssa
                    Console.WriteLine("Luku " + luku + " ei ole positiivinen eikä negatiivinen");
                }
                // Tarkastetaan, onko annettu muuttuja negatiivinen
                else if(luku < 0)
                {
                    // Kirjoitetaan sitaattien sisään normaali teksti ja plussan kanssa yhdistetään siihen
                    // pyydetty muuttuja 'luku' ja sitten taas sitaateilla normaalia tekstiä plussan kanssa
                    Console.WriteLine("Luku " + luku + " on negatiivinen");
                }
                // Mikäli annettu muuttuja ei ole 0 eikä negatiivinen, sen on oltava positiivinen
                else
                {
                    // Kirjoitetaan sitaattien sisään normaali teksti ja plussan kanssa yhdistetään siihen
                    // pyydetty muuttuja 'luku' ja sitten taas sitaateilla normaalia tekstiä plussan kanssa
                    Console.WriteLine("Luku " + luku + " on positiivinen");
                }
            }
            

        }
    }
}
