using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//recursive ve iteratif fonksiyonlar ile girilen sayının faktöriyelini hesaplama
namespace ConsoleApp5
{
    internal class Program
   
    {
        static int fak_ite(int n)
        {
            int f = 1;
            for(int i=1; i<=n; i++)
            {
                f = f * i;
            }
            return f;
        }
        static int fak_rec(int n)
        {
            if (n == 0) return 1;
            else return n*fak_rec(n-1);
        }
        static void Main(string[] args)
        {
            Console.Write("hesaplanmasını istediğiniz faktöriyel");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" faktöriyeli ite: "+fak_ite(n));
            Console.WriteLine(n + " faktöriyeli rec: " + fak_rec(n));
            Console.ReadLine();

        }
    }
}
