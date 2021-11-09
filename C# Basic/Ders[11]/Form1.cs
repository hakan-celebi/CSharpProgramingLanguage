using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Security.Permissions;

#region Database Operations - Veritabanı İşlemleri

#region Description - Açıklama
/*
    C# veritabanı üzerinde işlemler gerçekleştirmek için DAO, ADO, RDO, ODBC gibi teknolojilere sahiptir. Burada en çok kullanılan ADO.NET anlatılacaktır.
ADO.NET ile Access, SQL, Oracle, IBM, DB2 gibi çeşitli veritabanları üzerinde; Insert, Update, Delete, Select gibi işlemler kolaylıkla gerçekleştirilir.
*/
#endregion

#region Classes That Can Be Used For Database Operations - Veritabanı İşlemleri İçin Kullanılabilecek Sınıflar
/*
    # Connection: Veritabanı ile bağlantı kurmak için kullanılır.
    # DataReader: Veritabanı bağlantısı olduğu müddetçe, veritabanı içerisindeki verileri okuma amacı ile kullanılır.
    # DataSet: Veritabanı bağlantısı olduğu müddetçe veritabanı içerisindeki verileri okuma ve yazma amacı için kullanılır.
    # DataAdapter: Veritabanı bağlatısı olmasa bile veriler üzerinde işlemler gerçekleştirilebilir.
*/
#endregion

#endregion

namespace Ders_11_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            #region Example Of Sql Procesing
            /*
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.Size = new Size(1800, 950);
            SqlConnection connection = new SqlConnection("Data Source=ASUS-FX503VD;Initial Catalog=Northwind;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Employees", connection);
            SqlDataReader reader = null;
            if (connection.State == ConnectionState.Open)
            {
                //command.ExecuteNonQuery(); //Komut işletildikten sonra geriye etkilenen satır sayısın dönderir.
                reader = command.ExecuteReader(); //Komut sonucuna göre geriye DataReader nesnesi dönderir.
                //command.ExecuteScalar(); //Geriye sadece tek bir değer dönderen komutlar için kullanılır. Object tipinde dönderir.
                //command.ExecuteXmlReader(); //Komut sonucuna göre geriye XmlReader nesnesi dönderir.
                if (reader.HasRows)
                {
                    reader.Read();
                    MessageBox.Show($"CategoryID: {reader["CategoryID"].ToString()} CategoryName: {reader.GetString(1)}");
                    reader.Read();
                    MessageBox.Show($"CategoryID: {reader["CategoryID"].ToString()} CategoryName: {reader.GetString(1)}");
                    reader.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet dataSet = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0];
                }
                connection.Close();
            }
            else
                MessageBox.Show("Cant Connected!", "Error!");*/
            #endregion

            #region Example Of LINQ(Language Integrated Query)
            /*
            int[] numbers = { 1071, 2098, 354, 147, 8521, 10 };
            var number = from data in numbers where data > 1000 select data;
            foreach (var item in number)
                MessageBox.Show($"Sayı: {item}", "Numbers");
            */
            #endregion

            Misal();
        }

        private void Misal()
        {
            Parallel.Invoke(() =>
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    lblLeftButton.Text = i.ToString();
                }
            }, () =>
            {
                MessageBox.Show("Test");
                MessageBox.Show("Test");
                MessageBox.Show("Test");
                MessageBox.Show("Test");
                MessageBox.Show("Test");
                MessageBox.Show("Test");
                MessageBox.Show("Test");
                MessageBox.Show("Test");
            });
            Task task = new Task(() => { MessageBox.Show("Aiiiiiiii"); }, TaskCreationOptions.AttachedToParent);
        }

        #region Example Of Multi-Threading
        private void GoLoop(long count)
        {
            long i = 0;
            MessageBox.Show("Loop Started!", "Loop Information!");
            while (i++ < count) ;
            MessageBox.Show("Loop Finished!", "Loop Information!");
        }

        private void SumRandomNumbers()
        {
            Random rnd = new Random();
            double number1 = rnd.NextDouble();
            double number2 = rnd.NextDouble();
            MessageBox.Show($"number1 + number2 = {number1 + number2}", "Result!");
        }

        Thread t1;
        Thread t2;
        private void MiliSecondCounter(int miliSecond)
        {
            int i = 0;
            while (i < miliSecond)
            {
                lblLeftButton.Text = (++i).ToString();
            }
        }
        private void SecondCounter(byte second)
        {
            TimeSpan time;
            DateTime n = DateTime.Now;
            DateTime after = new DateTime(2021, 07, 28, 17, 41, 0, 0);
            time = after.Subtract(n);
            t1.Join(time);
            int i = 0;
            while (i < second)
            {
                Thread.Sleep(1000);
                lblRightButton.Text = (++i).ToString();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            /*Thread t1 = new Thread(() => GoLoop(1000000000));
            t1.Start();*/
            t1 = new Thread(() => MiliSecondCounter(600000));
            t1.Start();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //SumRandomNumbers();
            t2 = new Thread(() => SecondCounter(60));
            t2.Start();
            btnLeft_Click(btnRight, e);
        }
        #endregion

    }
}
