using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11_diziler
{
    class Program
    {
        /*Diziler:Aynı iş ve aynı amaç için içersinde birden fazla değer barındırmayı sağlayan yapılardır.
        -Dizileri Tanımlarken;Ne kadar yer kaplayacakları yani içerisinde kaçtane eleman barındıracakları belli olsun diye tanımlama sırasında adet verilir.
        -Her tibin dizisi olabilir.
        -Herhangi bir tipi dizi haline getirmek için,tipin sonuna "[]" koyulur.
        -Faydası:Aynı isim altında bir tipe ait birden fazla değer tutabilir.
        -Dizilerde numaralandırma index diye adlandırılır.
        -0'dan başlar.Yani birinci sıradaki elemanın index numarası 0'dır. 
         */
        static void Main(string[] args)
        {
            string[] isimler = new string[10];
            int[] sayilar = new int[5];
            //Diziye Değer Atama Yöntemi;
            isimler[4] = "Ahmet";
            sayilar[0] = 4;
            //Object Initilazier;
            char[] karakterler = { 'A', '7', '?', '+', 'c' };
            object[] karakters = { "HAKAN", 'K', 'N' };
            //Dizilerin Boyutu Nasıl Arttırılır;
            Array.Resize(ref karakterler, 6);
            //Dizilerin Boyutunu Öğrenme;
            int boyut = isimler.Length;
            Console.Write(boyut);
            Console.Write(" " + karakterler[0]);
            //Herhangi Bir Dizinin Boyutunu Var Olan Boyutundan Bir Arttırmak İstesek Ne Yaparız;
            Array.Resize(ref isimler, isimler.Length + 1);
            Console.Write(" " + isimler.Length);

            //Console.ReadLine();
            Console.Clear();
            string kullanıcı1 = "hakan.58";
            string şifre = "154789236h";
            Console.WriteLine("ERBİL KORU ANADOLU LİSESİ ÖĞRENCİ SİSTEMİ : ");
            Console.Write("Kullanıcı Adı : ");
            string kullanıcı = Console.ReadLine();
            Console.Write("Şifre : ");
            string parola = Console.ReadLine();
            if (kullanıcı == kullanıcı1 && parola == şifre)
            {
                int eklenen = 0;
                int okulno = 0;
                int deger = 0;
                do
                {
                    Console.Write("Öğrenci Eklemek İçin 1'e Öğrenci Kontrol Etmek İçin 2'Ye Basınız Çıkmak İçin Herangi Bir Tuşa Basın.");
                    int istek = Convert.ToInt32(Console.ReadLine());
                    string[] ogrencis = new string[0];

                    if (istek == 1)
                    {
                        //Örnek Program;
                        //Work:Girilen adet kadar isim girdirilmeli ve girilen isimler arasında arama yapılmalı.
                        //1-Step:Kullanıcının kaç tane isim gireceği bilgisini almak.
                        Console.WriteLine("Öğrenci Ekleme Sistemi ;");
                        //Console.Write("Kaçtane Öğrenci Eklenecek : ");
                        //int adet = Convert.ToInt32(Console.ReadLine());
                        //2-Step:Girilen adet boyutunda dizi tanımlanmalı.
                        //string[] isim = new string[adet];
                        //Console.WriteLine(adet + " İsim İçin Yer Ayrılmıştır.");

                        //3-Step:Belirtilen adet kadar kullanıcının isim girmesini sağlamak ve girilen isimleri sıra ile diziye atamak.
                        Console.Write("Kaçtane Öğrenci Eklenecek : ");
                        int adet = Convert.ToInt32(Console.ReadLine());
                        Array.Resize(ref ogrencis, adet);
                        Console.WriteLine(adet + " İsim İçin Yer Ayrılmıştır.");

                        for (int i = 0; i <= adet - 1; i++)
                        {
                            okulno++;
                            Console.Write("{0} Numaraya Eklenecek İsmi Giriniz : ", okulno);
                            string gisim = Console.ReadLine();
                            ogrencis[i] = gisim;
                            eklenen++;
                            Console.WriteLine(gisim);    
                        }
                        Console.Write("Öğrencileriniz Başarı İle Eklenmiştir.");
                        Console.ReadLine();
                        Console.ReadLine();
                        Console.Write(okulno);
                    }
                    else if (istek == 2)
                    {
                        foreach (string item in ogrencis)
                        {
                            if (item)
                        }
                    }
                    else
                    {
                        Console.Write("İyi Günler...");
                    }

                } while (eklenen <= 1000);

                

            }
            else
                {
                    Console.Write("Yanlış Şifre Veya Parola");
                }
            Console.ReadLine(); 
        }
    }
}
