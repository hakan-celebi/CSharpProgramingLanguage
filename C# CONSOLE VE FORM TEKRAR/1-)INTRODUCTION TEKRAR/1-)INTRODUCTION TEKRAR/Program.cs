using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__INTRODUCTION_TEKRAR
{
    class Program
    {
        static void Main(string[] args)
        {
            //'Console.Beep(frekans,çalmasüresi);' kodu bip sesi çıkartır.
            //'Console.ReadLine();' Enter'a basılmadığı sürece konsol ekranını kapatmaz.
            /*for (int i = 500; i < 600; i++)
            {
                Console.Beep(i, 250);
                Console.WriteLine(i);
            }*/
            //Console.ReadLine();
            //Tekrar Dönüp Frekans Testi Uygulaması Yapıcağım.

            //Frekans Testi Uygulaması.
            test:
            Console.WriteLine("Kulak Hassasiyeti Ölçme Programına Hoş Geldiniz");
            long sayac = 0;
            Console.Write("Başlangıç Frekansını Giriniz : ");
            string frek = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Bu İşlem 3 Saniye Sonra Başlıyacaktır Lütfen Hazır Olun. - ");
            for (int i = int.Parse(frek); i < 25000; i+=5)
            {
                sayac++;
                if (sayac <= 30000000)
                {
                    i = int.Parse(frek);
                    if (sayac == 10000000)
                    {
                        Console.Write(1 + " ");
                    }
                    else if (sayac == 20000000)
                    {
                        Console.Write(2 + " ");
                    }
                    else if (sayac == 30000000)
                    {
                        Console.WriteLine(3);
                    }
                }
                else
                {
                    Console.Beep(i, 500);
                    Console.WriteLine(i);
                }
            }
            Console.Write("Lütfen Duyamadığınız Frekansı Girin : ");
            string deger = Console.ReadLine();
            Console.WriteLine();
            Console.Write(deger + " Frekansını Duyamadığınızı Belirttiniz Lütfen Onaylayın (Onay:1 Reddet:2) : ");
            String onay = Console.ReadLine();
            if (Convert.ToInt32(onay) == 1)
            {
                Console.WriteLine();
                Console.Write("Onay Yapıldı Frekans Doktorunuza Gönderilecektir Geçmiş Olsun :)");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Onay Yapılmadı Sizi Teste Tekrar Yönlendiriyorum...");
                Console.WriteLine();
                goto test;
            }
            Console.ReadLine();
        }
    }
}
