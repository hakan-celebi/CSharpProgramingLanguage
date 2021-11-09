using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12_ornekprogram2
{
    class Program
    {
        static void Main(string[] args)
        { 
            for (int i = 1; i <= 10; i++)
            {
                for (int t = 1; t <= 10; t++)
                {
                    int sonuc = i * t;
                    Console.WriteLine("{0}*{1} : {2}", i, t, sonuc);
                }
            }
            Console.ReadLine();
            Console.Clear();
            int[] sayidiz = new int[10];
            int arasayi;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}.Sayıyı Giriniz : ", i + 1);
                sayidiz[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int t = 0; t < 10; t++)
                {
                    if (sayidiz[i] > sayidiz[t])
                    {
                        arasayi = sayidiz[i];
                        sayidiz[i] = sayidiz[t];
                        sayidiz[t] = arasayi; 
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.Write(sayidiz[i]);
                }
                else
                {
                    Console.Write(">" + sayidiz[i]);
                }
            }

                Console.ReadLine();
        }
    }
}
