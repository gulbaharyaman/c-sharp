using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//girilen sayının istenilen kadarüssünü alma
namespace ConsoleApp6
{
    internal class Program
    {
        static int us_al(int a,int b)
        {
            int sonuc = 1;
            if (b == 0 && a == 0)
                Console.Write("tanımsız");
            else if (b == 0)
                return sonuc;
            else
            {
                for (int i = 1; i <= b; i++)
                {
                    sonuc = sonuc * a;
                }
            }
            return sonuc; 
        }
        static void Main(string[] args)
        {
            Console.Write("üssü alınacak sayıyı giriniz ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("üssü giriniz ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a+" üssü "+b+" = "+us_al(a,b));
            Console.ReadLine();
        }
    }
}
