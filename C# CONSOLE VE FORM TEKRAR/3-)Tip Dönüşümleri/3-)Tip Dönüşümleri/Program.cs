using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__Tip_Dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tip Dönüşümleri;
             *  Bir tipteki değişkeni başka bir tipe dönüştürmek için kullanılır. Örneğin int değerini string değerine dönüşyürmeye
             * olanak sağlar. Tip Dönüşümleri 3'e ayrılır.
             * 
             * 1-)Cast:
             * 
             * 1.1-)Ipmlicitly Cast:
             *  Kendi kendine dönüşüm yapar ve bizim ayrıca dönüşüm işlemi yapmamıza gerek yoktur. Bir tip diğer tipin içinde barına
             * biliyorsa gerçekleşir.
             * Örnek: short a = 65; ve int b = a; olarak kullanabiliriz fakat int a = 1000000; short b = a; olarak asla yapamayız çünkü
             * short değişkeninin alabileceğinden fazla bir değer içeriyor int değeri.
             * 
             * 1.2-)Explicitly Cast:
             *  Benzer tipler arasında dönüşüm yapmayı sağlar ve bu sefer dönüşüm işlemini biz yaparız.
             * Örnek: int a = 214; byte b = a; olarak yapamayız çünkü int içindeki değer byte'dan daha büyük olabilme ihtimali olduğu
             * için otamatik yapamaz yapılması gereken şudur byte b = (byte)a; şeklindedir.
             * !Dikkat: Bu işlem için de int değerinin byte değerinin içine sığması gerekmektedir.
             * 
             * 2-)Convert ve Parse:
             *  Cast tipi benzer değişken tipleri arasında olduğu için bazen yetersiz kalır bu yizden Convert ve Parse yöntemini 
             * kullanırız. Metinsel bir ifadeyi sayı tipine dönüştürebiliriz.
             * Örnek: string a = "5"; int b = a; şeklinde kullanamayız veya int b = (int)a; şeklinde kullanamayız.
             * 
             * 2.1-)Parse:
             *  Sadece string ifadeler için kullanılır string bir değeri başka bir tipe dönüştürmeyi sağlar ve her tipin içinde bulunur
             * Convert metoduna göre daha performanslıdır fakat daha az işlevseldir.
             * Örnek: string a = "5"; int b; b'nin içine a daki 5 değerini atabilmemiz için b = int.Parse(a); bu Parse işlemi
             * kullanılır
             * 
             * 2.2-)Convert:
             *  Herhangi bir değişken tipini herhangi bir değişken tipine dönüştürmeyi sağlar.
             * Örnek:float a = 5.3; int b = a yapabilmemiz için bu tipi int'a dönüştürmemiz gerekir çünkü int ondalıklı sayı almaz bu 
             * yüzden int a'yı aldığı zaman yuvarlayarak 5 yapar. int b = Convert.ToInt32(a); yaparak a yı int b ye atabiliriz.
             *  
             * 
             * 
             */

            //Console.Write("Hakan " , "Gül" , "Naber");
            //Console.ReadLine();

            //Hesap Makinesi Uygulaması
            int a, b , sonuc;
            Console.WriteLine("Hesap Makinası Uygulamasına Hoşgeldiniz...");
            start:
            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz (t = toplama çı = çıkarma ça = çarpma b = bölme) : ");
            string islem = Console.ReadLine();
            if (islem == "t" | islem == "T")
            {
                Console.WriteLine();
                Console.Write("İlk Sayıyı Giriniz : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("İkinci Sayıyı Giriniz : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                sonuc = a + b;
                Console.WriteLine("Toplama İşlemin Sonucu = " + sonuc);
            }

            else if (islem == "çı" | islem == "ÇI" | islem == "Çı" | islem == "çI")
            {
                Console.WriteLine();
                Console.Write("İlk Sayıyı Giriniz : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("İkinci Sayıyı Giriniz : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                sonuc = a - b;
                Console.WriteLine("Çıkarma İşleminin Sonucu = " + sonuc);
            }

            else if (islem == "ça" | islem == "ÇA" | islem == "Ça" | islem == "çA")
            {
                Console.WriteLine();
                Console.Write("İlk Sayıyı Giriniz : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("İkinci Sayıyı Giriniz : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                sonuc = a * b;
                Console.WriteLine("Çarpma İşleminin Sonucu = " + sonuc);
            }

            else if (islem == "b" | islem == "B")
            {
                Console.WriteLine();
                Console.Write("İlk Sayıyı Giriniz : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("İkinci Sayıyı Giriniz : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                sonuc = a / b;
                Console.WriteLine("Bölme İşleminin Sonucu = " + sonuc);
            }

            else
            {
                Console.WriteLine("Geçersiz İşlem Girdiniz Lütfen Tekrar Deneyiniz");
                goto start;
            }

            Console.ReadLine();

            string onay;
            Console.Write("Başka Bir İşlem Yapmak İstermisiniz (E/H) : ");
            onay = Console.ReadLine();

            if (onay == "e" | onay == "E")
            {
                goto start;
            }

            else if (onay == "h" | onay == "H")
            {
                Console.WriteLine("Uygulamamızı Kullandığınız İçin Teşekkür Ederiz...");
            }

            else
            {
                Console.WriteLine("Onay Tanımlanamadı Uygulama Kapatılıyor...");
            }

            Console.ReadLine();
        }
    }
}
