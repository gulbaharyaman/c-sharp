using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcının girdiği sayı dizinin içinde var mı? Kontrol eden varsa kaç tane olduğunu yoksa uyarı veren program

            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };
            int adet = 0;
            int sayi;
            Console.Write("lütfen bir sayı giriniz: ");
            sayi=Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++) {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if (adet == 0)
            {
                Console.WriteLine("girdiğiniz sayı dizide bulunmuyor!");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı dizide bulundu");
                Console.WriteLine("adet : " + adet);
            }
            Console.ReadLine();
        }
    }
}
