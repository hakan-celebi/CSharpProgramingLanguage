using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15_dizilervedonguleruygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            int[] oneldiz = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Random rastsayi = new Random();
                int alinan = rastsayi.Next(0, 11);
                if (oneldiz.Contains(alinan))
                {
                    i--;
                    sayac++;
                }
                else
                {
                    oneldiz[i] = alinan;
                }
            }
            foreach (int d in oneldiz)
            {
                Console.WriteLine(d);
            }
            Console.Write("Aynı Sayıdan {0} Defa Üretilmiştir...", sayac);
            Console.ReadLine();
            Console.Clear();
            //A'Dan Z'Ye Harfleri Yazdır.
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
            //Asal Sayılar...
            bool sec = true;
            for (int i = 2; i < 1000; i++)
            {
                if (i == 2)
                {
                    Console.Write(i + " ");
                }
                else if (i > 2)
                {
                    for (int t = 2; t < i; t++)
                    {
                        if (i % t == 0)
                        {
                            sec = false;
                            break;
                        }
                        else
                        {
                            sec = true;
                            
                        }
                    }
                    if (sec == true)
                    {
                        Console.Write(i + " ");
                    }
                }      
            }
            Console.ReadLine();
        }
    }
}
