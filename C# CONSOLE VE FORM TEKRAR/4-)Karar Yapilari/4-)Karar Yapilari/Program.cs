using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4__Karar_Yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Karar Yapıları: Bu yapılar program içerisindeki koşulları kontrol etmek için kullanılır if-else ve switch case olarak
             * ikiye ayrılır. Geriye boolean tipi yani true veya false döndürür eğer true ise koşul onaylanır ve parantezler içine
             * girilir.
             * 
             * 1-)İf-Else:İf Eğer anlamına gelir else değil anlamına gelir kullanımı şu şekildedir.
             * if (koşul örneğin a == 0 yani a sıfıra eşitmi koşulu)
             * {
             * 
             * }
             * 
             * else if (koşul örneğin a > 0 yani a 0'dan büyükmü) --> değilse eğer bu koşulu sağlıyormu anlamına gelir.
             * {
             * 
             * }
             * 
             * else --> Değilse anlamı içerir yani bu karar yapılarından hiçbiri sağlamıyor ise bu parantezler içini çalıştır.
             * {
             * 
             * }
             * 
             * 2-)Switch Case:İf-Else'de olduğu gibi bir koşul koyulur ve kontrol edilir performansı if-else'ye göre daha performans
             * lıdır fakat daha yeteneksizdir.
             * 
             * switch (koşul örneğin a)
             * case 1: a 1'e eşit ise kullan break; break kır anlamına gelir ve bu komut satırını durdurur.
             * case 2: a 2'ye eşit ise bu kodlar kullanılır break;
             * 
             */

            string yonlendirme;
            Console.Write("Hangi Uygulamaya Gitmek İstiyorsun : ");
            yonlendirme = Console.ReadLine();
            Console.WriteLine();
            if (yonlendirme == "1")
            {
                //Kullanıcı Adı Ve Şifre Kontrolü
                string kullaniciadi = "ActualKilled";
                string sifre = "365412";
                string girilenka, girilensif;
                string kullanicidegistir;
                int sayac = 0;
                Console.WriteLine("A'DAN Z'YE MARKET ADMİN PANELİ");
                Console.WriteLine("UYARI! : Büyük Küçük Harf Duyarlıdır.");
                Console.WriteLine();
            geridon:
                Console.Write("Kullanıcı Adı: ");
                girilenka = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Şifre: ");
                girilensif = Console.ReadLine();
                Console.WriteLine();

                if (kullaniciadi == girilenka & sifre == girilensif & sayac < 4)
                {
                    Console.WriteLine("Giriş Onaylandı...");
                    Console.WriteLine("Hoşgeldin " + girilenka);
                    Console.Write("KULLANICI DEĞİŞTİRMEK İSTİYORMUSUNUZ (E/H) : ");
                    kullanicidegistir = Console.ReadLine();
                    if (kullanicidegistir == "e" | kullanicidegistir == "E")
                    {
                        goto geridon;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(girilenka + " Olarak Devam Ediceksiniz");
                    }
                }
                else
                {
                    sayac++;
                    if (sayac < 3)
                    {
                        Console.WriteLine("Kullanıcı Adı Veya Şifre Yanlış Lütfen Tekrar Deneyiniz.");
                        Console.WriteLine();
                        goto geridon;
                    }
                    else
                    {
                        Console.WriteLine("3 Defadan Fazla Deneme Yaptığınız İçin Güvenlik Sebebi İle Program Kitlenmiştir.");
                    }
                }

                Console.ReadLine();
            }
            else if (yonlendirme == "2")
            {
                //Sıralama Programı
                int a, b, c;
                Console.WriteLine("Büyükmü Yoksa Küçükmü Uygulamasına Hoşgeldiniz...");
            gelgel:
                Console.WriteLine();
                Console.Write("1. SAYIYI GİRİNİZ : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("2. SAYIYI GİRİNİZ : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("3. SAYIYI GİRİNİZ : ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int sayac;
                if (a > b && b != c && a != c)
                {
                    if (a > c)
                    {
                        if (b > c)
                        {
                            Console.WriteLine("{0}>{1}>{2}", a, b, c);
                        }
                        else
                        {
                            Console.WriteLine("{0}>{1}>{2}", a, c, b);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}>{1}>{2}", c, a, b);
                    }

                }
                else if (a == b && a == c && b == c)
                {
                    Console.WriteLine("{0}={1}={2}", c, a, b);
                }
                else if (a == b && c != b)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0}={1}>{2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("{0}>{1}={2}", c, a, b);
                    }
                }
                else if (a == c && c != b)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0}>{1}={2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("{0}={1}>{2}", c, a, b);
                    }
                }
                else if (b == c && a != b)
                {
                    if (a > b)
                    {
                        Console.WriteLine("{0}>{1}={2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("{0}={1}>{2}", c, b, a);
                    }
                }
                else if (a != b && a != c && b != c)
                {
                    if (b > c)
                    {
                        if (c > a)
                        {
                            Console.WriteLine("{0}>{1}>{2}", b, c, a);
                        }
                        else
                        {
                            Console.WriteLine("{0}>{1}>{2}", b, a, c);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}>{1}>{2}", c, b, a);
                    }

                }
                Console.ReadLine();
                goto gelgel;
            }
            else if (yonlendirme == "3")
            {
                //Bu Mevsim Hangi Aylarda Yaşanıyor
                string mevsim;
                Console.WriteLine("HANGİ MEVSİM HANGİ AY UYGULAMASINA HOŞGELDİNİZ");
            bas:
                Console.Write("Bir Mevsim Giriniz : ");
                mevsim = Console.ReadLine();
                Console.WriteLine();

                switch (mevsim)
                {
                    case "yaz":
                        Console.WriteLine(mevsim + " Mevsiminin Ayları Haziran, Temmuz Ve Ağustos'tur.");
                        break;
                    case "kış":
                        Console.WriteLine(mevsim + " Mevsiminin Ayları Aralık, Ocak Ve Şubat'tır.");
                        break;
                    case "ilkbahar":
                        Console.WriteLine(mevsim + " Mevsiminin Ayları Mart, Nisan Ve Mayıs'tır.");
                        break;
                    case "sonbahar":
                        Console.WriteLine(mevsim + " Mevsiminin Ayları Eylül, Ekim Ve Kasım'dır.");
                        break;
                    default:
                        Console.WriteLine("Geçerli Bir Mevsim Giriniz");
                        goto bas;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
