using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        /*Tip Dönüşümleri:Bir tipdeki değerleri başka bir tipe dönüştürmeyi sağlar.
         * 1-Cast:
         * 1.1-Implictly Cast:Kendi kendine dönüşüm işlemi yapar.
         * -Ayrıca dönüşüm işlemi yapmaya gerek yoktur.
         * -Not:Kesinlikle bir tip diğer tipin içerisinde barınabiliyorsa gerçekleşir.
         * -Örnek; short a = 350; int b = a;
         * 1.2-Explicitly Cast:Implictly Cast ile benzer dönüşüm işlemi yapar.
         * -Dönüşüm işlemini ayrıca yapmak gerekir.
         * -Örnek; int a = 214; byte b = (byte)sayi;
         * 
         * 2-Convert Ve Parse:Cast işleminin yetersiz olduğu durumlarda kullanılır.
         * -Metinsel bir ifadeyi Cast yöntemi ile bir tipe dönüştüremeyiz.
         * 2.1-Parse:Sadece string bir değeri başka bir tipe dönüştürmeyi sağlar.
         * -Her tipin içerisinde parse metodu bulunur.
         * -Convert'e göre daha performanslıdır fakat daha yeteneksizdir.
         * 2.2-Convert:Herhangi bir tipi herhangi bir tipe dönüştürür.
         * -Parse'a göre daha yetenekli fakat daha az performans sağlar.
         * -Örnek; decimal sayi3 = 10.85m; Veya decimal sayi3 = (decimal)10.85; piçiminde yazılabilir.
         */
        static void Main(string[] args)
        {
            //Implictly Cast Örnek;
            short a = 350;
            Console.WriteLine(a);
            int b = a;
            Console.WriteLine(b);
            //Explictly Cast Örnek;
            int sayi = 214;
            Console.WriteLine(sayi);
            byte c = (byte)sayi;
            Console.WriteLine(c);

            //Cast Yöntemi Yetersiz Kalıyor;
            //string deger = "5";
            //int sayi1 = (int)deger;

            //Parse Örnek;
            String degers = "2";
            Console.WriteLine(degers);
            short sayi2 = short.Parse(degers);
            Console.WriteLine(sayi2);
            //Convert Örnek;
            decimal sayi3 = 10.85m;
            Console.WriteLine(sayi3);
            int sayi4 = Convert.ToInt32(sayi3);
            Console.WriteLine(sayi4);

            //Küçük Hesap Makinası;
            //1-Step:Kullanıcının sayı girmesini sağlamak.
            Console.Write("1.Sayıyı Giriniz :");
            string deger1 = Console.ReadLine();
            Console.Write("2.Sayıyı Giriniz :");
            string deger2 = Console.ReadLine();
            int toplam = 0;
            //2-Step:Girilen Sayılar Toplanmalı Ve String Değeri int'a Dönüştürülmelidir.
            int s1 = int.Parse(deger1);
            int s2 = int.Parse(deger2);
            toplam = s1 + s2;
            //3-Step:Console'a toplam ı yazdırmak.
            Console.WriteLine("Sonuç :" + toplam);
            Console.Write("Sonuç :{0}{1}{2}",s1+"+",s2+"=",toplam);
            


            Console.ReadLine();
        }
    }
}
