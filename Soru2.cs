using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev_CSharp101_Odev1
{
    internal class Soru2
    {
        public static void Odev2()
        {
            int n = 0, m = 0;

            do
            {
                Console.WriteLine("Lütfen 2 Pozitif Sayı Giriniz");
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine("{0}. sayıyı girin", i);

                    if (i == 1)
                        n = int.Parse(Console.ReadLine());
                    else
                        m = int.Parse(Console.ReadLine());
                }

            } while (n < 0 || m < 0);

            Console.WriteLine("***********************************");

            Console.WriteLine("Lütfen {0} adet sayı giriniz", n);

            int inputNumber = 0;
            List<int> girilenSayilar = new List<int>();

            do
            {
                Console.WriteLine("Lütfen Pozitif Sayı Girin");
                girilenSayilar.Clear();

                for (int i = 1; i <= n; i++)
                {
                    inputNumber = int.Parse(Console.ReadLine());
                    if (inputNumber < 0)
                        break;

                    girilenSayilar.Add(inputNumber);
                }

            } while (inputNumber < 0);

            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < girilenSayilar.Count; i++)
            {
                if (girilenSayilar[i] % m == 0 || girilenSayilar[i] == m)
                {
                    Console.WriteLine("{0} sayısı {1} sayısına eşit veya tam bölünüyor ", girilenSayilar[i], m);
                }
            }
        }
    }
}
