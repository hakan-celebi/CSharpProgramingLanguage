using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System;
using System.IO;

#region Regular Expressions - Düzenli İfadeler

#region Tanım
/*
    Bir string veya string dizisi içerisinden 'çeşitli ifade kalıplarını kullanarak' yeni bir string veya string dizileri elde etmek
için kullanılırlar. Örneğin; bir yazı içerisindeki web adreslerini elde etmek ya da web sayfasındaki mail adreslerini elde etmek
için kullanılırlar. 
    Düzenli ifadeleri kullanabilmek için System.Text.RegularExpressions sınıfını projemize dahil etmek gerekmektedir.
    Düzenli ifadeler ile birlikte kullanılan ve arama, karşılaştırma ve değiştirme işlemlerinde kullanılan karakterler mevcuttur.
Bunlara "metacharacter" ismi verilir. Metacharacter, "Special Characters" ve "Non-Printable Characters" olmak üzre ikiye ayrılır.
*/
#endregion

#region metacharacters

#region Special Characters - Özel Karakterler
/*
    #($): Bir metnin bitiş pozisyonunu belirler. Eğer multiline özelliği aktif ise satırın bitiş pozisyonunu ifade eder.
    #(()): Bir alt ifadenin başlangıç ve bitişini ifade eder.
    #(*): Kendisinden önce belirtilen karakterin belirtilen metin içerisinde ya hiç olmadığını ya da bir veya birden fazla olduğunu
        ifade eder.
    #(+): Kendisinden önce belirtilen karakterin veya alt ifadenin bir veya daha fazla tekrarlanabileceğini belirtir. 
    #(.): Yeni satır yani \n haricindeki herhangi bir karakteri belirtir.
    #([]): Bir aralığın başlangıcını belirtir.
    #(?): Kendisinden önce belirtilen karakterin belirtilen metin içerisinde ya hiç olmadığını ya da mevcut olduğunu belirtir.
    #(\): Kendisinden sonra belirtilen karakterin arama kriterini oluşturan ifade içerisine dahil edilmesini sağlar.
    #(/): Bir Düzenli ifadenin başlangıcını veya bitişini belirtir.
    #(^): Karşılaştırma işleminin başlayacağı ilk karakteri belirtir.
    #({}): Kendisinden önce gelen karakterin ne kadar tekrar edilebileceğini belirtir.
    #(|): İki eleman narasındaki seçimi belirtir.
*/
#endregion

#region Non-Printable Characters - Yazdırılamayan Karakterler
/*
    #(\cx): Ctrl tuşu ile birlikte kullanılan karakterleri belirtir. Örneğin; \cv ifadesi Ctrl+V tuşlarını belirtir.
    #(\n): New Line ifadesinin baş harfi yani yeni satır anlamına gelmektedir.
    #(\r): Row kelimesinden türetilmiş satırbaşı anlamına gelir.
    #(\s): Space kelimesinden türetilmiş boşluk karakterini belirtir.
    #(\S): Boşluk olmayan karakterleri belirtir.
    #(\t): Tab anlamına gelir.
*/
#endregion

#endregion

#region Regex Class & Methods

#region Tanım
/*
    Regex sınıfı arama, karşılaştırma ve değiştirme işlemleri için kullanabileceğimiz metodlara sahip olan bir sınıftır. 
*/
#endregion

#region Methods

#region bool Regex.IsMatch(string input, string pattern, RegexOptions options)
/*
    Adından da anlaşılacağı üzere eşleştimi anlamına gelir. Input paramateresi üzerinde işlem yapılacak olan metini, Pattern
parametresi arama işleminde kullanılacak kalıp ve options parametresi bir enum olduğu için 11 adet değer alabilmektedir.
    #RegexOptions Enumerator       
        # None = Herhangi bir seçenek uygulanmaz.
        # IgnoreCase = Case Sensivity uygulanmaz.
        # Multiline = Birden fazla satır kullanılacağını belirtir. ^ ve $ karakterinin kulanış biçimini, satır başlangıcı ve bitişi
        şeklinde değiştirir.
        # ExplicitCapture = Aranacak metin içerisindeki aranacak bölümlerin (?<isim>..) biçiminde isimlendirildiğini belirtir. 
        # Compiled = Düzenli ifadenin bir assembly içerisine derlendiğini belirtir. Bu seçenek çalışma hızını arttırır, ancak
        başlangıç zamanını geciktirir. Bu değer, CompileToAssembly metodu çağrıldığı zaman kullanılmalıdır.
        # Singleline = Bir satır üzerinde işlem yapılacağını belirtir. Nokta karakterinin kulanılış biçimini değiştirerek herhangi
        bir karakter yerine geçebilir.
        # IgnorePatternWhitespace = Pattern içerisindeki boşlukların yok sayılmasını sağlar. # karakteri kullanılarak açıklamalar 
        eklenebilir.
        # RightToLeft = Arama işlemini sağdan sola doğru yapar.
        # ECMAScript = ECMAScript uyumluluğuınu sağlar. IgnoreCase, Multiline ve Compiled değerleri ile birlikte kullanılır.
        # CultureInvariant = Kültürel farklılıkların göz ardı edilmesini sağlar.
#-> Follow to Example Of IsMatch Method Region
*/
#endregion

#region Match Regex.Match(string input, string pattern, RegexOptions options)
/*
    IsMatch methodundan farkı; IsMatch methodu eğer arama kriteri sağlanıyorsa true dönderiyordu, bunda ise eğer arama kriteri
sağlanıyorsa geriye aranan değer dönderiliyor.
*/
#endregion

#region MatchCollection Regex.Matches(string input, string pattern, RegexOptions options)
/*
    Match methodundan tek farkı; Bulunan tek bir sonucu değil de arama kriterine uyan tüm sonuçları geriye dönderiyor.
#-> Follow to Example Of Matches Method Region
*/
#endregion

#region Extra Replace & Split Methods
/*
    Ayrıca belirtilen metin içerisindeki bir string'i Replace methodu ile değiştirebiliriz. Split metodu ile birlikte string'i
bölme işlemine de tabi tutabiliriz.
*/
#endregion

#endregion

#endregion

#endregion

namespace Ders_5_
{
    public partial class RegularExpression : Form
    {
        public RegularExpression()
        {
            InitializeComponent();
        }

        #region Example Of IsMatch
        private void btnCheckItIsMatchMethod_Click(object sender, System.EventArgs e)
        {
            /* Pattern Açıklama: İlk olarak gelen ^ karakteri karşılaştırma işleminin başlayacağı ilk karakteri belirtir demiştik.
            Daha sonra gelen \ karakter ise kaçış karakteri olarak kullanılmıştır. Daha sonra ise boşluk karakteri gelir. * karakteri
            ise kendisinden önce gelen karakterin metin içerisinde ya hiç olmadığını ya da bir veya birden fazla olduğunu belirtiyor.
            Daha sonra gelen $ karakteri ise sona gelip gelmediğimizi belirtiyor. Yani ^ karakterinden sonra \\s space karakteri
            geldiği için TextBox içeriği pattern'e göre boşluk karakteri ile başlamak zorunda oluyor. Space karakterinden sonra gelen
            * karakteri ile birlikte space karakteri ya hiç olmayacak, ya bir adet ya da birden çok olacak anlamına geliyor. Daha
            sonra gelen $ karakteri ile birlikte satır sonuna gelindiğini belirtiyor. Böylece satır sonuna kadar TextBox'ın boş
            olduğu sağlanıyor.*/
            if (Regex.IsMatch(txtExampleForIsMatchMethod.Text, "^\\s*$"))
                MessageBox.Show("TextBox is Empty!");
            else
                MessageBox.Show("TextBox is Not Empty!");
        }

        #endregion

        #region Get E-Mail Address From Web Address
        private void btnListMatchesMethodResults_Click(object sender, System.EventArgs e)
        {
            if (Regex.IsMatch(txtWebAddress.Text, "^\\s*$"))
                MessageBox.Show("TextBox is Empty!");
            else
            {
                lblProcessState.Text = "Process State: Connecting...";
                WebResponse resp = null;
                try
                {
                    WebRequest webReq = WebRequest.Create(txtWebAddress.Text);
                    resp = webReq.GetResponse();
                    lblProcessState.Text = "Process State: Connected!";
                    Stream str = resp.GetResponseStream();
                    StreamReader reader = new StreamReader(str);
                    string source = reader.ReadToEnd();
                    Regex mailPattern = 
                        new Regex(@"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})", RegexOptions.IgnoreCase);
                    listBoxReturnValueOfMatchesMethod.Items.Clear();
                    foreach (Match item in mailPattern.Matches(source))
                        listBoxReturnValueOfMatchesMethod.Items.Add(item.Value);
                    lblProcessState.Text = "Process State: Found e-mails listed!";
                }
                catch (Exception ex)
                {
                    lblProcessState.Text = "Process State: Can't Connected!";
                }
            } 
        }
        #endregion
    }
}