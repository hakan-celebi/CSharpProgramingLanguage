 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13_foreachdongusu
{
    class Program
    {
        /*4-Foreach Döngüsü:2 önemli kuralı vardır.
         * -Sadece İleri Gider.
         * -ReadOnly'dir.(Sadece okunabilir koleksiyon içindeki elemana değer ataması yapılmaz)
         * -Koleksiyon yapısı foreach'in çalışması sırasında değiştirilemez.
         * Yazımı;
         * foreach (elemantipi değişkenismi in koleksiyon) 
         * {
         * 
         * }
         * -Döngüler arasında en çok kullanılan döngü yapısıdır.
         * Not:Contains metodu dizinin içindeki değerlere bakmamızı sağlar örnek : dizi.Contains şeklinde kullanılır.
         */
        static void Main(string[] args)
        {
            
            char[] karakterler = { 'H', 'a', 'k','a', 'n', '5', '8' };
            foreach (char item in karakterler)
            {
                Console.WriteLine(item);
            }
            Console.Clear();
            //Takım Oyunu Yapma;
            //1-Step:Kullanıcıya kaç isim girileceğini sormak ve girilen adet boyutunda dizi oluşturma.
            Console.WriteLine("TAKIM OLUŞTURMA SİMİLATÖRÜNE HOŞGELDİNİZ...");
            long s = 10;
            int blok = 1;
            do
            {
                Console.Write("Kaç Tane Oyuncu Girmek İstiyorsunuz : ");
                int adet = Convert.ToInt32(Console.ReadLine());
                if (adet % 2 == 0)
                {
                    string[] dizi = new string[adet];
                    Console.Write("{0} Adetlik Alan Başarı İle Oluşturulmuştur",adet);
                    Console.ReadLine();

                    for (int i = 0; i < adet; i++)
                    {
                        Console.Write("{0}.Oyuncuyu Giriniz : ", i + 1);
                        string girilen = Console.ReadLine();
                        if (dizi.Contains(girilen) == true)
                        {
                            Console.WriteLine("{0} Oyuncusundan Zaten Bulunmaktadır Tekrar Deneyiniz",girilen);
                            i--;
                        }
                        else
                        {
                            dizi[i] = girilen;
                        }
                        
                    }
                    Console.WriteLine("Oyuncularınız Başarı İle Alınmıştır...");
                    string[] vampirler = new string[adet / 2];
                    string[] büyücüler = new string[adet / 2];
                    Random rnd = new Random();
                    for (int i = 0; i < adet / 2; i++)
                    {
                        string girilen = dizi[rnd.Next(0, adet)];
                        if (vampirler.Contains(girilen) == true)
                        {
                            i--;
                        }
                        else
                        {
                            vampirler[i] = girilen;
                        }
                    }
                    for (int i = 0; i < adet / 2; i++)
                    {
                        string girilen = dizi[rnd.Next(0, adet)];
                        if (vampirler.Contains(girilen) == false && büyücüler.Contains(girilen) == false)
                        {
                            büyücüler[i] = girilen;
                        }
                        else
                        {
                            i--;
                        }
                    }
                    Console.WriteLine("VAMPİRLER TAKIMI ! ;");
                    foreach (string v in vampirler)
                    {                       
                        Console.WriteLine(v);
                    }
                    Console.WriteLine("BÜYÜCÜLER TAKIMI ! ;");
                    foreach (string b in büyücüler)
                    {                        
                        Console.WriteLine(b);
                    }
                }
                else
                {
                    Console.Write("Sadece Çift Sayılık Alan Oluşturabilirsiniz Tekrar Deneyiniz...");
                    Console.ReadLine();
                    s--;
                    if (s == 0 && blok == 1)
                    {
                        Console.WriteLine("10 Kez Yanlış Değer Girdiğiniz İçin Hesabınız 10 Dk Bloke Edilmiştir 10 Dk Sonra Tekrar Deneyiniz...");
                        s = -5000000000;
                        do
                        {
                            s++;
                        } while (s < 10);
                        blok++;
                    }
                    else if (s == 0 && blok == 2)
                    {
                        Console.WriteLine("2.Defa 10 Kez Yanlış Değer Girdiğiniz İçin Hesabınız 60 Dk Bloke Edilmiştir 60 Dk Sonra Tekrar Deneyiniz...");
                        s = -10000000000;
                        do
                        {
                            s++;
                        } while (s < 10);
                        blok++;
                    }
                    else if (s == 0 && blok == 3)
                    {
                        Console.WriteLine("3.Defa 10 Kez Yanlış Değer Girdiğiniz İçin Hesabınız Süresiz Bloke Edilmiştir Eğer Yanlışlık Olduğunu Düşünüyorsanız KDASOFT Müşteri Hizmetleri ile İrtibata Geçiniz Teşekkürler...");
                        s = -10000000000;
                        do
                        {
                            s--;
                        } while (s < 10);
                        blok++;
                    }
                }
                
            } while (s > 0);            
        }
    }
}
