using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 0;
            int cekme = 0;
            while (true)
            {
                Console.WriteLine("\n1-Hesap Bilgileri\n2-Para Yatırma\n3-Para Çekme\n4-Çıkış");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Yapmak İstediğiniz İşlemi Giriniz:");
                int deger = int.Parse(Console.ReadLine());
                if (deger == 1)
                {
                    Console.Write("Kalan Bakiyeniz : {0}" , bakiye);
                    Console.WriteLine();
                    Console.WriteLine();
                }
                if (deger == 2)
                {
                    Console.Write("Kaç ₺ yatırmak istersiniz:");
                    int yatırma = int.Parse(Console.ReadLine());
                    bakiye = bakiye + yatırma;
                }
                if (deger == 3)
                {
                    Console.Write("Kaç ₺ Çekmek İstersiniz :");
                    cekme = int.Parse(Console.ReadLine());
                    bakiye = bakiye - cekme;
                }
                if (deger == 4)
                {
                    Environment.Exit(1);
                }
                if (bakiye < cekme)
                {
                    Console.WriteLine("Yeterli Bakiyeniz Yok.");
                }
            }
        }
    }
}
