using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9_fordongusu
{
    class Program
    {
        /*3-For Döngüsü:
        Not: /n Yazdığımız zaman html deki <br> komutunun işini görür ve sağına yazdığımız yazıyı aşağıya atar.
        Not: break komutu ile döngüyü sonlandırabiliriz.

        */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            for (int sayi = -10000; sayi <= 100; sayi++) 
            {
                Console.WriteLine(sayi);
            }
            Console.Clear();
            //Kullanıcının Girmiş Olduğu Sayının Faktoriyelini Alma Ve Hesaplama
            Console.WriteLine("FAKTORİYEL HESAPLAMA PROGRAMINA HOŞGELDİNİZ");
            int si = 0;
            do
            {
                Console.Write("Hesaplanacak Sayıyı Giriniz : ");
                int girilen = Convert.ToInt32(Console.ReadLine());                
                ulong sonuc = 1;
                if (girilen == 0)
                {
                    Console.WriteLine(girilen + " Sayısının Faktoriyeli 1'dir");
                }
                else
                {
                    ulong girilens = (ulong)girilen;
                    for (ulong faktor = (ulong)girilens; faktor > 0; faktor--)
                    {
                        if (girilen > 0)
                        {
                            Console.Write("{0}*", faktor);
                            sonuc *= faktor;
                        }
                        else
                        {
                            Console.WriteLine("-'li Sayıların Faktoriyelini Alamassın");
                            int si1 = 0;
                            do
                            {
                                Console.Write("Hesaplanacak Sayıyı Giriniz : ");
                                int girilen1 = Convert.ToInt32(Console.ReadLine());
                                ulong sonuc1 = 1;
                                if (girilen1 == 0)
                                {
                                    Console.WriteLine(girilen1 + " Sayısının Faktoriyeli 1'dir");
                                }
                                else
                                {
                                    ulong girilens1 = (ulong)girilen1;
                                    for (ulong faktor1 = (ulong)girilens1; faktor1 > 0; faktor1--)
                                    {
                                        if (girilen1 > 0)
                                        {
                                            Console.Write("{0}*", faktor1);
                                            sonuc1 *= faktor1;
                                        }
                                        else
                                        {
                                            Console.OpenStandardError();
                                        }

                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("{0} Sayısının Faktoriyeli {1}'dir", girilens1, sonuc1);
                                }
                            } while (si1 == 0);
                            Console.ReadLine();

                        }
                        
                    }
                    Console.WriteLine();
                    Console.WriteLine("{0} Sayısının Faktoriyeli {1}'dir", girilens, sonuc);
                } 
            } while (si == 0);
            Console.ReadLine();
        }
    }
}
