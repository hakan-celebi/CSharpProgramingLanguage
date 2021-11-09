using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DÖNGÜLER;
             * Döngüler bir program içindeki komut satırlarını birden fazla çalıştırmak için kullanılır. Bir koşula bağlı olarak
             * gerçekleşir. Döngüler While, Do While, For ve Foreach olarak dörde ayrılır.
             * 
             * 1-)While Döngüsü: İçerisine Bir koşul belirtiyoruz eğer bu koşul sağlanıyor ise parantezler içine giriyor ve o koşul
             * sağlanmayana kadar kodlar çalıştırılıyor.
             * KULLANIMI:
             * while (koşul)
             * {
             *  
             * }
             * 
             * 2-)Do While Döngüsü: İçerisinde bir koşul belirtiyoruz while da olduğu koşul sağlanıyor ise parantezler içine giriyor
             * ve o koşul sağlanmayana kadar kodları çalıştırıyor fakat while'dan farklı olarak koşul sağlansada sağlanmasada bir kez
             * çalıştırılıyor.
             * 
             * -->Random Referans Operatörü: Rastgele sayı üretilmesini sağlar ve şu şekilde tanımlanır;
             * Random sayi = new.Random();
             * 
             * 3-)For Döngüsü: Sayısal operatörler ile for döngüsü içerisinde bir değişken oluşturup eksiltip arttırıp bölüp çarpıp
             * her şekilde sayıyı katlayarak belirlenen koşula göre işlem yaptırır. Kullanımı şu şekildedir;
             * for(int i = 0; i < 100 i++ veya herhangi bir sayısal operatör)
             * {
             * 
             * }
             * 
             * Ara Konu Diziler: Diziler koleksiyon tipi bir elemandır ve diziler birden çok veriyi tek bir isim çatısı altında 
             * tutmaya yarar. İndex numaraları ile seçilip düzenlenir veya silinir.
             * 
             * 4-)Foreach Döngüsü: Dizi yapısına daha uygun bir döngü olduğu için çoğunlukla dizi işlemlerinde kullanılır. İki önemli
             * kuralı vardır.
             * a-)Sadece ileri doğru hareketi vardır.
             * b-)Readonly'dir sadece okur dizi koleksiyon yapısına birşey yazıp değiştiremez.
             * kullanımı;
             * foreach(değişkentipi item in diziismi)
             * {
             * 
             * }
             * 
             */

            string secim;
            Console.Write("Hangi Uygulamayı Açmak İstiyorsun : ");
            secim = Console.ReadLine();
            Console.WriteLine();
            if (secim == "1")
            {
                //0'DAN 100'E KADAR OLAN ÇİFT SAYILAR
                int a = 0;
                while (a <= 100)
                {
                    Console.WriteLine(a + " ");
                    a += 2;
                }

                Console.ReadLine();
            }
            else if (secim == "2")
            {
                //0'DAN 100'E KADAR OLAN ÇİFT SAYILARIN VE TEK SAYILARIN TOPLAMI
                int c = 2;
                int t = 1;
                int ttop = 0;
                int ctop = 0;
                Console.WriteLine("1'DEN 100'E KADAR OLAN TEK SAYILARIN TOPLAMI ; ");
                while (t <= 100)
                {
                    ttop += t;
                    if (t == 99)
                    {
                        Console.Write(t + " ");
                    }
                    else
                    {
                        Console.Write(t + " + ");
                    }
                    t += 2;
                }
                Console.Write("= " + ttop);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1'DEN 100'E KADAR OLAN ÇİFT SAYILARIN TOPLAMI ; ");
                while (c <= 100)
                {
                    ctop += c;
                    if (c == 100)
                    {
                        Console.Write(c + " ");
                    }
                    else
                    {
                        Console.Write(c + " + ");
                    }
                    c += 2;
                }
                Console.Write("= " + ctop);
                Console.ReadLine();
            }
            else if (secim == "3")
            {
                //SAYI TAHMİN OYUNU
                Random rnd = new Random();
                int tutulan = rnd.Next(0, 100);
                int sayac = 0;
                Console.WriteLine("SAYI TAHMİN OYUNUNA HOŞ GELDİNİZ...");
                git:
                Console.Write("Lütfen Tahminizi Giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi == tutulan)
                {
                    Console.WriteLine();
                    Console.WriteLine("TEBRİKLER TUTULAN SAYI {0}'DI ", tutulan);
                }
                else
                {
                    sayac++;
                    if (sayac <= 5)
                    {
                        Console.WriteLine("Tahmininiz Yanlış Tekrar Deneyin !");
                        goto git;
                    }
                    else
                    {
                        Console.WriteLine("TUTULAN SAYI {0}'DI KAYBETTİNİZ", tutulan);
                    }
                }
                Console.ReadLine();
            }
            else if (secim == "4")
            {
                //FAKTÖRİYEL HESAPLAMA UYGULAMASI
                Console.WriteLine("Faktöriyel Hesaplama Uygulamasına Hoşgelidniz...");
                gel:
                Console.Write("Faktöriyeli Hesaplanacak Sayıyı Giriniz (0'dan 30'a kadar): ");
                int sayi = int.Parse(Console.ReadLine());
                int faktor = 1;
                if (sayi == 0)
                {
                    Console.WriteLine("{0}! Faktöriyelinin Sonucu = {1}", sayi, ++sayi);
                }
                else if (sayi > 0 && sayi < 31)
                {
                    for (int i = sayi; i >= 1; i--)
                    {
                        faktor *= i;
                    }
                    Console.WriteLine();
                    Console.Write("{0}! Faktöriyelinin Sonucu = {1}", sayi, faktor);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Lütfen Belirtilen Aralıktaki Sayıları Girniz.");
                    goto gel;
                }

                Console.Write("İşlemi Tekrarlamak İstermisiniz (E/H): ");
                string istek = Console.ReadLine();
                if (istek == "e" | istek == "E")
                {
                    Console.WriteLine();
                    goto gel;
                }
                else if (istek == "h" | istek == "H")
                {
                    Console.WriteLine();
                    Console.WriteLine("BYE BYE...");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tercihiniz Algılanamadı Uygulama Kapatılıyor.");
                }
                Console.ReadLine();
            }
            else if (secim == "5")
            {
                //İSİM GİRME VE ARATMA UYGULAMASI
                Console.WriteLine("İSİM GİRME VE ARATMA UYGULAMASINA HOŞGELDİNİZ...");
                gel:
                Console.Write("Kaçtane İsim Girmek İstiyorsunuz: ");
                int diziboyut = int.Parse(Console.ReadLine());
                string[] isimdizi = new string[diziboyut];
                for (int i = 0; i < diziboyut; i++)
                {
                    Console.Write("{0}. İsmi Giriniz : ", i + 1);
                    isimdizi[i] = Console.ReadLine();
                }
                Console.WriteLine();
                Console.Write("Aratmak İstediğiniz İsmi Giriniz: ");
                string aranan = Console.ReadLine();
                int adet = 0;
                for (int i = 0; i < diziboyut; i++)
                {
                    if (isimdizi[i] == aranan)
                    {
                        adet++;
                    }
                }

                if (adet > 0)
                {
                    Console.WriteLine();
                    Console.Write("{0} İsminden Veri Tabanında {1} Tane Bulunmaktadır.", aranan, adet);
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("{0} İsminden Veri Tabanında Bulunmamaktadır.", aranan);
                }

                Console.WriteLine();
                Console.Write("İşlemi Tekrarlamak İstermisiniz (E/H): ");
                string istek = Console.ReadLine();
                if (istek == "e" | istek == "E")
                {
                    Console.WriteLine();
                    goto gel;
                }
                else if (istek == "h" | istek == "H")
                {
                    Console.WriteLine();
                    Console.WriteLine("BYE BYE...");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tercihiniz Algılanamadı Uygulama Kapatılıyor.");
                }
                Console.ReadLine();
            }
            else if (secim == "6")
            {
                //SAYISAL LOTO
                Console.WriteLine("T.C. İDDA VE ÇEKİLİŞ UYGULAMASINA HOŞGELDİNİZ... 1.000.000$");
                Console.Write("Hangi Loto Türünü Oynamak İstiyorsunuz (TAM=1, YARIM=2, ÇEYREK=3): ");
                int bilettürü = int.Parse(Console.ReadLine());
                if (bilettürü == 1)
                {
                    int[] lotodizi = new int[4];
                    int lotosayi1 = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Random lotosayi = new Random();
                        lotosayi1 = lotosayi.Next(10, 99);
                        lotodizi[i] = lotosayi1;
                    }
                    Console.WriteLine();
                    Console.Write("Biletiniz Hazırlanmıştır Lütfen Tahminlerinizi Giriniz.");
                    int tahmin = 1;
                    int girilen;
                    int bilinen = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine();
                        Console.Write("{0}. Tahmin: ", tahmin);
                        girilen = int.Parse(Console.ReadLine());
                        tahmin++;
                        if (girilen == lotodizi[i])
                        {
                            bilinen++;
                        }
                    }
                    if (bilinen == 3)
                    {
                        Console.WriteLine();
                        Console.Write("4/3 Yaptığınız İçin 1.000.000$'ın %25'ini Yani 250.000$ Kazandınız Tebrikler...");
                    }
                    else if (bilinen == 4)
                    {
                        Console.WriteLine();
                        Console.Write("4/4 Yaptığınız İçin 1.000.000$ Kazandınız Tebrikler...");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Üzgünüz Kazanamadınız...");
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine();
                        Console.Write("BİLET NUMARALARI ŞU ŞEKİLDEDİR: ");
                        Console.Write(lotodizi[i] + " ");
                    }
                    Console.ReadLine();
                }
            }
            else if (secim == "7")
            {
                //TAKIM OLUŞTURMA
                Console.WriteLine("Takım Oluşturma Uygulamasına Hoşgeldiniz Takımlar Eşit Sayıda Oluşturulacaktır...");
                gel:
                Console.Write("Kaç Kişisiniz: ");
                int kisisayisi = int.Parse(Console.ReadLine());
                if (kisisayisi % 2 == 0)
                {
                    string[] kisiler = new string[kisisayisi];
                    for (int i = 0; i < kisisayisi; i++)
                    {
                        Console.Write("{0}. Kişiyi Giriniz: ", i + 1);
                        kisiler[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    int takimsayisi = kisisayisi / 2;
                    int rastgele = 0;
                    bool kontrol = true;
                    string[] atakimi = new string[takimsayisi];
                    string[] btakimi = new string[takimsayisi];
                    for (int i = 0; i < takimsayisi; i++)
                    {
                        Random rnd = new Random();
                        rastgele = rnd.Next(0, kisisayisi);
                        foreach (string item in atakimi)
                        {
                            if (item == kisiler[rastgele])
                            {
                                kontrol = false;
                                break;
                            }
                            else
                            {
                                kontrol = true;
                            }
                        }
                        if (kontrol == true)
                        {
                            atakimi[i] = kisiler[rastgele];
                        }
                        else
                        {
                            i--;
                        }
                    }
                    Console.Write("A TAKIMI: ");
                    foreach (string item in atakimi)
                    {
                        Console.Write(item + ", ");
                    }
                    Console.WriteLine();
                    bool kontrol2 = true;
                    int i2 = 0;
                    for (int i = 0; i < kisisayisi; i++)
                    {
                        foreach (string item in atakimi)
                        {
                            if (kisiler[i] == item)
                            {
                                kontrol2 = false;
                                break;
                            }
                            else
                            {
                                kontrol2 = true;
                            }
                        }
                        if (kontrol2 == true)
                        {
                            btakimi[i2] = kisiler[i];
                            i2++;
                        }
                    }
                    Console.Write("B TAKIMI: ");
                    foreach (string item in btakimi)
                    {
                        Console.Write(item + ", ");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Lütfen Çift Sayı Giriniz...");
                    Console.WriteLine();
                    goto gel;
                }

                Console.ReadLine();
            }
            else if (secim == "8")
            {
                //SESLİ HARF BULMA UYGULAMASI
                Console.WriteLine("Sesli Harf Bulma Uygulamasına Hoşgeldiniz...");
                gel:
                Console.Write("Lütfen Bir Metinsel İfade Giriniz: ");
                int seslisayisi = 0;
                int sessizsayisi = 0;
                int bosluksayisi = 0;
                string girilen = Console.ReadLine();
                foreach (char item in girilen)
                {
                    if (item == 'a' | item == 'e' | item == 'ı' | item == 'i' | item == 'o' | item == 'ö' | item == 'u' | item == 'ü' | item == 'A' | item == 'E' | item == 'I' | item == 'İ' | item == 'O' | item == 'Ö' | item == 'U' | item == 'Ü')
                    {
                        seslisayisi++;
                    }

                    if (item == ' ')
                    {
                        bosluksayisi++;
                    }
                }
                sessizsayisi = girilen.Length - seslisayisi;
                sessizsayisi -= bosluksayisi;
                Console.WriteLine();
                Console.Write("Girilen Metinsel İfadede {0} Adet Sesli Harf {1} Adet Sessiz Harf Toplamda {2} Adet Harf Bulunmaktadır.", seslisayisi, sessizsayisi, seslisayisi + sessizsayisi);
                Console.ReadLine();
                goto gel;
            }
            else if (secim == "9")
            {
                //RASTGELE SAYILAR KÜMESİ
                Console.WriteLine("Sayılar Kümesi Oluşturma Uygulaması...");
                Console.Write("Kaç Adet Rastgele Sayı Oluşturmak İstiyorsunuz: ");
                int diziboyut = int.Parse(Console.ReadLine());
                int[] dizi = new int[diziboyut];
                Random rnd = new Random();
                int rastgelesayi;
                int sayac = 0;
                for (int i = 0; i < diziboyut; i++)
                {
                    rastgelesayi = rnd.Next(0, diziboyut + 10);
                    if (rastgelesayi == 0)
                    {
                        i++;
                    }
                    if (!dizi.Contains(rastgelesayi))
                    {
                        dizi[i] = rastgelesayi;
                    }
                    else
                    {
                        sayac++;
                        i--;
                    }
                }
                Console.WriteLine();
                Console.Write("Diziniz Oluşturulmuştur: ");
                foreach (int item in dizi)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                Console.Write("Aynı Sayı {0} Defa Oluşturulmuştur.", sayac);
                Console.ReadLine();
            }
            else if (secim == "10")
            {
                //ÇARPIM TABLOSU OLUŞTURMA
                int carpimsonuc = 0;
                int sayac = 0;
                for (int i = 1; i <= 10; i++)
                {
                    for (int t = 1; t <= 10; t++)
                    {
                        carpimsonuc = i * t;
                        Console.Write("{0}x", i);
                        Console.Write("{0} = {1}    ", t, carpimsonuc);
                        sayac++;
                        if (sayac % 5 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.ReadLine();
            }
            else if (secim == "11")
            {
                //2'DEN 100'E KADAR OLAN ASAL SAYILAR
                bool kontrol = true;
                for (int i = 2; i <= 100; i++)
                {
                    for (int t = 2; t < i; t++)
                    {
                        if (i % t != 0)
                        {
                            kontrol = true;
                        }
                        else
                        {
                            kontrol = false;
                            break;
                        }
                    }
                    if (kontrol == true)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
