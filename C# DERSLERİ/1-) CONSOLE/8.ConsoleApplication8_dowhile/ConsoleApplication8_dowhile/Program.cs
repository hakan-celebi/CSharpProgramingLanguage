using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8_dowhile
{
    class Program
    {
        /*2-Do While Döngüsü:
        *do
        {
        while (koşul);
        }
        */
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayı = 0;
            string seçim1 = "+";
            string seçim2 = "-";
            Console.WriteLine("4 İŞLEM YARDIMCISINA HOŞGELDİNİZ TOPLAMA İŞLEMİ İÇİN + ÇIKARTMA İŞLEMİ İÇİN - YAZINIZ...");
            string anaseçim = Console.ReadLine();
            if (anaseçim == seçim1)
            {
                do
                {
                    Console.Write("Sayı Giriniz :");
                    sayı = Convert.ToInt32(Console.ReadLine());
                    int gostoplam = toplam;
                    toplam += sayı;
                    Console.WriteLine(gostoplam + "+" + sayı + " : " + toplam);

                } while (sayı != 0);
            }
            else if (anaseçim == seçim2)
            {
                do
                {
                    Console.Write("Sayı Giriniz :");
                    sayı = Convert.ToInt32(Console.ReadLine());
                    int gostoplam = toplam;
                    toplam -= sayı;
                    Console.WriteLine(gostoplam + "-" + sayı + " : " + toplam);

                } while (sayı != 0);
            }
            //Sayı Tahmin Oyunu;
            Console.Clear();
            //1-Step:Rastgele Sayı Üretmek
            int hak = 20;
            Random rastgelesayi = new Random();
            int tutulan1 = rastgelesayi.Next(1,1000);
            int girilen = 0;
            Console.Write("Tahmin Hakkınız : {0}", hak);
            Console.WriteLine();
            do
            {
                Console.WriteLine();
                Console.Write("Bir Sayı Giriniz : ");
                girilen = Convert.ToInt32(Console.ReadLine());
                
                hak--;
                Console.WriteLine();
                Console.Write("Kalan Tahmin Hakkınız : {0}", hak);
                Console.WriteLine();

                Console.WriteLine();
                if (girilen < tutulan1 && hak != 0)
                {
                    Console.WriteLine("Daha Büyük Bir Sayı Giriniz");
                    if (girilen - tutulan1 >= -5 && girilen - tutulan1 <= 0)
                    {
                        Console.WriteLine("Çok Yaklaştınız :)");
                    }
                }
                else if (girilen > tutulan1)
                {
                    Console.WriteLine("Daha Küçük Bir Sayı Giriniz");
                    if (girilen - tutulan1 <= 5 && girilen - tutulan1 >= 0) 
                    {
                        Console.WriteLine("Çok Yaklaştınız :)");
                    }
                }
                
            } while (tutulan1 != girilen && hak !=0);
            if (hak == 1)
            {
                Console.Write(hak);
                if (tutulan1 == girilen)
                {
                    hak++;
                }
                else if (tutulan1 != girilen)
                {
                    hak--;
                }
            }
            else if (hak == 0 && tutulan1 != girilen)
            {
                Console.Write("Tahmin Hakkınız Bitmiştir Kaybettiniz. Tutulan Sayı : {0}", tutulan1);
            }
            else if (tutulan1 == girilen)
            {
                hak++;
                Console.Write("Tebrikler Doğru Cevap");
            }
            Console.ReadLine();
            /*Console.Clear();
            string arti = "+";
            string eksi = "-";
            string bolu = "/";
            string carpi = "*";
            object islem = 0;
            Console.WriteLine("KDASOFT HESAP MAKİNASI UYGULAMASI");
            Console.WriteLine();
            Console.Write(" ");
            object ilksayi = Console.ReadLine();
            Console.Write(" ");
            islem = Console.ReadLine();
            Console.Write(" ");
            object ikincisayi = Console.ReadLine();
            string islemci = Convert.ToString(islem); 
            if (islemci == arti)
            {
                int sayi1 = Convert.ToInt32(ilksayi);
                int sayi2 = Convert.ToInt32(ikincisayi);
                int sonuc = sayi1 + sayi2;
                Console.Write(sayi1 + "+" + sayi2 + " = " + sonuc);
            }
            else if (islemci == eksi)
            {
                int sayi1 = Convert.ToInt32(ilksayi);
                int sayi2 = Convert.ToInt32(ikincisayi);
                int sonuc = sayi1 - sayi2;
                Console.Write(sayi1 + "-" + sayi2 + " = " + sonuc);
            }
            else if (islemci == carpi)
            {
                int sayi1 = Convert.ToInt32(ilksayi);
                int sayi2 = Convert.ToInt32(ikincisayi);
                int sonuc = sayi1 * sayi2;
                Console.Write(sayi1 + "*" + sayi2 + " = " + sonuc);
            }
            else if (islemci == bolu)
            {
                int sayi1 = Convert.ToInt32(ilksayi);
                int sayi2 = Convert.ToInt32(ikincisayi);
                int sonuc = sayi1 / sayi2;
                Console.Write(sayi1 + "/" + sayi2 + " = " + sonuc);
            }*/
            Console.ReadLine();   
        }
    }
}
