using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7_örnekprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int etkin = 2;
            int etkin2 = 2;
            string urun1 = "Mont";
            string urun2 = "Kask";
            string urun3 = "Eldiven";
            string urun1kod = "M01";
            string urun2kod = "K02";
            string urun3kod = "E03";
            int urun1fiyat = 100;
            int urun2fiyat = 200;
            int urun3fiyat = 300;
            int urun1stok = 5;
            int urun2stok = 8;
            int urun3stok = 11;
            while (etkin >= 2)
            {
                Console.WriteLine();
                Console.Write("ÜRÜN KODU GİRİNİZ :");
                string girilenkod = Console.ReadLine();
                if (girilenkod == urun1kod)
                {
                    Console.WriteLine(urun1);
                    Console.WriteLine("Fiyat :" + urun1fiyat + "TL");
                    Console.WriteLine("Şu anda stokta " + urun1stok + " adet ürün bulunmaktadır.");
                    Console.WriteLine();
                    Console.Write("ÜRÜN BİLGİLERİNE TEKRAR BAKMAK İSTERMİSİNİZ :");
                    string ea = Console.ReadLine();
                    if (ea == "Evet")
                    {
                        etkin++;
                    }
                    else if (ea == "Hayır")
                    {
                        etkin-= 10;
                    }
                    else
                    {
                        etkin -= 10;
                    }

                }
                else if (girilenkod == urun2kod)
                {
                    Console.WriteLine(urun2);
                    Console.WriteLine("Fiyat :" + urun2fiyat + "TL");
                    Console.WriteLine("Şu anda stokta " + urun2stok + " adet ürün bulunmaktadır.");
                    Console.WriteLine();
                    Console.Write("ÜRÜN BİLGİLERİNE TEKRAR BAKMAK İSTERMİSİNİZ :");
                    string ea = Console.ReadLine();
                    if (ea == "Evet")
                    {
                        etkin++;
                    }
                    else if (ea == "Hayır")
                    {
                        etkin -= 10000;
                    }
                    else
                    {
                        etkin -= 10000;
                    }
                }
                else if (girilenkod == urun3kod)
                {
                    Console.WriteLine(urun3);
                    Console.WriteLine("Fiyat :" + urun3fiyat + "TL");
                    Console.WriteLine("Şu anda stokta " + urun3stok + " adet ürün bulunmaktadır.");
                    Console.WriteLine();
                    Console.Write("ÜRÜN BİLGİLERİNE TEKRAR BAKMAK İSTERMİSİNİZ :");
                    string ea = Console.ReadLine();
                    if (ea == "Evet")
                    {
                        etkin++;
                    }
                    else if (ea == "Hayır")
                    {
                        etkin -= 10000;
                    }
                    else
                    {
                        etkin -= 10000;
                    }
                }
                else
                {
                    Console.Write("Girilen Ürün Koduna Ait Ürün Bulunamadı Tekrar Denemek İstiyormusunuz :");
                    string ea = Console.ReadLine();
                    if (ea == "Evet")
                    {
                        etkin++;
                    }
                    else if (ea == "Hayır")
                    {
                        etkin -= 10000;
                    }
                    else
                    {
                        etkin -= 10000;
                    }
                }
            }

            Console.WriteLine();
            while (etkin2 >= 2)
            {
                Console.Write("Almak istediğiniz Ürün Kodu :");
                string istenenkod = Console.ReadLine();

                if (istenenkod == urun1kod)
                {
                    Console.Write(urun1 + " Ürününden Kaç Adet Almak İstiyorsunuz : ");
                    int istenenadet = 0;
                    string istenea = Console.ReadLine();
                    istenenadet = int.Parse(istenea);
                    if (istenenadet <= urun1stok)
                    {
                        Console.Write(istenenadet + " Adet Ürün Toplam " + urun1fiyat * istenenadet + "TL");
                        Console.WriteLine();
                        Console.Write("Almak İstiyormusunuz : ");
                        string ea2 = Console.ReadLine();

                        if (ea2 == "Evet")
                        {
                            Console.Write(urun1 + " Ürününden " + istenenadet + " Tane Alınmıştır.");
                            Console.WriteLine();
                            Console.Write("Toplam Tutar = " + urun1fiyat * istenenadet + "TL");
                            urun1stok -= istenenadet;
                            etkin2 -= 10;
                            Console.WriteLine();
                            Console.Write("Alışverişinize Devam Etmek İstiyormusunuz : ");
                            string ea3 = Console.ReadLine();
                            if (ea3 == "Evet")
                            {
                                etkin2+=10;
                            }
                            else if (ea3 == "Hayır")
                            {
                                etkin2 -= 10;
                            }
                            else
                            {
                                etkin2 -= 10;
                            }
                        }

                        else if (ea2 == "Hayır")
                        {
                            Console.Write("Teşekkürler İyi Günler Dileriz.");
                            etkin2 -= 10;
                        }
                    }
                    else
                    {
                        Console.Write("Üzgünüz " + istenenadet + " Adet Ürün Stoğumuzda Bulunmamaktadır.");
                        Console.WriteLine();
                        Console.Write(urun1 + " Ürünü Stoklarımızda " + urun1stok + " Adet Bulunmaktadır.");
                        Console.WriteLine();
                        Console.Write("Tekrar Denemek İstermisiniz : ");
                        string ea2 = Console.ReadLine();
                        if (ea2 == "Evet")
                        {
                            etkin2++;
                        }
                        else if (ea2 == "Hayır")
                        {
                            etkin2 -= 10;
                        }
                        else
                        {
                            etkin2 -= 10;
                        }
                    }
                }
                

                else if (istenenkod == urun2kod)
                {
                    Console.Write(urun2 + " Ürününden Kaç Adet Almak İstiyorsunuz : ");
                    string istenea = Console.ReadLine();
                    int istenenadet = int.Parse(istenea);
                    if (istenenadet <= urun2stok)
                    {
                        Console.Write(istenenadet + " Adet Ürün Toplam " + urun2fiyat * istenenadet + "TL");
                        Console.WriteLine();
                        Console.Write("Almak İstiyormusunuz : ");
                        string ea2 = Console.ReadLine();
                        if (ea2 == "Evet")
                        {
                            Console.Write(urun2 + " Ürününden " + istenenadet + " Tane Alınmıştır.");
                            Console.WriteLine();
                            Console.Write("Toplam Tutar = " + urun2fiyat * istenenadet + "TL");
                            urun2stok -= istenenadet;
                            etkin2 -= 10;
                            Console.WriteLine();
                            Console.Write("Alışverişinize Devam Etmek İstiyormusunuz : ");
                            string ea3 = Console.ReadLine();
                            if (ea3 == "Evet")
                            {
                                etkin2 += 10;
                            }
                            else if (ea3 == "Hayır")
                            {
                                etkin2 -= 10;
                            }
                            else
                            {
                                etkin2 -= 10;
                            }

                        }
                        else if (ea2 == "Hayır")
                        {
                            Console.Write("Teşekkürler İyi Günler Dileriz.");
                            etkin2 -= 10;
                        }
                    }
                    else
                    {
                        Console.Write("Üzgünüz " + istenenadet + " Adet Ürün Stoğumuzda Bulunmamaktadır.");
                        Console.WriteLine();
                        Console.Write(urun2 + " Ürünü Stoklarımızda " + urun2stok + " Adet Bulunmaktadır.");
                        Console.WriteLine();
                        Console.Write("Tekrar Denemek İstermisiniz : ");
                        string ea2 = Console.ReadLine();
                        if (ea2 == "Evet")
                        {
                            etkin2++;
                        }
                        else if (ea2 == "Hayır")
                        {
                            etkin2 -= 10;
                        }
                        else
                        {
                            etkin2 -= 10;
                        }
                    }
                }
                else if (istenenkod == urun3kod)
                {
                    Console.Write(urun3 + " Ürününden Kaç Adet Almak İstiyorsunuz : ");
                    string istenea = Console.ReadLine();
                    int istenenadet = int.Parse(istenea);
                    if (istenenadet <= urun3stok)
                    {
                        Console.Write(istenenadet + " Adet Ürün Toplam " + urun3fiyat * istenenadet + "TL");
                        Console.WriteLine();
                        Console.Write("Almak İstiyormusunuz : ");
                        string ea2 = Console.ReadLine();
                        if (ea2 == "Evet")
                        {
                            Console.Write(urun3 + " Ürününden " + istenenadet + " Tane Alınmıştır.");
                            Console.WriteLine();
                            Console.Write("Toplam Tutar = " + urun3fiyat * istenenadet + "TL");
                            urun3stok -= istenenadet;
                            etkin2 -= 10;
                            Console.WriteLine();
                            Console.Write("Alışverişinize Devam Etmek İstiyormusunuz : ");
                            string ea3 = Console.ReadLine();
                            if (ea3 == "Evet")
                            {
                                etkin2 += 10;
                            }
                            else if (ea3 == "Hayır")
                            {
                                etkin2 -= 10;
                            }
                            else
                            {
                                etkin2 -= 10;
                            }
                        }
                        else if (ea2 == "Hayır")
                        {
                            Console.Write("Teşekkürler İyi Günler Dileriz.");
                        }
                    }
                    else
                    {
                        Console.Write("Üzgünüz " + istenenadet + " Adet Ürün Stoğumuzda Bulunmamaktadır.");
                        Console.WriteLine();
                        Console.Write(urun3 + " Ürünü Stoklarımızda " + urun3stok + " Adet Bulunmaktadır.");
                        Console.WriteLine();
                        Console.Write("Tekrar Denemek İstermisiniz : ");
                        string ea2 = Console.ReadLine();
                        if (ea2 == "Evet")
                        {
                            etkin2++;
                        }
                        else if (ea2 == "Hayır")
                        {
                            etkin2 -= 10;
                        }
                        else
                        {
                            etkin2 -= 10;
                        }
                    }
                }
                if (istenenkod != urun1kod && istenenkod != urun2kod && istenenkod != urun3kod)
                {
                    Console.Write("ÜZGÜNÜZ " + istenenkod + " ÜRÜN KODU SİSTEMİMİZDE BULUNMAMAKTADIR.");
                    Console.WriteLine();
                    Console.Write("Tekrar Denemek İstiyormusunuz : ");
                    string ea2 = Console.ReadLine();
                    if (ea2 == "Evet")
                    {
                        etkin2++;
                    }
                    else if (ea2 == "Hayır")
                    {
                        etkin2 -= 10;
                    }
                    else
                    {
                        etkin2 -= 10;
                    }
                }
                Console.WriteLine();
                Console.Write("Eğer Stoklarımıza Bakmak İstiyorsanız Stok Yazmanız Yeterlidir İstemiyorsanız Enter Tuşu İle Geçiniz : ");
                string stoktus = Console.ReadLine();
                if (stoktus == "Stok")
                {
                    Console.WriteLine(urun1 + " Ürününden " + urun1stok + " Adet ");
                    Console.WriteLine(urun2 + " Ürününden " + urun2stok + " Adet ");
                    Console.WriteLine(urun3 + " Ürününden " + urun3stok + " Adet ");
                    Console.WriteLine("Ürün Kalmıştır.");
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
