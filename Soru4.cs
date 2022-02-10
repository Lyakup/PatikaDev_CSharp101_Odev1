using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_CSharp101_Odev1
{
    internal class Soru4
    {
        public static void Odev4()
        {
            Console.WriteLine("Lütfen Cümle Yazınız");
            string cumle = Console.ReadLine();

            int kelimeSayisi = 0;
            int harfSayisi = 0;

            kelimeSayisi = cumle.Split(' ').Length;
            Console.WriteLine(kelimeSayisi);

            harfSayisi = cumle.Replace(" ", "").Length;
            Console.WriteLine(harfSayisi);

        }
    }
}
