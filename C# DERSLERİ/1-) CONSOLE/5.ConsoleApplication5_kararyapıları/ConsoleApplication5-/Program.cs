using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5_
{
    class Program
    {
        /* Karar Yapıları:
        1- If - Else: if(koşul)  
        {
        
        }
        else if(koşul)
        {
        
        } 
        else if(koşul)
        {
        
        }      
        else
        {
        
        }      
             && --> Konulduğu zaman önceki(soldaki) değer yanlış ise sonrakini hiç hesaba katmaz program durur.
             Write metodunun içine {index} açıldığı zaman içine index değeri yazarız.s
        
        2- SwitchCase:
         * switch(koşul)
         * {
         * case 1: şunu yap; break;
         * case 2: şunu yap; break,
         * }
         * -İf else yapısından daha yeteneksizdir.
        */
        static void Main(string[] args)
        {
            //Kullanıcı Giriş Alanı Oluşturma;
            string kullaniciAdi = "alphasoft";
            string parola = "147258369";
            Console.WriteLine("Real World Real Life'a Hoş Geldiniz !");
            Console.Write("Kullanıcı Adınız : ");
            string ka = Console.ReadLine();
            
            
                if (ka == kullaniciAdi)
            {
                Console.Beep(500, 2000);
                Console.Write("Parolanız : ");
                string pa = Console.ReadLine();
                if (pa == parola)
                {
                    Console.Beep(500, 2000);
                    Console.Write("Girişiniz Başarı İle Gerçekleşmiştir Hoşgeldin {0} KDASOFT İYİ OYUNLAR DİLER...", ka);
                    Console.WriteLine(" ");
                    //Girilen İki Sayıdan Hangisinin Büyük Hangisinin Küçük Olduğunu Gösteren Bir Uygulama ;
                    Console.WriteLine("HANGİ SAYI BÜYÜK UYGULAMASINA GİTMEK İÇİN 1 MEVSİMLER UYGULAMASINA GİTMEK İÇİN 2 YAZINIZ UYGULAMADAN ÇIKMAK İSTİYORSANIZ ENTER'A BASIN...");
                    Console.Write("Hangi Uygulamaya Gitmek İstiyorsunuz : ");
                    string secenek1 = Console.ReadLine();                   
                    if (secenek1 == "1")
                    {
                        Console.WriteLine("HANGİ SAYI BÜYÜK ?");
                        Console.Write("1.Sayı : ");
                        int s1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2.Sayı : ");
                        int s2 = Convert.ToInt32(Console.ReadLine());
                        if (s1 > s2)
                        {
                            Console.Write("{0} Sayısı {1} Sayısından Büyüktür..", s1, s2);
                        }
                        else if (s2 > s1)
                        {
                            Console.Write("{0} Sayısı {1} Sayısından Büyüktür..", s2, s1);
                        }
                        else if (s1 == s2)
                        {
                            Console.Write("{0} Sayısı Ve {1} Sayısı Eşittir..", s2, s1);
                        }
                    }
                    else if (secenek1 == "2")
                    {
                        //Kullanıcının girdiği mevsimde bulunan ayları listelemek;
                        Console.WriteLine("Hangi Mevsim Hangi Ayları Kaplar ?");
                        Console.Write("Mevsim Giriniz : ");
                        string mevsim = Console.ReadLine();
                        switch (mevsim)
                        {
                            case "Yaz": Console.Write("Haziran - Temmuz - Ağustos"); break;
                            case "Sonbahar": Console.Write("Eylül - Ekim - Kasım"); break;
                            case "Kış": Console.Write("Aralık - Ocak - Şubat"); break;
                            case "İlkbahar": Console.Write("Mart - Nisan - Mayıs"); break;
                            default: Console.Write(mevsim + " Bir Mevsim Değildir Lütfen Kontrol Ediniz."); break;
                        }
                    }
                }
                else
                {
                    Console.Beep(250, 2000);
                    Console.Write("Parolanız Hatalı Lütfen Kontrol Ediniz.");
                }

            }
                else
            {
                Console.Beep(250, 2000);
                Console.Write("Kullanıcı Adı Hatalı Lütfen Kontrol Ediniz.");
            }

            Console.ReadLine();

            Console.Clear();

            
        }
    }
}
