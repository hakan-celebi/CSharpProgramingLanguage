using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6_whiledongusu
{
    class Program
    {
        /*-Döngüler:Belirli bir kod bloğunu belirli bir koşula göre tekrar tekrar çalıştırmayı sağlayan yapılardır.
         * 4 Tane döngü çeşiti vardır.
         * 1-While Döngüsü:
         * while(koşul) 
         * {
         * 
         * } 
         */
        static void Main(string[] args)
        {
            // Yazı Rengi
            //Console.ForegroundColor = ConsoleColor.Green;

            // Arkaplan Rengi
            //Console.BackgroundColor = ConsoleColor.Gray;

            int sayi = 0;
            while (sayi <= 100)
            {
                Console.WriteLine("Loading%{0}",sayi);
                sayi++;
            }
            Console.WriteLine();
            Console.WriteLine("This data is uploaded.");
            //Console.Clear();
            //Ardışık Çift Sayıların Toplamı Ve Ardışık Tek Sayıların Toplamı;
            int açt = 0, att = 0;
            int deger = 0;
            while (deger <= 100)
            {
                if (deger % 2 == 0)
                    açt += deger;
                else
                    att += deger;
                deger++;
            }
            Console.WriteLine();
            Console.WriteLine("Ardışık Çift Sayıların Toplamı(0'dan 100'e) : " + açt);
            Console.WriteLine();
            Console.Write("Ardışık Tek Sayıların Toplamı(0'dan 100'e) : " + att);
            Console.WriteLine();
            int toplamçift = 0, toplamtek = 0;
            int eklen = 0;
            while (eklen <= 1000)
            {
                if (eklen % 2 == 0)
                    toplamçift += eklen;
                else
                    toplamtek += eklen;
                eklen++;
            }
            Console.WriteLine();
            Console.Write("ÇİFT :" + toplamçift + " TEK :" + toplamtek);
            Console.WriteLine();
            //Console.Clear();
            int çiftekle = 0;
            Console.WriteLine();
            Console.Write("Ardışık Çift Sayılar Toplama Yardımcısı.");
            Console.WriteLine();
            Console.Write("İlk Sayı :");
            string ilksayi = Console.ReadLine();
            int alinans = int.Parse(ilksayi);
            Console.Write("Son Sayı :");
            string sonsayi = Console.ReadLine();
            int değişen1 = int.Parse(ilksayi);
            int değişen2 = int.Parse(sonsayi);
            if (değişen1 != 0)
                çiftekle = değişen1;
            while (çiftekle <= değişen2)
            {
                
                if (çiftekle % 2 == 0) 
                {
                    değişen1 += çiftekle;   
                }
                çiftekle++;
            }
            Console.WriteLine();
            Console.WriteLine(değişen1 - alinans);
            Console.WriteLine();
            Console.Write("Not :{0} Ve {1} Dahildir.", alinans, değişen2);
            Console.ReadLine();
        }
    }
}
