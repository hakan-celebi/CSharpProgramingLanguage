using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

#region What is The .NET Platform - .NET Platform Nedir?

#region Description - Tanım
/*
	.NET Platform ilk olarak .NET Framework olarak 13.02.2002 tarihinde piyasaya sürülmüştür. İlk sürümden itibaren günümüze kadar 13 civarı sürüm ile 
.NET Framework 4.7 sürümüne kadar gelmiştir. Bu yapı ile birlikte bir çok app model (WPF, Windows Forms, ASP.NET vb.) geliştirilebilmektedir. Microsoft
bu yapı ile birlikte ortak dil standartlarını oluşturdu. CLR (Common Language Runtime - Ortak Dil Çalışması) ismindeki yapı ile 
CTS (Common Type System - Ortak Tip Sistemi) ve CLS (Common Language System - Ortak Dil Sistemi) standartlarına uygun olarak programlama dili fark
etmeksizin (VB.NET, C#, J# vb.) .NET dillerini MSIL (Microsoft Intermediate Language - Microsoft Ara Dili) denilen makine diline yakın bir dile çevirerek
ortak bir dil elde edilmiş oldu. Bu MSIL daha sonra çeşitli (Bellek Maliyetine Bağlı Olarak) JIT Compilers ile birlikte Assembly çevrilerek 
yürütülmektedir. Günümüzde .NET Framework, .NET Core ve Xamarin olmak üzere 3 adet çatı vardır.
*/
#endregion

#region .NET Framework
/*
	Microsoft tarafından geliştirilen ilk framework olmak üzere; Windows cihazlar için WPF, ASP.NET(Web Application), Windows Forms vb. uygulamalar
geliştirilebilmektedir. Günümüzde en stabil sürümü 4.7 olarak 2017 yılında çıkmıştır. Başlarda Base Class Library kütüphanesini kullansada günümüzde
.NET Standart Library kütüphanesini kullanmaktadır. Bunun sebebi .NET Core ve Xamarin ile ortak bir kütüphane yapısı oluşturmaktır.
*/
#endregion

#region .NET Core
/*
	Microsoft tarafından 27.06.2016 tarihinde 1.0 versiyon olarak piyasaya sunulmuştur. Cross-Platform ve Open Source özellikleri ile tercih edilebilir.
Core Library kütüphanesini kullansada günümüzde .NET Standart Library kütüphanesini kullanmaktadır. En güncel versiyonu .NET Core 3.1 olmaktadır.
.NET Core ile ASP.NET, WPF, Windows Forms vb. .NET Framework App Models geliştirilebilmektedir.
*/
#endregion

#region Xamarin
/*
	Xamarin Microsoft'a ait bir şirkettir. Bu şirket Xamarin.Android ve Xamarin.IOS'u Mayıs 2011'de geliştirilmiş, 24.02.2016 tarihinde Microsoft
tarafından satın satın alınmıştır. Xamarin IOS, OS X ve Android platformları için uygulama geliştirilebilmektedir. Mono Class Library kullanırken 
günümüzde .NET Standart Library dahil edilmiştir.
*/
#endregion

#region New .NET 5 - Yeni .NET 5
/*
	.NET Core 3.1 ve .NET Framework 4.x sürümlerinden sonra ortak bir platform çatısı oluşturmak için .NET 5 sürümü çıkartılmıştır. Bundan sonra .NET Core
yerine .NET olarak adlandırılmıştır. Web forms yerine artık ASP.NET Core Blazor veya Razor Pages kullanılacak, Windows Workflow yerine de 
Open-Source CoreWF veya Elsa-Workflows kullanılacaktır.
*/
#endregion

#endregion

#region Client Side Programing Languages for Web App - Web Uygulamaları için İstemci Tarafı Programlama Dilleri

#region Description - Tanım
/*
	Bildiğimiz üzere front-end programlama için HTML(Hyper Text Markup Language) ile birlikte web sayfamızın iskeletini oluşturur, 
CSS (Cascading Style Sheets) kullanarak da HTML ile oluşturduğumuz nesneleri biçimlendiririz. Günümüzde CSS 3 ile daha fazla biçimlendirme yapılabilirken
Bootstrap framework'ü ile animasyonlar ve biçimlendirmede kolaylıklar sağlanmıştır. Javascript programlama dili de başlangıçta sadece browser üzerinde
çalıştırılabilen yani Client Side programlama dili iken günümüzde Node.js gibi frameworkler ile birlikte Server Side programlama da yapabilmekteyiz.
*/
#endregion

#region Bootstrap
/*
	2011 yılında geliştirilmiş HTML, CSS ve Javascript tabanlı bir framework'dür. Güncel versiyonu Bootstrap 4 olsada stabil sürümü Bootsrap 3'dür. 
Bootsrap First Mobile felsefesi ile çalışan yani Responsive tasarım temelli bir framework'dür.
*/
#endregion

#region JavaScript
/*
	Aralık 1995 tariginde Netscape firması tarafından piyasaya sürülen Javascript ilk olarak LiveScript olarak isimlendirildi. Netscape Navigator 2.0 
ile birlikte piyasaya sürülen LiveScript, Netscape2.0 Beta3 ile ismi Javascript olarak değiştirildi. Çeşitli tartışmalar, Browser savaşlarının ardından 
1996 yılının Kasım ayında Ecma International firmasına standartlaştırılması amacıyla Netscape tarafından başvuru yapılmış ve ECMAScript olarak
isimlendirilmiştir. Günümüzde çeşitli framework'ler ile Mobile ve Server tarafında da etkin olarak kullanılmaktadır.
*/
#endregion

#region TypeScript
/*
	Microsoft tarafından geliştirilmiş bu dil Compiler ile JavaScript diline çevrilmektedir. Bu dil ve benzeri olarak JavaScript diline Compile edilen
dillerin geliştirilme amacı JavaScript'in bazı alanlarda yetersiz kalmasıdır. Örneğin; tip alanlarında JavaScript yetersiz kalabilmektedir.
*/
#endregion

#endregion

#region ASP.NET App Model - ASP.NET Uygulama Modeli

#region What is ASP? - ASP Nedir?
/*
	Microsoft tarafından Aralık 1996 tarihinde piyasa sürülmüş olan ASP(Active Server Pages - Aktif Sunucu Sayfaları), Microsoft'un ilk dinamik web sayfaları
için geliştirmiş olduğu teknolojidir. Microsoft daha sonra .NET Framework'ü piyasaya sürmesinden sonra .NET Framework ile ASP teknolojisini birleştirerek
web uygulamaları için ASP.NET teknolojisini duyurmuştur. ASP, ASP.NET Web Forms'da olduğu gibi <% ASP Controls %> HTML dökümanı içerisine ASP kontrollerini
ekleyerek yazılarak kullanılır. BehindCode özelliği ASP içerisinde yoktur.
*/
#endregion

#region Description - Tanım
/*
	ASP.NET .NET Platform'unda yer alan Web App geliştirmek için kullanılan App Model'dir. .NET Framework ve .NET Core ile geliştirilebilmektedir.
*/
#endregion

#region ASP.NET Framework
/*
	.NET Framework ile geliştirilen Web App ismidir. Web Forms ile birlikte geliştirilebilmektedir. ASP.NET Framework kontrollerini HTML içerisine dahil
ederek sunucu tarafında yapılan işlemleri yönetebilmektedir. Ayrıca ASP.NET MVC de kullanılabilmektedir. (Razor Pages)
*/
#endregion

#region ASP.NET Core

#region Description - Tanım
/*
	Cross-Platform ve Open-Source olarak Web App geliştirilebilmektedir. ASP.NET Core ile birlikte Blazor App ve Razor Pages olmak üzere iki yöntem ile
birlikte Web App geliştirilebilir. Web Forms ASP.NET Core içerisnde yer almamaktadır.
*/
#endregion

#region Blazor
/*
	Microsoft tarafından 2018 yılında geliştirilmiş Blazor'un en önemli özelliği Client-Side için JavaScript yerine C# kullanılmasıdır. Blazor,
ASP.NET Core 3.0 ile sağlanan Angular, React ve diğer JavaScript kütüphanelerine rakip olarak çıkarılmıştır. Blazor ile Client-Side programlama için
WebAssembly kullanılır. WebAssembly JavaScript'e rakiptir. C# komutlarını dönüştürerek Client-Side yazılım geliştirilebilir.
*/
#endregion

#region Razor Pages
/*
	Web Forms'un yerini aratmaksızın aksine daha kolay biçimde Web App geliştirmek için kullanılan yapıdır. JavaScript ve Framework'leri kolaylıkla dahil
edilebilmektedir. ASP.NET MVC pattern için geliştirilmiştir. Ayrıca ASP.NET Framework ile birlikte de kullanılabilir.
*/
#endregion

#endregion

#region ASP.NET MVC (Model-View-Controller)

#region Description - Tanım
/*
	MVC, yazılım geliştirmekte kullanılan Mimari Desendir(Architectural Pattern). Büyük çaplı projelerde kullanılan bu desen sayesinde proje katmanlarına
ayrılarak, hem geliştirilmesi hem de yönetilmesinin kolaylaştırılması amaçlanmıştır. MVC Pattern, ASP.NET ile ortaya çıkmamıştır. 1979 yılında 
Trygve Reenskaug tarafından oluşturulmuş ve o günden beri Java ve PHP gibi bir çok dilde kullanılmıştır. Microsoft, MVC'yi ASP.NET'e 2009 yılından beri
entegre etmiştir.
*/
#endregion

#region Model
/*
	Model, proje içerisinde kullanılacak veri türlerini tanımlayacağımız bölümdür. Örneğin; bir ürün için Class oluşturursak bu Class model içerisinde
yer almalıdır.
*/
#endregion

#region View
/*
	View, projede kullanıcının gördüğü ve kullandığı arayüzün bulunduğu bölümdür. Sayfa görünümleri yani kullanıcıya iletilecek dosyalar burada yer alır.
View içerisinde Client-Side ve Server-Side kodlama yapılabilmektedir.
*/
#endregion

#region Controller
/*
	Controller, MVC pattern'inin merkezi olarak düşünülebilir. Model ve View arasında iletişimi sağlar ve kullanıcı isteklerini yanıtlar. 
Örneğin www.xxx.com sitesine istekte bulunduğumuz zaman ilgili controller isteği karşılar ve yanıtı verir. Sadece Server-Side işlemler Controller'da 
gerçekleşir.
*/
#endregion

#endregion

#region What is SPA(Single Page Application)? - SPA(Tek Sayfa Uygulaması) Nedir?
/*
	Farkında olmaksızın karşımıza çıkan uygulamalardır. Kullanıcı deneyimini kesintiye uğratmaksızın tek sayfa içerisindeki parçaları dinamik olarak
değiştirerek kullanılan Web Apps'dir. Örneğin; Netflix, Google Maps, Gmail SPA Web Apps'dir. Ajax JavaScript framework'ü ile birlikte veri sunucudan
getirilerek tarayıcı tarafından işlenir. Bu sayede tekrardan HTML kodları tekrar görüntülenmesi yerine gelen veriler ile sayfa güncellenmektedir. Bu da bize
ciddi bir performans artışı olarak geri döner.
*/
#endregion

#endregion

#region Extra: ADO, ADO.NET, Entity Framework

#region What is ADO? - ADO Nedir?
/*
	Microsoft, Ekim 1996'da ADO'yu tanıttı ve veri kaynaklarına erişim için yazılım dünyasında konumlandırdı. ADO(ActiveX Data Object), 
RDO(Remote Data Objects - Veri Nesneleri Yönetimi) ve DAO(Data Access Objects - Veri Erişim Nesneleri) teknolojilerinin yerine getirdi. Özetlemek gerekirse
kullanıcıların database işlemleri yapabilmesini sağlayan bir teknolojidir.
*/
#endregion

#region What is ADO.NET? - ADO.NET Nedir?
/*
	ASP teknolojisinde de olduğu gibi Microsfot ADO teknolojisini .NET Platformunun gücünü kullanarak .NET ile birleştirdi. Ancak ADO teknolojisi ADO.NET
olarak o kadar güncellendi ki ADO.NET yeni bir ürün olarak kabul edilebilir.
*/
#endregion

#region What is Entity Framework? - Entity Framework Nedir?
/*
	Entity Framework, ADO.NET üzerinde veri odaklı yazılım geliştirmeyi destekleyen bir teknolojidir. 11 Ağustos 2008'de Microsoft tarafından EFv1 sürümü
ile tanıtılmıştır. Entity Framwork ORM(Object Relation Mapping - Nesne İlişkisel Yönetimi) araçlarından biridir. ORM nedir dersek ORM; İlişkisel Database
ile OOP(Object Oriented Programing - Nesneye Dayalı Programlama) modeli arasında bir köprü görevi gören araçtır. Bu köprü, ilişkisel database üzerindeki
bilgilerimizi yönetmek için nesne modellerimizi kullandığımız bir yapıdır. Kısaca Entity Framework, database üzerinde nesnelerimizi bağlayan ve bizim için 
veri alışverişi yapan bir Framework'dür. Bir çok  yöntem ile birlikte Entity Framework kullanılarak database OOP modeli üzerinde
kullanılabilir/oluşturulabilir. İlerleye konularda daha detaylı görülecektir.
*/
#endregion

#endregion

#region ASP.NET Framework MVC Introduction - ASP.NET Framework MVC Giriş

#region Adding New Controller - Yeni Kontrol Ekleme

#region Method Description - Yöntem Tanımı
/*
	Solution Explorer tabs içerisinden Controllers folder'a sağ tıkladıktan sonra Add seçeneğini seçeneği üzerinden Controller'a tıklayarak yeni bir
Controller eklenebilmektedir. Controller ekleme ekranında Controller türlerini görmekteyiz. Bunların bir kısmı MVC 5 Controller iken diğer kısmı Web API 2
Controller'larıdır.;
*/
#endregion

#region Controller Types - Controller Türleri

#region MVC 5 Controller - Empty
/*
	Boş bir MVC5 Controller'dır. Controller class'ını extend eder ve içinde sadece Index Action(Daha ileride görülecektir) vardır. 
*/
#endregion

#region MVC 5 Controller with Read/Write Actions
/*
	 FormCollection modeli üzerinden CRUD(Create, Read-Details, Update-Edit, Delete işlemlerine kısaca CRUD denmektedir) işlemlerinin metodları hazır olan
bir Controller Class oluşturur.
*/
#endregion

#region MVC 5 Controller with Views, Using Entity Framework
/*
	Önceden tanımlanan bir modelin Entity Framework üzerinden database işlemlerini yapmasını sağlayan Controller'ı ve View'ları oluşturur. 
*/
#endregion

#region Web API 2 Controller - Empty
/*
	Boş bir Web API 2 Controller'ı oluşturur. ApiController Class'ını extend eder. 
*/
#endregion

#region Web API 2 Controller with Read/Write Actions
/*
	Get, Post, Put ve Delete işlemlerinin metodu hazır olan bir ApiController Class oluşturur. 
*/
#endregion

#region Web API 2 Controller with Actions, Using Entity Framework
/*
	Önceden tanımlanan bir modelin Entity Framework üzerinden database işlemleri yapmasını sağlayan Controller'ı ve Views'ı oluşturur. 
*/
#endregion

#region Web API 2 ODAta Controller with Actions, Using Entity Framework
/*
	Önceden tanımlanan bir modelin Entity Framework üzerinden database işlemleri yapmasını sağlayan Odata Controller ve Views oluşturur. 
*/
#endregion

#endregion

#endregion

#region Adding New Model - Yeni Model Ekleme
/*
	Model eklemede bir numara yoktur. Solition Explorer tab içerisinden Models folder üzerine sağ tıkyalayarak sırasıyla Add->New Item->Class seçilerek
yeni bir Class ekleyerek yapılır.
*/
#endregion

#region Adding New View - Yeni Görünüm Ekleme
/*
	Yeni bir Controller ekledikten sonra(MVC 5 Controller - Empty için) varsayılan olarak ActionResult dönüş tipinde Index Action oluştuğunu görürüz.
Oluşan bu Index Action'a sağ tıkladığımız zaman önümüze Add View seçeneği görünür. Bu seçenek tıklandıktan sonra View ismi ve eğer istenirse Template
seçilebilmektedir. Okay butonuna basıldıktan sonra eğer Controller, xxxController olarak isimlendirilmiş ise Views folder altında xxx olarak yeni bir
folder otomatik olarak oluşturur ve bu folder altına Index.cshtml View eklenmiş olur.
*/
#endregion

#region ASP.NET MVC Codding Methods - ASP.NET MVC Kodlama Yöntemleri

#region Description - Tanım
/*
	View Engine, ASP.NET ile yazılan kodlar sonucunda oluşan çıktıyı HTML dökümanı halinde render etmek için kullanılan teknolojidir. ASP.NET MVC
içerisinde Razor, Web Form, Spark ve Nhaml olmak üzere 4 adet View Engine vardır. Biz View Engine için Razor View Engine kullanacağız.
*/
#endregion

#region Razor View Engine
/*
	Razor, ASP.NET MVC3 ile birlikta yazılım dünyasına katılan ASP.NET Web Form'a göre daha kolay kullanılabilir bir yapıdır. Razor kodlaması, View'lar
içerisine yazılmaktadır.
*/
#endregion

#region @ Operator - @ Operatörü
/*
	Razor View Engine'in yazılım kurallarının temelinde @ operatörü bulunudr. Web Forms da bu operatör yerine <% %> operatörleri kullanılmaktadır.
@ Operatörü @{ C# Code } scopeları içerisine C# kodları yazılarak kullanılmaktadır. Ayrıca sadece Razor'a özel @* *@ şeklinde yorum satırı
belirtilebilmektedir.
*/
#endregion

#endregion

#region Link Process - Link İşlemleri
/*
	Bir View'dan başka bir View'a link vermek için @Html.ActionLink("Bu bir link!", "Contact", "Home"); ve 
<a href="@Url.Action("About", "Home")">This is a Link!</a> yöntemleri kullanılabilir. Ayrıca <a href="../Home/About">content</a> yöntemi ile de link
verilebilmektedir.
*/
#endregion

#region Post Process & IsPost Property - Post İşlemi ve IsPost Özelliği

#region Description - Tanım
/*
	Postback, ASP.NET MVC sayfalarında bir clickeble control'e tıklandığında aynı sayfanın sunucu tarafında işlem yapıp yeniden açılma işlemidir.
Ayrıca bir sayfanın postback olup olmadığını IsPost property'si ile kontrol ederiz.
*/
#endregion

#endregion

#region HTTP Utility Changing HTML Character Coding - HTTP Utility HTML Karakter Kodlaması Değiştirme

#region Description - Tanım
/*
	Server tarafından işlenen bazı HTML tag'leri karakter kodlamasından ötürü değişmekte veya hata verebilmektedir. Bu yüzden HttpUtility static Class'ın
HtmlEncode ve HtmlDecode metodları ile tag'i şifreleyip kullanacağımız zaman çözerek hatayı engelleriz.
*/
#endregion

#region HttpUtility.HtmlEncode(string value)
/*
	İçerisine parametre olarak gelen HTML Tag'inin </> gibi karakterlerini şifreleyerek geriye dönderir. 
*/
#endregion

#region HttpUtility.HtmlDecode(string value)
/*
	İçerisine parametre olarak gelen ve </> karakterleri Encode işlemine tabi tutulmuş veriyi </> karakterlerine tekrar çevirerek geriye dönderir. 
*/
#endregion

#endregion

#endregion

#region View

#region Description - Tanım
/*
	View, Web App'in kullanıcıya gösterilen tarafını oluşturmaktadır. Yani View genel anlamıyla Client-Side programlama için kullanılmaktadır. Kullanıcı
sadece View'ı görüntüleyebilir/erişebilir. Dolayısıyla kullanıcı istekleri View üzerinden Controller'a iletilir ve Server-Side işlemler Controller
tarafından işlendikten sonra View olarak geri iletilir.
*/
#endregion

#region View Types & Folders - View Tipleri & Dosyaları

#region Description - Tanım
/*
	Yeni bir ASP.NET Framework MVC projesi oluşturduğumuz zaman varsayılan olarak Views folder altında Home, Account ve Shared isimli folders gelir.
*/
#endregion

#region Account Folder
/*
	Kullanıcı işlemlerinin yönetildiği AccountController'ın View'larının yer aldığı izindir. İçerisinde View ve Partial View'lar kullanılmıştır.
*/
#endregion

#region Home Folder
/*
	HomeController içerisindeki Action'ların View'larının bulunduğu folder'dır. İçerisinde her Action için bir adet View bulunur. 
*/
#endregion

#region Shared Folder
/*
	İçerisinde diğer tüm View'ların ortak olarak kullandığı View dosyaları vardır. 
*/
#endregion

#region _ViewStart.cshtml
/*
	Views folder altında bulununan _ViewStart.cshtml, kullanılacak layout ile ilgili tanımlamaların yapıldığı View'dir. 
*/
#endregion

#endregion

#endregion

#region Model

#region Description - Tanım
/*
	Model, MVC'de projede kullanılan veri türlerine verilen isimdir. Örneğin; Product, Order vb. Class yapıları model'dir. Projede tutulan tüm veri türleri
için model oluşturulmalıdır.
*/
#endregion

#region Model Attributes - Model Nitelikleri

#region Description - Tanım
/*
	Model oluştururken model sınıfının property'lerine attribute ekleyebiliriz. Bu eklediğimiz attribute'ler sayesinde model ile alacağımız verilerin
kontrolleri sağlanmış olur.
*/
#endregion

#region Required Control - Zorunluluk Kontrolü
/*
	Required Control, [Required] şeklinde property'nin üzerine tanımlanır. Bu tanımlama ile birlikte Web Site içerisinde zorunlu alanlar doldurulmadan
geçilememektedir.
*/
#endregion

#endregion

#endregion

namespace Ders_1_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}