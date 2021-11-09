using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14_sesliharfuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int sınır = 0;
            Console.WriteLine("SESLİ HARF UYGULAMASINA HOŞGELDİNİZ...");
            do
            {
                Console.Write("Bir Metin Giriniz : ");
                string girk = Console.ReadLine();
                char[] sesliharfler = { 'A', 'E', 'İ', 'Ö', 'O', 'U', 'Ü', 'I', 'a', 'e', 'i', 'o', 'ö', 'u', 'ü', 'ı' };
                int sayac1 = 0;
                int sayac2 = 0;
                foreach (char harf in girk)
                {
                    if (sesliharfler.Contains(harf))
                    {
                        sayac1++;
                    }
                    else
                    {
                        sayac2++;
                    }
                }
                Console.WriteLine();
                Console.Write("Bu Metinde {0} Tane Sesli Harf Ve ", sayac1);
                Console.Write("{0} Tane Sessiz Harf Vardır...", sayac2);
                Console.ReadLine();
            } while (sınır == 0);
            Console.ReadLine();
        }
    }
}
