using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kullanıcıdan 10 adet int değer alan ve
            1-kaç adet tek,çift eleman olduğunu
            2-çift değerlerin toplamını,tek değerlerin toplamını
            3-hangi toplam büyükse çift/tek değerlerinin toplamı daha büyüktür şeklinde yazdırsın*/

            int[]sayilar=new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;

            int tekToplam = 0;
            int ciftToplam = 0;

            int kullanicideger;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine((i+1)+".index değerini giriniz");
                kullanicideger = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = kullanicideger;
            }

            for(int j=0;j<sayilar.Length;j++)
            {
                if (sayilar[j] % 2 == 0)
                {
                    ciftAdetToplam++;
                    ciftToplam += sayilar[j];
                }
                else
                {
                    tekAdetToplam++;
                    tekToplam += sayilar[j];
                }
            }
            if (ciftToplam > tekToplam)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların daha büyüktür");
            }
            else if (ciftToplam == tekToplam)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamına eşittir");
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından daha büyüktür");
            }
            Console.WriteLine("**************************************************");
            Console.Write("Çift sayıların toplamı: " + ciftToplam);
            Console.WriteLine(" Çift sayıların adedi: "+ciftAdetToplam);

            Console.Write("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine(" Tek sayıların adedi: " + tekAdetToplam);

            Console.ReadLine();
        }
    }
}
