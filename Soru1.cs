using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_CSharp101_Odev1
{
    internal class Soru1
    {
        public static void Odev1()
        {
            Console.WriteLine("**** SORU 1 ****");

            int n;

            do
            {
                Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz!");
                n = int.Parse(Console.ReadLine());

            } while (n < 0);

            Console.WriteLine("Girilen Sayı : " + n);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Lütfen {0} adet sayı giriniz!", n);

            List<int> girilenSayilar = new List<int>();
            int inputNumber;
            do
            {
                inputNumber = int.Parse(Console.ReadLine());
                girilenSayilar.Add(inputNumber);
                n--;

            } while (n > 0);


            Console.WriteLine("Girilen Sayılardan Çift Olanlar");
            for (int i = 0; i < girilenSayilar.Count; i++)
            {
                if (girilenSayilar[i] % 2 == 0)
                {
                    Console.WriteLine(girilenSayilar[i]);
                }
            }
        }
    }
}
