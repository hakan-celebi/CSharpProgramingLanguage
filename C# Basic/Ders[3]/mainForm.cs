using System;
using System.Diagnostics;
using System.Windows.Forms;

#region Formlar ve Dialog Pencereleri

#region Formlar ve Kontroller

#region Tanım
/*
    Windows Form Projemizi ilk olarak oluşturulduğumuzda Form1.cs, Frameworks ve Program.cs dosyaları oluşturulacaktır. Form1.cs Visual Studio
üzerinde design tab olarak açılacaktır. Kodlarımızı görmek için F7 tuşuna veya görünüm sekmesinden <> logosuna basarak kod kısmı açılabilmektedir.
Programımız ilk olarak Program.cs üzerinden başlar ve Application.Run(new FormName()); ile belirtilen form gösterilmeye başlanmaktadır. Formun
görünümü ve içerisindeki kontroller ise FormName.cs dosyamıza bağlı olan FormName.Designer.cs dosyamız üzerinden belirlenir. Kontroller özellikler
biçimler vb. bu dosyamızın içerisindedir. Ayrıca form nesnemize bağlı olan .resx (resource) dosyası içerisinde sabit değerler, resim video veya
biçimlendirmeler verilebilmektedir. Bu .resx dosyaları kullanıcı tarafından istenildiği kadar oluşturulabilir.
    Formumuza kontrolleri Araç Kutusu aracılığı ile ekleyebilir veya FormName.Designer.cs dosyası içerisinden kod ile de oluşturabiliriz.
Oluşturulan kontroller seçilerek Format(Biçim) seçeneklerinden konumlandırılabilmektedir.
*/
#endregion

#region Formlar Arası Geçiş
/*
    Bir form üzerinden diğer bir forma geçiş yapmak için o ram üzerinde o form nesnesi üretilmesi gereklidir. Bilindiği üzere tüm formlar
bir nesnedir. Üretilen bu nesne için eğer "Show" veya "ShowDialog" metodları kullanılır ise o form gösterilecektir. Üretilen formlar gizlenmiş
olarak gelecektir.
    # void Show(): Eğer üretilen yeni formu göstermek veya var olan formumuzu ekranda görünür hale getirmek için bu method kullanılırsa, 
    Show methodu altında bulunan diğer kodlar da yürütülecektir.
    # void ShowDialog(): Geriye DialogResult dönderen bu method, ekrana getirilen form kapatılmadığı sürece diğer formlara geçişi engellemektedir.
    # void Hide(): Belirtilen form'un visible özelliğini false yapar. Bu method yerine Visible property'sine false değeri atanabilmektedir.
    # void Dispose(): Belirtilen form'u tamamen bellekten temizlemek için kullanılır. Show methodu ile gösterilen formlar kapatıldıktan sonra
    otomatik olarak dispose yapılır fakat ShowDialog için kullanmak gereklidir.
*/
#endregion

#region Açılış ve Kapanış Sırasında Gerçekleşen Eventler
/*
    Bu eventleri ve sıralarını göstermek için Output ekranına Debug methodu ile yazı yazdırak görebilriz. Bu methodu kullanmak için System
namespace'i altında bulunan Diagnostic sınıfını dahil etmemiz gerekmektedir.
    # BindingContextChanged Evenet: Form görünür hale gelmeye başladığı zaman tetiklenir.
    # Load Event: Formun yüklenmesi olayıdır.
    # Activated Event: Form aktifleştirildiğinde gerçekleşir.
    # VisibleChanged Event Form görüntlendiğinde gerçekleşen olaydır.
    # Shown Event: Form'un görüntülenmesi bittiği zaman gerçekleşen olaydır.
    # Paint Event: Form ve Form üzerindeki kontroller ekrana çizilip yerleştirildiği zaman gerçekleşen olaydır.
    # FormClosing Event: Form kapatılırken gerçekleşen olaydır.
    # FormClosed Event: Form kapatıldığında gerçekleşen olaydır.
    # Deactivate Event: Form odağını kaybettiğinde ve artık aktif form olmadığında gerçekleşen olaydır.  
*/
#endregion

#endregion

#endregion

namespace Ders_3_
{
    public partial class mainForm : Form
    {
        private testForm frm;
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            frm = new testForm();
        }
        private void btnGoOtherForm_Click(object sender, EventArgs e)
        {
            if (frm.IsDisposed)
                frm = new testForm();
            this.Hide();
            frm.ShowDialog();
            frm.Dispose();
            if (frm.DialogResult == DialogResult.OK)
                this.Show();
            else
                this.Dispose();
        }
    }
}
