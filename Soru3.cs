using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_CSharp101_Odev1
{
    internal class Soru3
    {
        public static void Odev3()
        {

            int n;

            do
            {
                Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz!");
                n = int.Parse(Console.ReadLine());

            } while (n < 0);

            Console.WriteLine("Lütfen Kelime Giriniz!");
            List<string> girilenKelime = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string kelime = Console.ReadLine();
                girilenKelime.Add(kelime);
            }

            Console.WriteLine("Girilen Kelimeler Tersten");
            girilenKelime.Reverse();

            foreach (var item in girilenKelime)
            {
                Console.WriteLine(item);
            }
        }
    }
}
