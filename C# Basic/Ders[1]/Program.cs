using System;

#region using Anahtar Kelimesi Nedir?
/*Bulunulan .cs uzantılı C# proje dökümanı içerisinde kullanılmak istedilen metod veya kodlar için kütüphane veya sınıf tanımlaması yapmak için kullanılır.*/
#endregion

#region namespace Nedir?
/*Aynı işlevi gören sınıflar, fonksyionlar, değişkenler/sabitleri gruplamak için kullanılır.*/
#endregion

#region .NET Framework Nedir? - Temel Bilgiler
/*
.NET Dilleri;
    C#.NET, Visual Basic.NET, Visual C++.NET, F#, ASP.NET ve Typescript programlama dilleri, sonlarındaki takıdan da anlaşılacağı gibi .NET Framework dilleridir.

.NET Framework
    .NET Framework(Çatı) Microsoft tarafından yeni nesil masaüstü projelerini geliştirmek, çalıştırmak ve yönetmek için gerekli alt yapıyı sağlayan bir platform olarak
geliştirilmiştir. Windows işletim sistemleri ile uygulamalar arasında bir platform görevi görmektedir. Dolayısıyla farklı programlama dilleri tek bir iletişim katmanı
kullanarak işletim sistemine erişim sağlamaktadır. İşletim sistemleri ile bağlantı sağlamak için kütüphaneler ve araçlara sahiptir. Bu sayede de işletim sisteminden
bağımsız olarak kod geliştirilebilmektedir.
    .NET Framework yapısı yapısı artık tek bir framework yapısı yerine ".NET Framework", ".NET Core" ve "Xamarin" yapılarından oluşmaktadır.
        #->.NET Framework: Windows işletim sistemlerine özel Web, Windows Form, WPF vb. projeler geliştirmek için kullanılır.
        #->.NET Core: .NET Framework yapısından farklı olarak işletim sistemlerinden bağımsız projeler geliştirmek için kullanılır.
        #->Xamarin: İşletim sistemlerinden bağımsız olarak mobil proje geliştirmek için kullanılır.
Bunlar Framework yapılarının "App Models" yani Uygulama Modelleri olarak adlandırılır.
    .NET Framework yapılarında bir de "Base Libraries" yani Ana Kütüphaneler vardır. Bunlar;
        #->.NET Framework için [Base Class Library]
        #->.NET Core için [Core Library]
        #->Xamarin için [Mono Class Library]
olarak isimlendirilir. Fakat Microsoft ASP.NET programlama dillerindeki bu "Base Library" de ortak olan ".NET Standard Library" içerisinde birleştirmiştir.
    Ayrıca .NET Framework sadece .NET dillerine değil Python, Pascal, C++, Cobol, Java ve Scheme gibi 50 civarında programlama diline de destek vermektedir. Java ya verilen
bu destek sanırım daha sonradan sonlandırılmış durumdadır.

.NET Framework Compiling
    .NET Dillerinde derleme işlemi şu aşamalardan geçer;
        1.) Programlama diline ait derleyiciler Source Code(Kaynak Kodu/Bu Döküman) içerisindeki Managed Code(Ortak/Yürütülebilir Kod) "Microsoft Intermediate Language" ismi
        verilen (Ortak Dil) IL'ye çevirir ve CLR içerisine gönderilir. Bu sayede geliştirilen uygulamalar işlemciden bağımsız olarak yürütülebilmektedir. Source Code 
        içerisindegi Unmanaged Code ise derlenir ve direkt olarak çalıştırılır. C# 2000 yılında geliştirilmiş ve piyasaya sürülmüş olmasına rağmen 2002 yılında Managed Code 
        özelliğini kazanmıştır. Ayrıca compiler Source Code derlediğinde sadece IL yer almaz içerisinde Metadata(Veri Tipleri, Kullanılan Metodlar ve Sınıflar) da saklanır.
        2.) CLR (Common Language Runtime) yani ortak çalışma zamanı dili içerisine gelen IL bu yapının içerisindeki JIT Compilers tarafından derlenerek makine koduna
        çevrilir. Derleme işlemi CTS(Common Type System) yani Ortak Tip Sistemi kurallarına göre yapılmaktadır.
Bu aşamalarda CLR;
    # Otomatik Hafıza Yönetimi
    # Thread Yönetimi (Birden fazla işlemi aynanda gerçekleştirme.)
    # Kod Doğrulama, Derleme ve Çalıştırma
    # Yüksek Güvenlik Seviyesi
    # Yapılandırılmış Hata Ayıklama
    # Managed ve Unmanaged Kodların Birlikte Çalıştırılması
gibi önemli işlemleri gerçekleştirir.
    Bu sırada bellek yönetimi
        1-).NET dillerinde varsayılan olarak Managed Bellek Yönetimi kullanılır. Bu ise "Garbage Collector" mekanızması ile yönetilir.
        2-)Unmanaged Bellek Yönetiminde ise bellek yönetimini kullanıcının kendisi yapması gerekir.
*/
#endregion

#region Konsol Ekranı
/*
Konsol Ekranına Değer Yazma veya Okuma
    void Console.Write(Değişkenler ve Formatlı Yazım); Cursor'un bulunduğu konuma değer yazılır ve Cursor yazılan değerin sonunda konumlandırılır.
    void Console.WriteLine(Değişkenler ve Formatlı Yazım); Cursor'un bulunduğu konuma değer yazılır ve Cursor yeni satıra konumlandırılır.
        Formatlı yazı yazarken değişkenlere indis numarası verilir ve metin içerisinde bu indislerle değişkenin değerinin geleceği yeri belirtiriz. Örneğin int a = 5; int b = 4
        değişkenleri için Console.WriteLine("a = {0}, b = {1}, tekrar a = {0}", a, b); şeklinde yazarız.
        Kaçış Karakterleri
            \a Bip sesi çıkartır.
            \b Backspace
            \f Next Page
            \n New Line (Bunun yerine Char(13) yani Enter ve Char(10) Home tuşu da kullanılabilir.)
            \r Return Start Line
            \t Tab
            \v Vertical Tab
            \' Tek Tırnak
            \" Çift Tırnak
            \\ Ters Bölü
            \? Soru İşareti
    string Console.ReadLine(void); Geriye string döndermesinden de anlaşılacağı üzerine Cursorun başlangıcından satır sonuna kadar olan tüm değerleri string biçiminde okur.
    int Console.Read(void); Geriye int döndermesinden de anlaşılacağı üzere Cursorun başlangıcından sonraki karakteri okuyarak ASCII kodu dönderir.
    
    ConsoleKeyInfo Console.ReadKey(void or boolean); Geriye konsol ekranı odaklanmış iken basılan tuşu dönderir. Bu tuş ConsoleKeyInfo içerisinde tutulur. Parametre olarak
    boolean bir değer girersek basılan tuşun değeri ekranda gözüksün/true yada gözükmesin/false karar veririr. Default olarak gözükmez.

    void Console.Clear(void); ile konsol ekranını temizleyebiliriz. 
    
    Console.Color Console.BacgroundColor = Console.Color.Color; Console.BacgroundColor property'sinin rengini değiştirerek console'un arka planının rengini değiştirebiliriz.
    Console.Color Console.ForegroundColor = Console.Color.Color; Console.ForegroundColor property'sinin rengini değiştirerek console'un metin rengini rengini değiştirebiliriz.
    void Console.ResetColor(void); ile konsol ekranının renklerini varsayılana döndürebiliriz.

    void System.Environment.Exit(int ExitCode); Programın bitirilmesini ExitCode ile sağlar.

    boolean Console.TreatControlCAsInput property'si ise CTRL+C yapılınca programın kapanmamasını sağlar. Yani CTRL+C kombinini input olarak algılar.

    void Console.SetCursorPosition(int x, int y); Cursor'un pozisyonunu x ve y değerlerine göre konumlandırılması sağlanır.
    void Console.SetWindowSize(int width, int height); Verilen genişlik ve yüksekliğe göre konsol ekranının boyutunu ayarlar.
    void Console.SetWindowPosition(int x, int y); Verilen x ve y değerlerine göre ekranda konsolun pozisyonunu ayarlar.
*/
#endregion

#region Sabitler ve Değişkenler
/*
Sabitler;
    Sabitler de değişkenlerdir. Değerleri değiştirilemez sabittir. Sabitler const ve readonly olmak üzere ikiye ayrılır.
        #->const
            Sadece tanımlama anında değer verilir ve bu değer bir daha asla değiştirilemez. Örneğin PI sayısının verilmesi için const tanımlanabilir. Ayrıca const varsayılan
        olarak static'dir.
        #->readonly
            const sabitinden farklı olarak runtime anında değer atılabilirken, değersiz tanımlama yapıp constructor üzerinden de değer ataması yapılabilmektedir. Static
        tanımlaması yaparak da farklı sınıflar üzerinden de değer okuması yapılabilir. Ayrıca const sabitinde const int year = DateTime.Now.Year; şeklinde runtime anında değer
        ataması mümkün değildir. Fakat readonly int year = DateTime.Now.Year; ataması yapılabilmektedir. Yani işin özü readonly genellikle sınıflar için geliştirilmiş sabittir.
*/
/*
Değişkenler;
    Değişkenler programın içerisinde çalışma zamanında verileri çeşitli tiplere göre ram üzerinde tutmak için kullanılır. Değişkenler [type] [name] = [value]; biçiminde tanımlanır.
Değeri o anda atamak istemiyorsak [type] [name]; biçiminde de tanımlama yapılabilmektedir. Ayrıca birden fazla değişken tanımlarken [type] [firstVariableName], [secondName];
biçiminde birden fazla değer atılabilse de önerilen teker teker [type] [firstVariableName]; [type] [secondName]; biçiminde tanımlama yapılması önerilir. Yine bir yazılı olmayan
kurala göre C# da property(ilerde görülecek) ve method isimlerinin baş harfleri büyük olurken, normal değişken isimlerinin baş harfleri küçük yazılır. Ayrıca bir sınıftan türetilen
nesnelerin baş harfleri de küçük olarak yazılır. Yine bir başka öneriye göre gerek olmamasına rağmen sınıf içerisindeki bir metod ile sınıf içerisindeki bir değişkene veya
property'e değer ataması yaparken parametre ismi '_' alt tire karakteri ile yapılır. Tabi bunun yerine this. daha mantıklıdır.
    Değişkenler değer tipi ve referans tipi değişkenler olmak üzere ikiye ayrılır. Bu ayrımı ise bellek bölümleri sağlar.
        #STACK
            İçerisinde tutulacak olan verinin boyutu bilinerek static olarak veri tutulabilir. Çalışma zamanında boyutlarını genişletmek mümkün değildir. Verilerin veya
        değişkenlerin kullanımı bittikten sonra otomatik olarak bellekten düşümü sağlanır.
        #HEAP
            İçerisinde tutulacak olan verinin boyutunun bilinmesine gerek yoktur. Dinamik olarak yer ayrımı sağlanabilmektedir. Dolayısıyla HEAP bölgesi STACK bölgesinden daha
        büyüktür. Bu avantajın ise daha yavaş çalışma gibi bir dezavantaju vardır. Verilerin veya değişkenlerin kullanımı bittikten sonra bellekten "Garbage Collector" sayesinde
        bellekten temizlenir. Lakin HEAP bögesinde tutulan referans değişkenleri yine adresleri tutabilen bir STACK bölgesine ihtiyaç duyarlar. Adresler STACK bölgesinde
        tutulurken değerler HEAP bölgesinde tutulur.

DEĞER TİPİ DEĞİŞKENLER
    # byte => 8 bit işaretsiz tam sayı. CTS Tipi System.Byte;
    # sbyte => 8 bit işaretli tam sayı. CTS Tipi System.SByte CLS Uyumlu değildir;
    # short => 16 bit işaretli tam sayı. CTS Tipi System.Int16;
    # ushort => 16 bit işaretsiz tam sayı. CTS Tipi System.UInt16;
    # int => 32 bit işaretli tam sayı. CTS Tipi System.Int32;
    # uint => 32 bit işaretsiz tam sayı. CTS Tipi System.UInt32;
    # long => 64 bit işaretli tam sayı. CTS Tipi System.Int64;
    # ulong => 64 bit işaretsiz tam sayı. CTS Tipi System.UInt64;
    # float => 32 bit tek kayan noktalı sayı. CTS Tipi System.Single;
    # double => 64 bit çift kayan noktalı sayı. CTS Tipi System.Double;
    # decimal => 128 bit ondalıklı sayı. CTS Tipi System.Decimal;
    # bool => 1 bitlik ifade. CTS Tipi System.Boolean;
    # char => 16 bitlik Unicode karakter. CTS Tipi System.Char;
REFERANS TİPİ DEĞİŞKENLER
    # string => Unicode karakterlerinden oluşan küme. CTS Tipi System.String;
    # object => Genel bir veri tipidir. Boxing ve Unboxing yaparak esnek programlama sağlar. CTS Tipi System.Object;
    # dynamic => Yine genel bir veri tipidir. Boxing/Unboxing işlemi yapılmaz. Güvenli ve esnek programlama sağlar. CTS Tipi System.Dynamic;
var Belirtimi
    Değişken tipini atama yapılan değere göre belirten bir değişken tanımlama yöntemidir. Object ile dynamic veri tipleri arasında bir işlev görür diyebiliriz.
Digit Seperator
    C# 7.0 ile gelen bu özellik ile rakamlar arasında ayrım yapılabilmektedir. Örneğin;
    int a = 33_000_000; int a = 33000000;
    int a = 0b_0100_1011_1100; int a = 0b010010111100;
    int a = 0x_ff1a_abb7; int a = 0xff1aabb7;
    int a = 0_571; int a = 0571;
    şeklinde kod okunabilirliği arttırılabilmektedir.
Değişkenlerin Varsayılan değerleri
    #bool = false;
    #byte/sbyte = 0;
    #char = '\0';
    #decimal = 0.0M;
    #double = 0.0D;
    #float = 0.0F;
    #int/uint = 0;
    #long/ulong = 0L;
    #short/ushort = 0;
    #string = null;
    Ayrıca değişkenlere varsayılan değerlerini vermek için default anahtar kelimesini örneğin int a = default(int) biçiminde atayabiliriz. C#7.1 sonrasında ise direkt olarak
int a = default; olarak atama işlemi sağlanır.
*/
#endregion

#region Referans İşlemleri
/*
    Referans işlemi yaparak bir değişkenin değerini direkt olarak o değişkene müdahale etmeden veya bir method içerisinde değiştirmek için ref ve out ifadeleri kullanılır.
ref Anahtar Kelimesi
    ref referance kelimesinin kısaltılmış halidir. ref anahtar kelimesi ile bir değişkenin adresini diğer değişkenin adresine eşitleriz. ref kullanılabilmesi için adresi atanacak
olan değişkenin değeri verilmelidir. Aksi halde hata ile karşılaşılır.
out Anahtar Kelimesi
    ref anahtar kelimesinden farklı olarak adresi atanacak olan değişkenin değeri verilmemiş olabilmektedir. Sadece tanımlama yapılması o değişkeni out olarak gönderebilmemizi
sağlar. Fakat out için de durum şöyle ki; eğer out olarak gönderilen bir parametre de değişiklik yapılmamış ise hata ile karşılaşırız. Örnekleri ref&out region alanına
inceleyebiliriz.
*/
#endregion

#region Boxing ve Unboxing
/*
    Bir değişkeni kutuluyarak(Boxing) taşınması ve kutudan çıkartarak(Unboxing) değere ulaşılması işlemleridir. Fakat dikkat edilmesi gereken şey şudur Boxing işleminde
değişkenin adresi değil değeri kutulanır. Yani daha sonradan değişken üzerinde yapılan değişikliğin Boxing yapılan object türündeki değişkende değişiklik olması beklenemez.
*/
#endregion

#region Değişken Tiplerini Öğrenme - is ve as Anahtar Kelimeleri
/*
    Değişken tiplerini öğrenmek için Type sınıfından object sınıfından override eden ve tüm değişkenlerin object veri tipine bağlanması ile bu override edilen
Type GetType(void); methodunu kullanabiliriz veya type methodunun anahtar kelimesi olan typeof(variable); da kullanabiliriz. Dikkat edilmesi gereken typeof parametre olarak
değişken tipini alırken get type değişkenin isminden '.' operatörü ile methoda erişim sağlayarak o değişkenin tipini döndermekte. Bu yüzden değeri atanmamı bir değişkende
GetType methodu kullanılamaz.

    Yine değişken tiplerini öğrenmek için ve buna göre işlem yapabilmek için bazı anahtar kelimeler vardır. Bunlar is ve as anahtar kelimeleridir.
        is: variableName is variableType şeklinde kullanılır. Belirtilen değişken belirtilen değişken tipinde ise geriye true, değilse geriye false dönder.
        as: variableType templeVariableName = variableName as variableType; Eğer variableName değişkeni variableType tipinde ise templeVaraibleName e atanır. Eğer tipi
        variableType tipinde değilse geriye null dönderir ve templeVariableName değişkeninin değeri null olur. Dolayısı ile bu ifade sadece null değer alabilen değişken
        tiplerinde kullanılabilir.
*/
#endregion

#region Type Casting
/*
    Değişkenleri birbirine dönüştürmeye ihtiyaç duyabiliyoruz veya mecbur kalabiliyioruz. Bu yüzden Type Casting ile dönüşüm sağlıyoruz. Dönüşümler Kapalı Dönüşüm ve
Açık Dönüşüm olmak üzere ikiye ayrılır.

#Kapalı Dönüşüm - Implicit Conversion
    Hiç bir işleme gerek duymadan derleyicinin kendi kendine dönüşüm işleminin kapalı bir biçimde yapılmasıdır. Kapalı dönüşümün sağlanacağı durumlar her değişken için
aşağıdaki gibidir.
        #sbyte => short, int, long, float, double, decimal
        #byte => short, ushort, int, uint, long, ulong, float, double, decimal
        #short => int, long, float, double, decimal
        #ushort => int, uint, long, ulong, float, double, decimal
        #int => long, float, double, decimal
        #uint => long, ulong, float, double, decimal
        #long => float, double, decimal
        #ulong => float, double, decimal
        #char => ushort, int, uint, long, ulong, float, double, decimal (Tabiki Unicode tablosundaki decimal değerleri)
        #float => double

#Açık Dönüşüm - Explicit Conversion
    Kapalı dönüşümün yapılamadığı durumlarda geliştiricinin methodlar kullanarak dönüşüm yapması gerekebilir. Bunun için 4 adet yöntem vardır.
1-) Parantez Operatörleri İle Cast Etme
    Değişkenin başına ben bu değişkenin ne geleceğini biliyiyorum ve bundan eminim demek için kullanılır. Örneğin string a = "442"; değişkenimiz olsun ve bu değişkenin
değerini int b; değişkeninine atarken a değişkeninin değerinin sayısal bir değer olduğundan eminiz ve bu hiç bir zaman değişmiyeceğinden eminiz. Bu yüzden b = (int)a;
şeklinde belirterek dönüşüm sağlayabiliriz.
2-) Parse Methodu
    string bir değeri istenilen bir değere dönüştürmek için kullanılır. type.Parse(value); biçiminde kullanılır. Geri dönüş değeri type hangi tipden ise odur. Dönüşüm
yapılamaz ise hata verir. Örneğin parantez örneğindeki değişkenler için b = int.Parse(a); dönüşümü başarıyla sağlanır.
3-) TryParse Methodu - bool type.TryParse(Casting value, out result);
    Parse methodu gibi string bir ifadeyi diğer değişken türlerine dönüştürmek için kullanılır. Parse methodundan farkı, oluşabilecek tüm hatalara karşı programda çalışma
zamanında bir hata vermez geriye false dönderir ve çıkış sonucu olarak 0 atanır. Dönüşüm başarılı ise dönüştürülen değer sonuca atanır ve geriye true dönderir.
4-) Convert Sınıfı
    Bu sınıf System kütüphanesinin altında bulunur. 17 adet değişken tipi için dönüşüm methodları bulunur. Bunlar;
    #ToBase64String(string value) => Verilen string değeri Base64 şifrelemesine dönüştürür.
    #FromBase64String(string value) => Verilen Base64 şifrelemesi değerini stringe dönüştürür.
    Ve geri kalanlar adından da anlaşılacağı üzere dönüşümler yapar. Ayrıca Convert.ToString(type value); dönüşümünü variable.ToString(); ifadesi ile dönüşüm sağlanabilir ve ayrıca
    bir tarih değerini formatlı biçimde dönüşüm yaptırmak istiyorsak DateTime.Now.ToString(format/"dd-MM-YYYY"); şeklinde yapabiliriz.
*/
#endregion

#region Kullanıcı Tanımlı Veri Tipleri - Property Özeti, Erişim Belirteçleri, Constructor ve Deconstructor 
/*
    Kullanıcı tanımlı veri tipleri struct(structer/yapı) ve enum(enumerator/numaralandırma) olmak üzere ikiye ayrılır.
1-)Struct Veri Yapısı
    Farklı tipten değişkenleri, özellikleri ve methodları bir çatı altında gruplandırmak için kullanılırlar. Struct'ın boyutu içerisinde bulunan elemanların toplam boyutu
kadardır. Dolayısıyla Struct değer tipi olan bir veri yapısıdır. Ayrıca C# 7.2 sürümünden itibaren structlar değer tipinde olmasına rağmen referans olarak tanımlanabiliyor
ve ayrıca readonly structlar tanımlanabiliyor.
    
#Ara Konu[Erişim Belirteçleri]
    Erişim belirteçleri kullanıcı tanımlı veri yapılarında veya sınıflarda kullanılan nesneler(method/property/değişken) için erişimi ayarlamak için kullanılır. Yani
bir nesne sadece sınıf içerisinden mi? Yoksa sadece kalıtım uygulanan sınıflar içerisinden mi? Yoksa genel erişim için mi kullanılacağını belirleriz. Erişim Belirteçleri
Private(Sadece bulunduğu sınıf üzerinden erişilebilir), Protected(Kalıtım uygulanan sınıf/sınıflar tarafından erişilebilir), Public(Genel erişilebilir) olarak üçe ayrılır.
#Ara Konu[Property]
    Nesneye dayalı programlama ve structer yapıları ilk çıktığı zamanlar bu yapılar içerisindeki nesnelere değer atamaların kontrollü yapılması gerektiği durumlar oldu.
Bu yüzden değişken oluşturulur ve bu değişken için get ve set methodları oluşturulurdu. Bu değişkenlere değer atarken set methodu içerisinde gerekli kontroller yapılır ve
değişken private olarak tanımlandığı için istediğimiz şartlar yerindeyse değişkene parametre yoluyla değer atanabiliyordu. Get methodunda ise yine istenilen şartlar kontrol
ediliyor ve eğer şartlar sağlanıyorsa bu method yardımıyla geriye döndürülebiliyordu. Fakat daha sonradan geliştirilen yeni dillerde bu işlemler PROPERTY'ler sayesinde
yapılabilmektedir. Property'ler içerisinde Get ve Set anahtar kelimleri aracılıyla method barındırabiliyorlar ve bunlara göre işlem yapabiliyorlar. C# programlama dilinde
Property tanımlamak için [erişim belirteci] [değişken tipi] [property ismi] {get; set;} şeklinde kısa yoldan tanımlanabilmektedir. Az önce de söylediğimiz gibi get ve set
için kod kümesi yazarak da tanımama yapabiliriz. Fakat bunları daha sonra konu gelince anlatılacaktır.
#Ara Konu[Constructor ve Deconstructor]
    #Constructor - Yapıcı
        Veri yapısından(Struct Class) her nesne new anahtar kelimesi ile türetildiğinde çalışan ve parametre sayısı veya parametre tipi farklı olmak şartıyla birden fazla
    tanımlanılabilen method'dur. Constructor ismi veri yapısının ismi ile aynı ve public olmak zorundadır. Nesnenin tanımlandığı anda nesneye default olarak değerler vermek
    veya readonly olan yapı için değer vermek için kullanılır.
    #Deconsturctor - Yıkıcı
        Sınıftan oluşturulan her nesnenin silinmesi temizlenmesi durumlarında çalışan methoddur. Tanımlanırken sınıfın isminin başına ~ getirilerek tanımlanır.
    Parametre alması ve birden fazla tanımlanması mümkün değildir. Struct veri yapısı için deconsturctor tanımlanamaz.

    #Standart Struct Oluşturmak
        struct [Struct Yapısının İsmi]
        {
            property
            method
            değişken
        }
        Biçiminde tanımlanırlar. Değişken oluşturmak için ise normal değişken oluşturma kuralları kullanılır. Tek fark ise oluşturulan değişken new anahtar kelimesi ile
    yani [struct yapısının ismi] [struct değişkeninin/nesnesinin ismi] = new [Struct Yapısının İsmi](); biçiminde tanımlanırlar. Eğer bu structın Constructor methodu var ise
    ki default olarak parametresiz ve hiçbir işlem yapmayan Consturctor methodu vardır, parametre vererek de tanımlanılabilmektedir. Tabiki Struct'ları new anahtar kelimesi
    olmadan da kullanabilmekteyiz. Fakat new anahtar kelimesi olmadan türetilen nesneler için struct içerisindeki değişkenlere varsayılan değerler verilmediği için hata
    alırız. Bizde varsayılan değer verelim neden new anahtar kelimesi ile uğraşıyoruz? Eğer bu şekilde struct kullanılırsa içerisinde property tanımlanması yapılamamaktadır.
    Field'lara(Değişkenler) değer atamak için ise direkt olarak = operatörü kullanılır.
    #Readonly Struct Oluşturmak
        Readonly struct oluştururken sadece readonly anahtar kelimesini 'struct structismi' tanımlamasının başına koymamız yeterlidir. Readonly struct ile sabit bir struct
    yapısı elde etmiş oluyoruz. C#7.2 sürümünde gelen bu özellik için tek şart bu struct'ın elemanlarının da readonly olmasıdır.
    #Referance Struct Oluşturmak
        Struct'ların değer tipinde olduklarını yani ram'in stack bölümünde tutulduğunu biliyoruz. Bu yüzden de struct ile bir eşitleme kullanıldığı zaman yani kopyası
    oluşturulduğu zaman ana değişken üzerinde hiç bir değişiklik yapılmadığını görürüz. Bu yüzden referans türünde bir struct oluşturmak isteyebiliriz. Aynı şekilde bildiğimiz
    üsere değişkenlere de aynı işlemi yapabiliyorduk. Bunu örneğin "int mainVariable = 78; ref int referanceIntVariable = ref mainVariable; referanceIntVariable = 488;"
    biçiminde yazar ve mainVariable değişkenini ekrana yazdırırsak, referanceIntVariable değişkenine atanan 488 değerinin mainVariable değişkenine de atıldığını görürüz. Bu
    ne demek oluyor değişen değeri değil de stack bölgesindeki adresi tuttuğu anlamına geliyor. Aynı şekilde structlar için de oluşturma anında ref anahtar kelimesi ile referans
    struct oluşturmamız mümkündür. Fakat bunun dezavantajları da vardır. İlk olarak boxing/unboxing işlemi yapılamaz. Nedeni ise dediğimiz gibi adres tutmasıdır. İkinci olarak da
    structismi değişkenismi = new structismi(); biçiminde tanımlama yapılmamalıdır. Bunun için var değişkenismi = new structismi(); biçiminde nesne tanımlaması yapmaktır.

2-)Enum
    Yazdığımız program üzerinde sabit değerlerin anlamlandırılması ve gruplandırılması için kullanılır. Örneğin mevsimleri mevsimler isimli bir enum ile tanımlamak doğru
ve kullanışlı olacaktır. Enum örneği region alanları arasında örnek verilmiştir. Enumlarda bazı gerekli methodlar vardır bunlar;
    #bool Enum.IsDefined(Type enumType, object value); type ile verilen enumun içerisinde value değeri tanımlanmışsa true, yoksa false dönderir.
    #string Enum.GetName(Type enumType, object value); type ile verilen enumun içerisinde value değerinin string karşılığını dönderir.
    #string[] Enum.GetNames(Type enumType); type ile verilen enumun içerisindeki değerleri string dizisi olarak geriye dönderir.
    #Array Enum.GetValues(Type enumType); type ile verilen enumun içerisindeki sayısal değerleri int Array olarak geriye dönderir.
    #object Enum.Parse(Type enumType, string value, bool ignoreCase); type ile verilen enum içerisinde value değerini eğer ignoreCase true ise büyük küçük harf duyarlılığı
    olmadan, false ise büyük küçük harf duyarlılığı olarak geriye object biçiminde o elemanı dönderir.
*/
#endregion

#region Operatörler
/*
Operatörler
    Tek başına bir şey ifade etmeyen, değişkenler ve kontrol yapıları için gerekli olan operatörlerdir. C# içerisinde operatörler; aritmetiksel, aktarma, mantıksal, 
karşılaştırma ve birleştirme operatörleri olarak beş'e ayrılır. Fakat operatörleri kullanırken işlem öncelikleri önemlidir. Aşağıda işlem önceliği öncelikliden-önceliksize
doğru bir tablo vardır.
    #-->()
    #-->'!', '+', '-', '++', '--'
    #-->'*', '/', '%'
    #-->'+', '-'
    #-->'<', '<=', '>', '>=', 'is', 'as'
    #-->'==', '!='
    #-->'&'
    #-->'^'
    #-->'|'
    #-->'&&'
    #-->'||'
    #-->'?:'
    #-->'=', '*=', '/=', '%=', '+=', '-=', '&=', '^=', '|='
    Yukarıdaki tabloya dikkat edilmeden yazılan kodlarda mantıksal hatalar meydana gelecek ve istenilen algoritma başarısız olacaktır. Ayrıca bu operatörleri hayal gücüne bağlı
olarak istenilen yerde kullanabilir ve programlamada ezber yerine doğal kod yazılabilmektedir.
    #Aritmetiksel Operatörler
        Aritmetiksel operatörler matematiksel işlemleri gerçekleştirmek için kullanılırlar. Beş adet aritmetiksel operatör bulunur. Bunlar; Toplama(+), Çıkarma(-), Çarpma(*),
    Bölme(/) ve Mod(%) operatörleridir.
    #Mantıksal Operatörler
        Aynı zamanda boolean operatörler olarak da anılan bu operatörler, true ve false değerleri ile işlem yapmaktadır. Mantıksal operatörler aslına içinde bitsel operatörler
    olarak da bir gurubu vardır. Bu operatörler için ek açıklama yanına yazılacaktır. Bu operatörlerden 3 adet vardır.
        #->And(&): Mantık kapılarındaki ve işlemini gerçekleştirir. true ve false işlemlerinin yanı sıra binary olarak da işlem görür. Örneğin 4(0100) ile 6(0110) rakamları
        arasında yapılsaydı 1 ifadelerinin karşılık geldiği yerler true yani 1 diğer yerler 0 olacaktı yani sonuç olarak bize 4(0100) dönecekti.
        #->Or(|): Mantık kapılarındaki veya işlemini gerçekleştirir. true ve false işlemlerinin yanı sıra binary olarak da işlem görür. Örneğin 4(0100) ile 6(0110) rakamları
        arasında yapılsaydı 1 ifadelerinin olduğu yerler true yani 1 diğer yerler 0 olacaktı yani sonuç olarak bize 6(0110) dönecekti.
        #->XOr(^): Mantık kapılarındaki veya işlemini gerçekleştirir. true ve false işlemlerinin yanı sıra binary olarak da işlem görür. Örneğin 4(0100) ile 6(0110) rakamları
        arasında yapılsaydı 1 ifadelerinin karşısında 0 olduğu yerler true yani 1 diğer yerler 0 olacaktı yani sonuç olarak bize 2(0010) dönecekti.
        #->Double And(&&): Yukarıdaki ve operatöründen farklı olarak ilk değeri kontrol eder ve ilk değere göre her halukarda true veya false dönecekse ikinci değeri hiç
        kontrol etmez. Örneğin ilk ifade false olur ise her halukarda false döneceği için performansdan kazanç sağlayarak diğer ifadeye hiç bakmadan false dönderir.
        #->Double Or(||): Yukarıdaki veya operatöründen farklı olarak ilk değeri kontrol eder ve ilk değere göre her halukarda true veya false dönecekse ikinci değeri hiç
        kontrol etmez. Örneğin ilk ifade true olur ise her halukarda true döneceği için performansdan kazanç sağlayarak diğer ifadeye hiç bakmadan true dönderir.
        #->Not(!): Mantık kapılarındaki değil işlemini gerçekleştirir. Eğer ifade true dönüyorsa false, false dönüyorsa true yaparak tersler.
    #Aktarma/Atama Operatörleri
        Bir değeri değişken veya nesne içerisine atamak için kullanılan operatörlerdir. Aktarma operatörleri yukarıdaki tablonun en alt satırında yer almaktadır. Bunların
    görevleri sırasıyla; 
        #"Direkt olarak değeri atar"
        #"Sol taraftaki değer ile atanan değeri çarparak sol taraftaki değere atar"
        #"Sol taraftaki değer ile atanan değeri bölerek sol taraftaki değere atar"
        #"Sol taraftaki değer ile atanan değerin modunu alarak sol taraftaki değere atar"
        #"Sol taraftaki değer ile atanan değeri toplayarak sol taraftaki değere atar",
        #"Sol taraftaki değer ile atanan değeri çıkartarak sol taraftaki değere atar"
        #"Sol taraftaki değer ile atanan değeri bitler üzerinde and işlemi yaparak sol taraftaki değere atar"
        #"Sol taraftaki değer ile atanan değeri bitler üzerinde özel veya işlemi yaparak sol taraftaki değere atar"
        #"Sol taraftaki değer ile atanan değeri bitler üzerinde veya işlemi yaparak sol taraftaki değere atar".
    #Karşılaştırma Operatörleri
        İki ifadeyi istenilen şarta uyuyormu diye kontrol etmek için kullanılır. 9 adet karşılaştırma operatörleri vardır. Bunlar;
        #->Büyüktür(>): Soldaki ifade sağdaki ifadeden büyük ise true dönderir.
        #->Küçüktür(<): Soldaki ifade sağdaki ifadeden küçük ise true dönderir.
        #->Büyüktür ya da eşittir(>=): Soldaki ifade sağdaki ifadeden büyük ya da eşit ise true dönderir.
        #->Küçüktür ya da eşittir(<=): Soldaki ifade sağdaki ifadeden küçük ya da ise true dönderir.
        #->Eşittir(==): İki ifade birbirine eşit ise true dönderir.
        #->!(Değil): Sadece boolean ifadeler için kullanılır. true değil ise true dönderir. Sonuç olarak true veya false dönderen ifadeler de boolean ifade olduklarından ötürü
        onlar için de kullanılabilmektedir.
        #->Eşit Değil(!=): İki ifade birbirinden farklı ise true dönderir.
        #->Uzaklaştırma/Eksiltme(-->): Soldaki ifadeyi sağdaki ifadeye eksilterek yaklaştırmak için kullanılır. Uzaklaşma sağlanıyor ise true dönderir.
        #->Yakınlaştırma/Arttırma(<--): Soldaki ifadeyi sağdaki ifadeye arttırarak yaklaştırmak için kullanılır. Arttırma sağlanıyor ise true dönderir.
    #Birleştirme Operatörleri
        Diğer operatörler boolean ifadeler veya sayısal ifadeler ile kullanılıyordu. Peki ya metinsel ifadeler için? Birleştirme operatörleri stringler üzerinde
    gerçekleştirilirler. İki ifadeyi birleştiren (+) ve İki ifadeyi birleştirip soldaki ifadeye atayan (+=) operatörlerinden oluşurlar.
    #Diğer Özel Operatörler
        #->Null Coalescing(??): Türkçesi null birleştirme anlamına gelen bu operatör, soldaki ifade null ise ikinci ifadeyi, null değil ise kendisini dönderir. Peki ya bu
        operatör neden var? Örneğin isim ile ilgili kullanıcı ile işlem yapan bir program yazdığımızı ele alalım. String ifadeye de başlangıç olarak null değeri atadığımızı
        varsayalım. Eğer isim girilmediyse istenilen yazıyı yazmak istiyoruz. Bunun için [Console.WriteLine(nameVariable ?? "İsim Girilmedi");] kodunu yazabiliriz.
        #->Koşul Operatörü(?:): Tek satırda değer kontrolü yazarken if ifadesini yazmamıza gerek yok. Örneğin int a = 3; ifadesinde bu operatörü kullanarak eğer değer
        3 ise şu, değilse şu işlemini yaptıralım. a == 3 ? "a 3 ise dönderilecek değer" : "a 3 değil ise dönderilecek değer;"
*/
#endregion

#region Kontrol Yapıları
/*
    Kontrol yapıları if-else ve switch-case yapısı olmak üzere ikiye ayrılır. Bu kontrol yapıları sayesinde programın akışı içerisinde gerekli kontroller yapılarak akış
dallandırılabilmektedir.
    #if-else-else if Yapıları
        Kontrol yapısının başına gelen if ve eğer başka bir kontrol ifadesi kontrol edilecek ise else if ve eğer hiç bir ifade de true dönmüyorsa yapılacak işlemler için else
    ifadeleri vardır. Bu kontrol yapıları iç içe gerçekleştirilebilir. if ifadesi olmadan kontrol yapısı başlatılamaz ve else ifadesi eğer eklenmek isteniyorsa da ifadenin en
    sonunda yer almalıdır. Yani if den sonra else gelip daha sonra tekrar else if eklenemez.
    #Switch Case Yapısı
        if-else yapısından farklı olarak değişkenlerin değerlerini kontrol ederek işlem görür. Bu sayede de if-else yapısından çok daha performanslıdır. İşlevi az olduğundan da
    bu yapıyı kullanmak için doğru zaman belirlenmelidir. Örneğin bir enum üzerinden türetilen nesnenin aldığı değerleri switch-case ile kontrol etmek daha mantıklıyken, bir
    değerin bir değerden büyük, küçük veya eşit olduğu gibi durumlar için if-else yapısı kullanmak daha mantıklıdır.
*/
#endregion

#region Döngüler
/*
    Döngüler program içerisinde belirli bir şarta göre sürekli tekrarlanan yapılardır. C/C++ gibi dillerde while, do while ve for döngüleri varken, C# programlama dilinde ek olarak
koleksiyonlar ve diziler içerisinde yani çoklu veri barındıran yapılar üzerinde başlangıçtan sonuna kadar gezinebildiğimiz foreach döngüsü vardır.
    #while Döngüsü
        while Türkçe anlamıyla "iken" döngüsü bir şart sağlanıyor ise döngü parantezleri arasına girer işlem bloğunu tamamlar ve o şartı tekrar kontrol eder. Bu şart sağlandıkça
    o işlem bloğu tekrar tekrar devam etmektedir.
    #do-while Döngüsü
        while döngüsünden farklı olarak program akışı ilk olarak do ifadesiyle karşılaşır ve işlem bloğunu döngüyle karşılaştığı anda şarta bakmaksızın bir kez çalıştırır. Daha
    sonra şarta bakılarak eğer işlem geçeriyse while gibi tekrar tekrar bu kod bloğu şart sağlanmayana dek çalıştırılır.
    #for Döngüsü
        for Türkçe anlamıyla "için" döngüsü bir değişken üzerinde aritmetiksel işlem yaparak kontrol sağlamak için kullanılır. Bu yüzden diziler için kullanılması diğer döngülere
    nazaran daha anlamlıdır. Belirli bir değişkeni belirli bir şarta göre belirli bir aritmetik işleme tabi tutarak çalışır.
    #foreach Döngüsü
        Bazen boyutu belirli olmayan koleksiyonlar veya diziler ile karşılaşabiliriz. Veya bu dizilerin boyutu her boyuta göre değişken olabilir. Sıra ile bu koleksiyon üzerinde
    gezinmek for ile daha zor iken foreach ile hiç düşünmeden gerçekleştirebiliriz.
*/
#endregion

#region ÖDEVLER
/*
    1-)Standart JIT Compiler, EconoJIT Compiler, PreJIT Compiler, Multicore Background JUT Compiler, RyuJIT Compiler ve Rosyln Compiler çeşitlerini Araştırıp/Yaz/Anlat.
    2-)XAML (Extensible Application Markup Language) Nedir? Araştırıp/Yaz/Anlat.
    3-).NET Framework, .NET Core ve Xamarin üzerinden geliştirilebilecek şablonları yani App Models. Araştırıp/Yaz/Anlat.
    4-)CTRL+W veya ALT+F4 tuş kombinlerine basılınca 42 koduyla programdan çıkış yapan, aksi halde basılan tuşu algılayarak ekrana yazan, CTRL+C kombininde ise Hello World!
    çıktısını veren programı yazınız.
    5-)Object ile dynamic arasındaki farkları Araştırıp/Yaz/Anlat. Neden dynamic'e ihtiyaç duyuldu? Ne işe yarar?
    6-)CTS vs CLS Araştırıp/Yaz/Anlat.
    7-)Sturct Örnekleri kısmı için nesne üretip değer atıp okuyunuz. Tüm structlar için.
    8-)Enum için Flags attribute'ünü Araştırıp/Yaz/Anlat/Örnek Yap.
 */
#endregion

namespace Ders_1_
{
    #region Struct Örnekleri
    struct SampleStruct
    {
        public string Information { get; } //3.Bilgilendirmeyi ekrana yazdır. //6.bilgilendirmeyi ekrana yazdır.
        public int Field;//2.Consturtor üzerinden verilen başlangıç değerini ekrana yazdır. //7.Değeri ekrana yazdır.
        private string safeVariable;
        public string Property //1.Değer ata //4.Tekrar değer ata. //5.Değeri ekrana yazdır..
        {
            get { return safeVariable; }
            set
            {
                if (safeVariable == null)
                    safeVariable = value;
            }
        }
        public SampleStruct(int startValue)
        {
            safeVariable = null;
            if (startValue != 404)
                Field = startValue;
            else
                Field = 0;
            Information = "Code 404 is mean 'Assignment Failed!' And Code 0 is mean 'Cant Set Start Value!'";
        }
    }
    readonly struct SampleReadonlyStruct
    {
        readonly private int CantChange { get;}
        public int Property { get; }
        readonly public string Field;
        public SampleReadonlyStruct(int Property, string Field)
        {
            this.Property = Property;
            this.Field = Field;
            CantChange = 4;
        }
    }
    ref struct SampleReferanceStruct
    {
        public int Field;
        public string Property { get; set; }
    }
    #endregion

    #region Enum Örneği
    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion
    class Program
    {
        #region ref&out
        static void RefAndOut()
        {
            string val = "Value of not changed variable";
            Console.WriteLine(val);
            ChangeWithRef(ref val);
            Console.WriteLine(val);
            ChangeWithOut(out val);
            Console.WriteLine(val);
            ref string refVal = ref val;
            /*out string outVal = out val; => Yapılamaz.*/
            Console.WriteLine("refVal's Value = {0}", refVal);
            refVal = "Changed With refVal";
            Console.WriteLine("val's Value = {0}", val);
            string emptyVal;
            ChangeWithOut(out emptyVal);
            Console.WriteLine("emptyVal's Value = {0}", emptyVal);
            /*ChangeWithRef(ref emptyVal); => Yapılamaz.*/
            /*ChangeWithOut(ref val); veya ChangeWithRef(out val) şeklinde ref paremetresine out, out parametresine ref gönderilemez.*/

        }
        static void ChangeWithRef(ref string inp)
        {
            inp = "Change With Ref Completed!";
        }
        static void ChangeWithOut(out string inp)
        {
            inp = "Change With Out Completed!";
        }
        #endregion
        static void Main(string[] args)
        {
            #region Değişkenlerin CTS Tipleri ve Max/Min Değerleri
            /*
            Console.WriteLine("BYTE Max Value: {0}, Min Value: {1} - CTS Type [{2}]", byte.MaxValue, byte.MinValue, typeof(byte));
            Console.WriteLine("SBYTE Max Value: {0}, Min Value: {1} - CTS Type [{2}]", sbyte.MaxValue, sbyte.MinValue, typeof(sbyte));
            Console.WriteLine("SHORT Max Value: {0}, Min Value: {1} - CTS Type [{2}]", short.MaxValue, short.MinValue, typeof(short));
            Console.WriteLine("USHORT Max Value: {0}, Min Value: {1} - CTS Type [{2}]", ushort.MaxValue, ushort.MinValue, typeof(ushort));
            Console.WriteLine("INT Max Value: {0}, Min Value: {1} - CTS Type [{2}]", int.MaxValue, int.MinValue, typeof(int));
            Console.WriteLine("UINT Max Value: {0}, Min Value: {1} - CTS Type [{2}]", uint.MaxValue, uint.MinValue, typeof(uint));
            Console.WriteLine("LONG Max Value: {0}, Min Value: {1} - CTS Type [{2}]", long.MaxValue, long.MinValue, typeof(long));
            Console.WriteLine("ULONG Max Value: {0}, Min Value: {1} - CTS Type [{2}]", ulong.MaxValue, ulong.MinValue, typeof(ulong));
            Console.WriteLine("FLOAT Max Value: {0}, Min Value: {1} - CTS Type [{2}]", float.MaxValue, float.MinValue, typeof(float));
            Console.WriteLine("DOUBLE Max Value: {0}, Min Value: {1} - CTS Type [{2}]", double.MaxValue, double.MinValue, typeof(double));
            Console.WriteLine("DECIMAL Max Value: {0}, Min Value: {1} - CTS Type [{2}]", decimal.MaxValue, decimal.MinValue, typeof(decimal));
            Console.WriteLine("BOOL Max Value: {0}, Min Value: {1} - CTS Type [{2}]", "True", "False", typeof(bool));
            Console.WriteLine("CHAR Max Value: {0}, Min Value: {1} - CTS Type [{2}]", char.MaxValue, char.MinValue, typeof(char));
            Console.WriteLine("STRING Max Value: {0}, Min Value: {1} - CTS Type [{2}]", "NULL", "NULL", typeof(string));
            Console.WriteLine("OBJECT Max Value: {0}, Min Value: {1} - CTS Type [{2}]", "NULL", "NULL", typeof(object));
            Console.WriteLine("DYNAMIC Max Value: {0}, Min Value: {1} - CTS Type [{2}]", "NULL", "NULL", "System.Dynamic");
            */
            #endregion

            #region TryParse Method Örneği
            /*int a = 5;
            string b = "442,i";
            if (int.TryParse(b, out a))
                Console.WriteLine(a);
            else
                Console.WriteLine("Başarısız! {0}", a);*/
            #endregion

            //RefAndOut(); //ref ve out anahtar kelimeleri örneğinin başlangıç methodunu çağırma.

        }
    }
}
