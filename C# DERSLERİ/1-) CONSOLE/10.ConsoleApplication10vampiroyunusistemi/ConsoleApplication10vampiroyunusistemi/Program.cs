using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10vampiroyunusistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VAMPİR KİM !");
            Console.Write("Kaç Kişilik Oyun Kuracaksınız : ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] vampirkim = new int[adet]; 
            for (int i = 0; i < adet; i++)
            {
                Random vmpr = new Random();
                int gelen = vmpr.Next(1, adet+1);
                if (vampirkim.Contains(gelen))
                {
                    i--;
                }
                else
                {
                    vampirkim[i] = gelen;
                }
            }
            for (int i = 0; i < adet; i++)
            {
                Console.Write("Bir Sayı Giriniz : ");
                int girilen = Convert.ToInt32(Console.ReadLine());
                if (girilen <= adet && girilen > 0)
                {
                    if (girilen == vampirkim[0])
                    {
                        Console.WriteLine("Vampirsiniz Bolşans :)");
                        int sayac = 0;
                        do
                        {
                            sayac++;
                        } while (sayac < 800000000);
                        Console.Clear();
                    }
                    else if (girilen == vampirkim[1])
                    {
                        Console.WriteLine("Vampirsiniz Bolşans :)");
                        int sayac = 0;
                        do
                        {
                            sayac++;
                        } while (sayac < 800000000);
                        Console.Clear();
                    }
                    else if (girilen == vampirkim[2])
                    {
                        Console.WriteLine("Büyücüsünüz Bolşans :)");
                        int sayac = 0;
                        do
                        {
                            sayac++;
                        } while (sayac < 800000000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Köylüsünüz Bolşans :)");
                        int sayac = 0;
                        do
                        {
                            sayac++;
                        } while (sayac < 800000000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("1 İle {0} Sayıları Arasında Sayı Girmeniz Gerekiyor",adet);
                    i--;
                }
                
            }
            Console.ReadLine();
            
        }
    }
}
