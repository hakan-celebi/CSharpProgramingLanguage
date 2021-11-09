using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#region Diziler ve Koleksiyonlar Tanım ve Farklılıkları
/*
Diziler ve Koleksiyonlar
    Diziler ve koleksiyonlar programlama içerisindeki verileri gruplayarak tutmak için kullanılır. Aynı zamanda bu yapılar programlama için kilit öneme sahiptir. Örneğin diziler
ile birlikte martris sistemleri oluşturabilir ve bunlar üzerinde istenilen işlemler gerçekleştirilebilir. Diziler ve koleksiyonlar yapısal olarak benzesede aralarında farklılıklar
vardır. Bu farklılıklar aşağıda madde madde verilmiştir.
    # Diziler sadece aynı veri tiplerinden verileri tutabilirken, koleksiyonlar ise aynı veri tiplerini tutabileceği gibi farklı veri tiplerini de tutabilmektedir.
    # Dizilerin boyutları static'dir. Yani dizilerin boyutu baştan verilmeli veya tanımlama anında veri kümesi verilerek boyutları belirlenmelidir. Fakat koleskiynolar dynamic
    yapıdadır. İçerisine belirli methodlar veya operatörler yardımıyla veri eklendikçe genişleyebilmektedir. Dizilerde ise Array.Resize metodu ile sonradan genişletme manuel olarak
    programcı tarafından yapılmalıdır.
    # Diziler, System.Array sınıfı üzerinde yer alırken, koleksiyonlar ise System.Collections sınıfı üzerinde yer alırlar.
    # Dizilerin boyutları sabit olarak belirlendiği ve aynı veri tiplerinden veri tuttukları için, koleksiyonlar boyutları dinamik oldukları aynı zamanda farklı veri tiplerini
    tutabilmek için boxing/unboxing işlemi yaptıkları için, diziler koleksiyonlardan daha performanslıdır.
*/
#endregion

#region Diziler - Arrays
/*
    Söylendiği üzere diziler System.Array sınıfı altında bulunurlar. Diziler aynı türden verileri sıralayarak yani index numaralarıyla tutar. Aslen diziler de bir koleksiyondur.
Fakat diziler aynı türden verileri sabit boyut ile tutukları için koleksiyonlardan ayrılırlar. Diziler hem referans türündeki verileri hem de değer tipindeki verileri tutabilirler.
Diziler aslında bellek adresi tutarlar ve bu bellek adreslerine sıra ile erişerek diziler sayesinde ayrılmış bellek alanları üzerinde gezinirler. Örneğin dört aden int veri
tutan bir dizi oluşturduğumuzu ele alalım. Bu örneği ise main metodu içerisinde "Array Address Sample" region alanı içerisinde tutalım. Bu örnekte dizi içerisine 4 adet rastgele
değer attık. int bellek de 32 bit yani 4 byte veri kaplar. Ram bellekler de adresleme ise bir'er byte olarak yapılır. C# da veriler ram de tutlurken sabit olarak tutulmaz.
Değişkenler sürekli harektelidir ve bu yüzden adreslerine direkt olarak erişim sağlayamayız. Fakat unsafe anahtar kelimesi ile bir metod belirleyip aynı zamanda programlamada
unsafe kullanılabilir özelliğini açarak pointer kullanıp sabit adresler üzerinde de işlem yapabilmekteyiz. Yani sonuç olarak değişkenler sürekli olarak hareket etse de bir model
üzerinde ram bellek de tutulurlar. Dizilerde de tutulma mantığı şu şekildedir. Örneğin bizim örneğimizde dizi tanımlama anında 4 byte ram üzerinde bellek ayırdık. Adresler
bilindiği üzere ram'in stack kısmında bulunur. Dizi de int tipinde olduğundan değer tipidir ve bu değerler de stack kısmında yer almaktadır. Yani bellek adreslerinin her int için
0FX1100 - 0FX1103, 0FX1104 - 0FX1107, 0FX1108 - 0FX110B, 0FX110C - 0FX110F şeklinde olduğunu biliyoruz. Burada 'array' başlangıç adresini tutarken aynı zamanda array[0] değer
tutsa da adresine erişim sağlayabilseydik bu da başlangıç adresi olan 0FX1100 adresini tutacaktı. Dizinin int tipinde olduğu için arttırma yapacağımızda 4 byte birden artacağı için
array++ işlemi ile array[1] in adresine denk getirebilirdik.
    Sonuç olarak dizilerin çalışma mantığı bu şekildedir. Diziler Tek Boyutlu Diziler ve Çok Boyutlu Diziler olmak üzere ikiyi ayrılırlar. Bu Çok Boyutlu Diziler de kendi içinde
Dikdörtgensel Diziler(Rectangular Arrays) benim değişimle Düzenli Diziler ve Düzensiz Diziler(Jagged Arrays) olmak üzere ikiye ayrılır. Diziler tanımlanırken de aynı değişken türü
gibi tanımlanırlar. Bu yüzden tanımlanmak istenen dizi belirlenmelidir. Örneğin tek boyutlu dizi için int[] veri tipi kullanılırken çok boyutlu düzenli bir dizi için ise
int[, , ...] biçiminde tanımlanır. Artık bu değişken de belirtilen tipde olmaktadır.
*/

#region Tek Boyutlu Diziler - Single Dimensional Arrays
/*
#TEK BOYUTLU DİZİLER
    Söylediğimiz gibi tek boyutlu diziler, dizinin içerisinde belirtilen kadar değer tutan dizilerdir. Tanımlanırken type[] arrayName; biçiminde tanımlanırlar. Fakat
söylediğimiz gibi arrayName direkt olarak adres tutmaktadır. Yani bir dizi tanımladık fakat boyut ayırma veya ram de alan ayırma yapmadık. Dolayısıyla eğer int[] tipinde
başka bir diziye eşitlersek o diziye referans olarak eşit olur ve arrayName üzerinde yapılan tüm değişikliklerde ana dizi üzerinde de etkili olur. Boyut ayırmanın iki
yolu vardır. İlk yol var değişkeninin tipinin verilen değere göre belirlendiği gibi dizinin de boyutunun atanan değer kümesi ile eşit olmasıdır. Yani {} parantezler
içerisinde , ile değerler atanır. int[] arrayName = {1, 8, 77, 92}; biçiminde tanımlama anında değer kümesi belirttik ve dizi dört elemanlı olarak belirlendi. Fakat
dikkat edilmesi gereken bunun tanımlama anında yapılmasıdır. Tanımlandıktan sonra boyut bu şekilde ayrılamaz. Diğer yöntem de her zaman her şekilde yapılabilen new
operatörü ile değer atanmasıdır. Bunda da dikkat edilmesi gereken, eğer diziye boyut ayırdıktan sonra değer ataması yaptıysak ve daha sonra tekrar new operatörü ile
boyut ayırması yaparsak eski boyut ve veriler silinir ve tekrar yeni bir alan ayrılır. Bu yüzden değerler kaybolur.
*/
#endregion

#region Çok Boyutlu Diziler - Multi Dimensional Arrays

#region Dikdörtgensel Diziler - Rectangular Arrays
/*
#ÇOK BOYUTLU DİZİLER - DİKDÖRTGENSEL DİZİLER(RECTANGULAR ARRAYS)
    Benim değişimle düzenli diziler birden fazla boyutu olup, boyutlarının da her ilk boyuta göre aynı olan dizilerdir. Yani iki boyutlu üçe dörtlük bir dizi ele alalım.
Bu dizi ilk boyutunda 3 adet int[] tek boyutlu 4 adet int veri alan dizi tutar. Bu sayede de çok boyutlu dizi olur. 3 boyutlu [2, 4, 3] biçiminde olsaydı da ilk boyut
int[][] biçiminde iki boyutlu dizi tutarken bunun içerisindeki ilk boyut ise yani normal dizimizin ikinci boyutu ise 4 adet int[] dizi tutar. Bu dizi de 4 adet int veri
tutardı. Görüldüğü üzere birden fazla boyutu dizi içerisinde dizi olmasına dayanıyor. İşte bu dizilerin her birinin de eşit sayıda dizi veya değer tutması demek de düzenli
dizileri var ediyor. Yani bu üç boyutlu dizimizde ilk boyut 2 adet iki boyutlu int[,] biçiminde [4, 3] lük dizi tutuyordu. Bu durum eğer 2 adet iki boyutlu dizimizin eşit
dizi tutmadığı şekilde yani biri [4, 3] diğeri [2, 5] alanlı dizi tutsaydı, düzensiz dizi meydana gelecekti. Tek Boyutlu Diziler de olduğu gibi bu dizi de de durum ve
kurallar aynı şekildedir. Yani tanımlama anında değer kümesi(iç içe {} süslü parantezler ile) belirtilerek boyut tanımlanabilir veya new operatörü ile boyut tanımlana
bilirdi. Fakat söylediğimiz gibi dizi dikdörgenseldir. Yani eşit sayıda veri kümesi girilmelidir. int[,] arrayName = {{1, 4, 7}, {3, 2, 97}}; şeklinde tanımlama demek
2 adet int[] dizi bulunduğu ve bu dizilerin de 3 int boyutunda olduğudur. Tek Boyutlu Diziler de de yapıldığı gibi new operatörü ile yer ayrılması anında da değer
ataması int[,] arrayName = new int[3,2] { { 3, 5 }, { 7, 8 }, { 9, 11 } }; biçiminde mümkündür. 
*/
#endregion

#region Düzensiz Diziler - Jagged Arrays
/*
#ÇOK BOYUTLU DİZİLER - DÜZENSİZ DİZİLER(JAGGED ARRAYS)
    Dikdörtgensel dizide anlattığımız gibi tüm boyutlarında eşit boyutlarda dizi veya eşit sayıda değer bulunmayan dizilerdir. Bu dizilerin tanımlaması diğerlerinden biraz
farklıdır. C/C++ dillerinden alışageldiğimiz dizi tanımlaması şekli kullanılır. Dikkat ederseniz şekli dedim. Çünkü hiçbir zaman son boyutlara düzenli olarak alan veremeyiz.
Yani iki boyutlu olan int[][] arrayName = new int[3][]; şeklinde de gördüğümüz gibi son alan düzensiz bir dizi tanımlaması kullandığımız için boş kalacaktı. Eğer üç
boyutlu bir dizi yani int[][][] arrayName = new int[3][][]; şeklinde bir dizi olsaydı yine son boyutlar boş kalması gerekecekti. Yani sadece ilk boyuta değer verebiliriz.
Fakat yine de tercihen son boyutu da vermeyebiliriz. Eğer bu son boyutu vermeyeceksek diğer dizi türlerinde olduğu gibi süslü parantezler ile ilk boyutun alanını
belirlememiz gerekmektedir. Yine de ilk boyutda asla düzensizlik elde edilemiyor. Diğer dizilerden farklı olarak {} süslü parantezler kullanımında da new anahtar kelimesi
ile düzensiz dizi oluşturmamız gerekmektedir. Tek boyutlu diziler hem düzenli hem düzensiz sayılabilir dolayısıyla düzensiz diziler de yer ayırmada kullanılabilir. Örnek
olarak int[][][] arrayName = new int[2][][] { new int[2][]{ new int[2]{ 3, 2}, new int[3]{4, 7, 8 } }, new int[1][]{ new int[1]{ 7} } }; üç boyutlu düzensiz dizi tanımlaması
bu şekildedir.
*/
#endregion

#endregion

#region System.Array Sınıfına Ait Methodlar
/*
    # void Array.Resize<Type>(ref array, int newSize); Type olarak belirtilen tipdeki ve ref ile verilen dizinin boyutunu, newSize kadar yeniden boyutlandırmak için kullanılır.
    Eğer newSize > array.Lenght ise dizi direkt genişletilir ve içerisindeki değerler etkilenmez. Eğer newSize < array.Lenght ise dizi son değerler silinerek küçültülür ve ilk
    array.Lenght - newSize veri değişmez. Dikkat edin bu bir genişletme veya küçültme yapmak içindir. Yeniden boyutlandırma dizi tanımlamasında olduğu gibi new ile yapılır.

    # Array Array.CreateInstance(Type arrayType, int size); arrayType olarak belirtilen tipde ve size ile belirtilen boyutta geriye Array tipinde bir dizi döndermektedir. 
    Bu dizi örnek bir dizisidir yani model olarak bir dizi kurmak istiyorsak bu diziyi kullanılırız. Referans bir tip olduğundan ötürü bir diziye eşlenebilir.

    # void Array.SetValue(object value, int indis); Geriye void dönderir yani Array sınıfı üzerinden değil Array sınıfından türetilen nesne üzerinden kullanılır. value ile 
    belirtilen değeri, Array nesnesinin indis ile belirtilen indisine atmak için kullanılır.
    
    # object Array.GetValue(int indis); Geriye object dönderir ve diziyi parametre olarak almaz yani Array sınıfı üzerinden değil Array sınıfından türetilen nesne üzerinden
    kullanılır. indis ile belirtilen indisdeki veriyi object türünde geriye dönderir.
    
    # string String.Join(char seperator, params object[]? values); Verilen yığındaki değerleri seperator ile verilen ayraç ile ayırarak string değişkene aktarmak için 
    kullanılır.

    # void Array.Copy(Array sourceArray, Array destinationArray, int lenght) ve void Array.CopyTo(Array array, int startIndis); İlk methoda sınıf ismi üzerinden erişiriz ve
    sourceArray dizisini destinationArray dizisine lenght kadar kopyalarız. ref vermemize gerek yoktur çünkü Array zaten referans türündedir. İkinci methoda ise array 
    sınıfından türetilmiş nesne ile erişiriz ve bu diziyi array ile belirtilen diziye startIndis den itibaren kopyalarız.

    Çok daha fazla method vardır fakat her birini yazamayız.
*/
#endregion

#endregion

#region Koleksiyonlar - Collections
/*
    System.Collections namespace'i altında bulunan, dizilerden farklı olarak sabit bir boyut olmadan çalışabilen gruplandırma elemanlarıdır. Koleksiyonlar Generic, Non Generic
ve Specialized olmak üzere üç grupda incelenebilirler. Koleksiyonlar aynı türden verileri tutabilirken, farklı türden verileri de bir arada tutabilirler. Koleksiyon 
içerisindeki veriler Boxing/Unboxing işlemlerine tabi tutulduğu ve aynı zamanda dynamic olduğu için performansları azdır.
*/
#region Cinse Özgü Olmayan Koleksiyonlar - Non Generic Collections
/*
    Adından da anlaşılacağı üzere, farklı türden verileri bir arada saklanabildiği yani içerisine tanımlanan verilerin boxing işlemi ile object türüne dönüştürüldüğü ve object
türünde tutulduğu koleksiyon türleridir. System.Collections namespace'i içinde bulunurlar. 'ArrayList', 'HashTable', 'SortedList', 'Stack' ve 'Queue' olmak üzere 5 adet
koleksiyon vardır.
1-)ArrayList Sınıfı
    ArayList arrayListName = new ArrayList(); biçiminde tanımlanırlar. 3 adet constructor tanımlıdır. İlk constructor görüldüğü üzere default constructor'dır. İkinci constructor
ise capacity özelliğini belirterek oluşturmak için kullanılır ki bu konuya az sonra değineceğiz. Son consturctor ise parametre olarak bir interface alır. ICollection
interface'i olarak isimlendirilir. interface konusunu henüz anlatmadık ama interface isminden de anlaşılacağı üzere ara yüz veya ara birim anlamına gelir. Methodlar ve property
tanımlanabilir, field tanımlanamaz. Bir class'ın belli başlı ihtiyaçlarını karşılamak için kullanılan yapılar olarak da söyleyebiliriz. İşte bizim ArrayList sınıfının genel
olarak elemanlarının özelliklerinin tanımını içerir. Yani son constructor için başka bir ArrayList verilirse bunun içeriğinin kopyalanması için kullanılır. Ayrıca ArrayList'e
indis numaraları ile dizilerde kullanıldığı gibi [] erişebilmek mümkündür. Ayrıca coleksiyonlarda 4'ün katları olarak kapasite arttırma yapılır. Yani 4 adet veri girildikten
sonra kapasite 8, 8 adet girildikten sonra 12 olarak artmaktadır.
    METHODLAR ve ÖZELLİKLER(Property)
    #int ArrayListName.Add(object value) => value olarak verilen değeri ArrayList'in sonuna ekler ve geriye indis numarasını dönderir.
    #void ArrayListName.Insert(int index, object value) => value olarak verilen değeri, index ile belirtilen index'e ekler.
    #void ArrayListName.AddRange(ICollection c) => c ile verilen koleskiyonu ArrayList'in sonuna ekler.
    #void ArrayListName.InsertRange(int index, ICollection c) => c ile verilen koleksiyonu index ile verilen index'den itibaren ekler.
    #void ArrayListName.Sort() => Farklı parametre alabilen methodları da olmasına rağmen genel olarak koleksiyonu sıralamak için kullanılır.
    #int ArrayListName.Count => ArrayList'in eleman sayısını tutar.
    #int ArrayListName.Capacity => ArrayList'in tutabileceği eleman sayısını yani boyutunu tutar. 4'ün katları şeklinde otomatik olarak genişletilir ve dinamik bir yapı sağlanır.
    #ArrayList ArrayListName.GetRange(int index, int count) => belirtilen index'den itibaren belirtilen count kadar ArrayList'i kopyalayarak geriye dönderir.
    #void ArrayListName.Remove(object value) => ArrayList içerisinden eğer varsa value olarak belirtilen değeri siler ve kaydırma işlemi yapılır.
    #void ArrayListName.RemoveAt(int index) => ArrayList içerisinden verilen index numarasındaki veriyi siler ve kaydırma işlemi yapılır.
    #void ArrayListName.RemoveRange(int index, int count) => ArrayList içerisinden verilen index numarasından count kadar veriyi siler ve kaydırma işlemi yapılır.
    #void ArrayListName.Clear() => ArrayList'i sıfırlar.
    #void ArrayListName.Reverse() => ArrayList içerisindeki verileri terse çevirir.
    #void ArrayListName.CopyTo(Array array) => array olarak verilen diziye ArrayList'i kopyalar.
    #object ArrayListName.Clone() => ArrayList'i klonlayarak geriye object türünde dönderir.
    #Array ArrayListName.ToArray(Type type) => ArrayList'i verilen type'e göre Array'e çevirerek geriye dönderir.
2-)HashTable Sınıfı
    ArrayList den farklı olarak, verileri index numaralarıyla değil de Anahtar object yardımıyla tutar. Her anahtar object eşsiz olmak zorundadır. HashTable koleksiyonunu anlamak
için HashTable region alanına bakın.
3-)SortedList Sınıfı
    HashTable ile ArrayList sınıflarının birleşimi gibi düşünülebilir. Verilen hem index ile hem de key ile tutulur.
4-)Stack Sınıfı
    Bilinen yığın mantığı ile çalışır.
5-)Queue Sınıfı
    Bilinen kuyruk mantığı ile çalışır.
*/
#endregion

#region Cinse Özgü Koleksiyonlar - Generic Collections
/*
  Adından da anlaşılacağı üzere, aynı türden verileri bir arada saklanabildiği yani içerisine tanımlanan verilerin boxing işlemi yapılmadan direkt olarak tanımlama halinde verilen
türünde tutulduğu koleksiyon türleridir. System.Collections.Generic namespace'i içinde bulunurlar. 'List', 'Stack', 'Queue', 'LinkedList', 'Dictonary', 'SortedDictonary', 
'SortedSet' ve 'HashSet' olmak üzere 8 adet koleksiyon vardır.
1-)List Sınıfı
    ArrayList sınıfının Generic karşılığı olarak nitelendirebiliriz. Tek fark olarak tanımlama anıdında List<Type> list; biçiminde içerisinde tutulacak verilerin veri tipleri
belirtilmek zorundadır.
2-)Stack Sınıfı
    Belirli bir tipde verilerin tutulduğu yığındır.
3-)Queue Sınıfı
    Belirli bir tipde verilerin tutulduğu kuyruktur.
4-)LinkedList Sınıfı
    Belirli bir tipde verilerin tutulduğu bildiğimiz çift yönlü bağlı listedir.
5-)Dictonary Sınıfı
    Non-Generic koleksiynlardaki HashTable'ın karşılığı olarak nitelendirebiliriz. Fark olarak tanımlamada anahtarın ve değerin tipinin belirtilmesidir. Bu tanımlamayı virgül
ile ayırarak Dictonary<KeyType, ValueType> dic; biçiminde yaparız.
6-)SortedDictonary Sınıfı
    Dictonary sınıfının verilerin sıralı olarak tutulduğu halidir. Sıralama işlemi yapıldığından performans kaybı vardır.
7-)SortedSet Sınıfı
    Elemanları key value sisteminde tutulmadan sıralı olarak tutulur. Yani SortedDictonary sınıfının key/value olmayan halidir. Elemanlar eşsiz olarak tutulur tekrarlanamaz.
8-)HashSet Sınıfı
    SortedSet sınıfında olduğu gibi elemanları eşsiz olmalıdır. SortedList'den farklı olarak elemanları sıralı olarak tutulmaz.
*/
#endregion

/*Bu içerik örnekleri ile birlikte ödev olarak doldurulacak.*/
#region Özelleştirilmiş Koleksiyonlar - Specialized Collections
/*
    Belirli işlemleri yapmak amacıyla geliştirilmiş koleksiyonlardır. 
*/
#endregion

#endregion

#region Hata Denetimi - Try-Catch-Finally
/*
    Programın çalışma anında hatadan kaynaklı olarak programın durdurulması yerine bunu yakalayarak belirli başlı işlemler yapıp hata kontrolü sağlamamız amacıyla kullanılan
Try-Catch-Finaly yapısı vardır. Bu yapı;
try
{
    Yapılması istenilen işlem.
}
catch(Exception ex) => isteğe bağlı olarak Exception ex değişkeninde hata tutulur.
{
    Yapılması istenilen işlem yapılamadıysa yapılacak işlem.
}
finally
{
    Her halukarda yapılmasını istediğimiz işlem.
}
    #Exception Nesnesi
        Program içerisinde kaynaklanan hatalar ile ilgili bilgileri içerisinde tutar. Catch kısmında atama yapılır.
        #Exception.Message: Hata mesajıdır.
        #Exception.Source: Hatayı oluşturan sınıf veya nesne ile ilgili bilgileri içerir.
        #Exception.TargetSite: Hatayı oluşturan method hakkındaki bilgileri içerir.
        #Exception.HelpLink: Oluşan hata ile ilgili destek dosyası oluşturmak veya var olan destek dosyasına erişmek için kullanılır.
        #Exception.StackTrace: Oluşan hata ile ilgili çağrıları içerisinde stack bilgisini tutar.
        #Exception.InnerException: Oluşan iç hataları tutar.
*/
#endregion

#region Ödev
/*

1-) Tüm dizi şekilleri için tanımlanabilecek her şekilde dizi tanımlayarak bir program yazınız. Programın içeriğini yaratıcılığınıza göre belirleyin. Ayrıca bu dizilerin her
biri için referans biçiminde kullanılabilen diziler tanımlayın ve onlar üzerinde değişiklik yaparak ana dizi üzerinde değişiklik yapılabildiğini gösterin.

2-)System.Linq sınıfı ile dizilerde yapılabilecek işlemleri öğrenerek bir program içerisinde kullan.

3-)Array sınıfının ve bu sınıfa kalıtımla bağlı olan sınıfların methodlarını araştırıp anlatın.

4-)Detaylı bir biçimde Specialized Collections konusunu eksiksiz olarak ders içeriği olarak yazın.
*/
#endregion

namespace Ders_2_
{
    #region New Compare for Sort Method
    public class MyCompare : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            return new CaseInsensitiveComparer().Compare(y, x);
        }
    }
    #endregion
    class Program
    {
        #region Sample's Methods

        #region Array Address
        static private void ArrayAddressSample()
        {
            int[] array = new int[4];
            Random rnd = new Random(); //Random sınıfından bir nesne türettik. Bu sınıf random sayı üretmek için kullanılır.
            Console.WriteLine(array);
            for (int i = 0; i < array.Length; i++) //foreach döngüsü içerisinde kolekeksiyon üzerinde değişiklik yapılamadığı için for döngüsü terçih ettik.
            {
                array[i] = rnd.Next(100);
                //Üç adet method override vardır. Parametresiz olan pozitif 0 dahilinde int değer dönderirken tek parametreli olan 0 ile verilen int değişken aralığında değer
                //dönderir. İki parametreli olan ise ilk parametre ile ikinci parametre arasında rastgele int değer dönderir.
            }
            int[] temp = new int[4];
            temp = array;
            foreach (var item in temp)
                Console.WriteLine(item);
            temp[3] = 9;
            temp[0] = 3;
            Console.WriteLine();
            foreach (var item in array)
                Console.WriteLine(item);
        }
        #endregion

        #region Array Methods
        static private void ArrayMethodSample()
        {
            string[] array = new string[] { "C#", "Phyton", "Java", "Objective-C" };
            Console.WriteLine("Array Created");
            foreach (var item in array)
                Console.WriteLine(item);
            Console.WriteLine("\nThe Array Has Been Extended To 5 Size");
            Array.Resize<string>(ref array, 5);
            array[array.Length - 1] = "New Value";
            foreach (var item in array)
                Console.WriteLine(item);
            Console.WriteLine("\nThe Array Has Been Shrunk To 3 Size");
            Array.Resize<string>(ref array, 3);
            foreach (var item in array)
                Console.WriteLine(item);
            Console.WriteLine("\n\nPress any key to go to Array.CreateInstance() Method example.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Array Created With Array.CreateInstance Method");
            Array programingLanguage = Array.CreateInstance(typeof(string), 4);
            programingLanguage.SetValue("C#", 0);
            programingLanguage.SetValue("Phyton", 1);
            programingLanguage.SetValue("Java", 2);
            programingLanguage.SetValue("Objective-C", 3);
            foreach (var item in programingLanguage)
                Console.WriteLine(item);
            Console.WriteLine("\nArray Created From Instance Array");
            string[] programingLanguages = (string[])programingLanguage;
            foreach (var item in programingLanguages)
                Console.WriteLine(item);
            Console.WriteLine("So, You see to array type is a reference type.");
            Console.WriteLine("\n\nPress any key to go to Type.IsArray Property example.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("array Variable is Array?" + " " + array.GetType().IsArray);
            string thisProgramingLanguage = array[0];
            Console.WriteLine("C# Value is Array Value?" + " " + thisProgramingLanguage.GetType().IsArray);
            Console.WriteLine("array[0] Value is Array Value?" + " " + array[0].GetType().IsArray);
            Console.WriteLine("\n\nPress any key to go to Array.GetValue() and Array.Join() Method example.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Geting Value With GetValue() Method");
            Console.WriteLine(array.GetValue(1));
            Console.WriteLine("\nGetting Value With Join() Method");
            Console.WriteLine(string.Join('-', array));
        }
        #endregion

        #region Non-Generic Collections

        #region ArrayList
        static private void ArrayListSample()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(2);
            ArrayList temp = new ArrayList(arrayList);
            Console.WriteLine("Values List of created with IColection parameter.");
            foreach (var item in temp)
                Console.WriteLine(item);
            Console.WriteLine("\nAdded a value of 2 on temp ArrayList. Values list of arrayList." + "The int value of the add method is returned[" + temp.Add(3) + "] " +
                "This value is the indis number of added data.");
            foreach (var item in arrayList)
                Console.WriteLine(item);
            Console.WriteLine("\nValues List of temp.");
            foreach (var item in temp)
                Console.WriteLine(item);
            Console.WriteLine("\nSo, you can see to constructor(ICollection c) is just copying values of ArrayList's parameter.");
            Console.WriteLine("\n\nPress any key to go to Insert(), InsertRange() and Sort() Methods example.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Added an intermediate value to the ArrayList collection with the Insert method.");
            arrayList.Insert(1, 8);
            Console.WriteLine("Value list of arrayList.");
            foreach (var item in arrayList)
                Console.WriteLine(item);
            Console.WriteLine("\nIntermediate values from temp Array were added to ArrayList collection with InsertRange method.");
            arrayList.InsertRange(1, temp);
            Console.WriteLine("Value list of arrayList.");
            foreach (var item in arrayList)
                Console.WriteLine(item);
            Console.WriteLine("\nSorting from small to large.");
            arrayList.Sort();
            Console.WriteLine("Value list of arrayList.");
            foreach (var item in arrayList)
                Console.WriteLine(item);
            Console.WriteLine("\nSorting in descending order.");
            arrayList.Sort(new MyCompare());
            Console.WriteLine("Value list of arrayList.");
            foreach (var item in arrayList)
                Console.WriteLine(item);
        }
        #endregion

        #region HashTable
        static private void HashTableSample()
        {
            Hashtable hashtable = new Hashtable(); /*Benzer olarak 15 adet farklı consturctor methodu bulunmaktadır.*/
            hashtable.Add("this is a first key", "value1");
            hashtable.Add("this is a second key", "value2");
            Console.WriteLine("hashtable's keys");
            foreach (var item in hashtable.Keys) /*hastable.Keys geriye ICollection interface'i dönderir.*/
                Console.WriteLine(item);
            Console.WriteLine("\nhashtable's values"); /*hastable.Value geriye ICollection interface'i dönderir.*/
            foreach (var item in hashtable.Values)
                Console.WriteLine(item);
            Console.WriteLine("\nThis is hashtable[0]'s value: {0}", hashtable[0]);
        }
        #endregion

        #region SortedList
        static private void SortedListSample()
        {
            SortedList list = new SortedList(); /*5 adet farklı cosnturctor methodu bulunur.*/
            list.Add("key", "value");
            Console.WriteLine("This is a list[object key] value: {0}", list["key"]);
            Console.WriteLine("This is a list.IndexOfKey(object key) value: {0}", list.IndexOfKey("key"));
            Console.WriteLine("This is a list.IndexOfValue(object value) value: {0}", list.IndexOfValue("value"));
        }
        #endregion

        #endregion

        #endregion
        static void Main(string[] args)
        {
            #region Array Address Sample
            //ArrayAddressSample();
            #endregion

            #region Array Methods Sample
            //ArrayMethodSample();
            #endregion

            #region ArrayList Sample
            //ArrayListSample();
            #endregion

            #region HashTable Sample
            //HashTableSample();
            #endregion

            #region SortedList Sample
            //SortedListSample();
            #endregion
        }
    }
}