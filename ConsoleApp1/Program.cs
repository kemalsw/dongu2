using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("1 den başlayıp console dan girilen sayıya kadar ortalama hesaplayıp ekrana yazdıran program");
              Console.WriteLine("Bir sayı giriniz");
              int sayi = Convert.ToInt32(Console.ReadLine());
              int sayac = 1;
              int toplam = 0;
              int ortalama;

              while (sayac<=sayi)
              {
                  toplam += sayac;
                  sayac++;
              }
              ortalama = toplam / sayac;
              Console.WriteLine(ortalama  );
              Console.ReadLine();*/

            char karakter = 'a';
            while (karakter<='z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }
            Console.ReadLine();

        }
    }
}
