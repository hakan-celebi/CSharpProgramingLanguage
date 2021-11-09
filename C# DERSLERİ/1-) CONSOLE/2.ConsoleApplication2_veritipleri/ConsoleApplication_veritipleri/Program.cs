using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2_veritipleri
{
    class Program
    {
        /*Veri Tipleri
         * 1-Tamsayı Tipleri:İçerisinde Tamsayı barındıran tiplerdir
         * 1.1-byte:0-255 arasında değer tutar.
         * -En küçük Tamsayı tipidir.
         * -Ram'de 1 byte yer kaplar.
         * 1.2-sbyte:-128 ile 127 arasında değer tutar.
         * -En küçük Tamsayı tipidir.
         * -Ram'de 1 byte yer kaplar.
         * 1.3-short:-32768 ile +32767 arasında değer tutar.
         * -Ram'de 2 byte yer kaplar.
         * 1.4-ushort:0 ile 65535 arasında değer tutar.
         * -Ram'de 2 byte yer kaplar.
         * 1.5-int:Varsayılan Tamsayı tipidir.
         * -1,14 milyar ile +1,14 milyar arasında değer tutar.
         * -Ram'de 4 byte yer kaplar.
         * 1.6-uint:0 ile 2,28 milyar değer tutar.
         * -Ram'de 4 byte yer kaplar.
         * 1.7-long:Tamsayı tiplerinin en büyüğüdür.
         * -çok ile +çok arasında değer tutar.
         * -Ram'de 8 byte yer kaplar.
         * 1.8-ulong:0 ile +çok arasında değer tutar.
         * -Ram'de 8 byte yer kaplar.
         * 
         * 2-Ondalık Veri Tipleri:
         * 2.1-float:Uzunluk ölçü birimlerinde kullanılır
         * -En küçük ondalık tipidir.
         * 2.2-double:Varsayılan ondalık tipidir.
         * -Matematiksel işlemlerde kullanılır.
         * 2.3-decimal:Ondalık sayıların en büyüğüdür
         * -Parasal işlemlerde kullanılır.
         * -Ram'de 16 byte yer kaplar.
         * 
         * 3-Mantıksal Veri Tipleri:
         * 3.1-bool:İçerisinde sadece 0 veya 1 değerlerini barındırır.
         * -Ram-de 1 bit yer kaplar.
         * 
         * 4-Metinsel Veri Tipleri:
         * 4.1-char:İçerisinde sadece bir karakter barındırır.
         * -Örnek;'A','7','?'.
         * 4.2-string:En çok kullanılan Metinsel Veri Tipidir.
         * -Örnek;"Merhaba Dünya".
         * 
         * 5-Object(Nesne):Özel bir tiptir.
         * -Bütün tipleri içerisinde barındırabilir.
         */
        static void Main(string[] args)
        {
            byte sayi = 5;
            Console.WriteLine(sayi);
            string yazi = "Merhaba Dünya";
            Console.WriteLine(yazi);
            char tekkarakter = 'A';
            Console.WriteLine(tekkarakter);
            bool mantiksaldeger = true;
            Console.WriteLine(mantiksaldeger);
            double ondaliklisayi = 14.5;
            Console.WriteLine(ondaliklisayi);
            object nesne = 4;
            Console.WriteLine(nesne);
            nesne = 13.5;
            Console.WriteLine(nesne);
            nesne = "Hakan";
            Console.WriteLine(nesne);
            nesne = false;
            Console.WriteLine(nesne);
            mantiksaldeger = (bool)nesne;
            Console.WriteLine(mantiksaldeger);
            Console.ReadLine();
        }
    }
}
