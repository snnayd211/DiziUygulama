using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            Random rnd = new Random();
            int[] a = new int[10];          
            //1 ile 100 arasında üretilen 10 adet rastgele sayı dizi  içerisine girilecek
            for (int i = 0; i < 10; i++)
            {               
                sayi = rnd.Next(1, 100);

                a[i] = sayi;               
                Console.WriteLine(a[i]);
            }
            
            int toplam = 0;
            for (int sn = 0; sn < dizi.Length; sn++)
            {
                if (a[sn] < 50)
                    toplam = toplam + a[sn];
            } 
            Console.WriteLine("50 Den Küçük Sayıların Toplamı =) " + toplam);
            
        }
    }
}
