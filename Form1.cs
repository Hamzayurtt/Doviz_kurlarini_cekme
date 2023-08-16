using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace döviz_kurlarını_çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";


            var xmldoc = new XmlDocument();
            xmldoc.Load(url);

            //internet sitesindeki en son güncellenen tarihi buluyoruz

            /*DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            lbl_tarih.Text=tarih.ToString();*/



            DateTime tarih = DateTime.Now;
            lbl_tarih.Text = tarih.ToString();

            string usd = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbl_dolar.Text = usd;


            string euro = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbl_euro.Text = euro;

            string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            lbl_sterlin.Text = sterlin;


            string kuveyt_dinarı = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='KWD']/BanknoteSelling").InnerXml;
            lbl_kuveyt_dinarı.Text = kuveyt_dinarı;

            string arap_riyali = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='SAR']/BanknoteSelling").InnerXml;
            lbl_arap_riyali.Text = arap_riyali;

            string isviçre_frangı = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='CHF']/BanknoteSelling").InnerXml;
            lbl_isviçre_frangı.Text = isviçre_frangı;



            lbl_dolar.Visible = false;
            lbl_euro.Visible = false;
            lbl_isviçre_frangı.Visible = false;
            lbl_kuveyt_dinarı.Visible = false;
            lbl_sterlin.Visible = false;
            lbl_arap_riyali.Visible = false;


            //labeldaki değerleri textboxa yazdırdık 
            //textboxa alıp noktaları virgüle çevirmek için

            dolar_text.Text = lbl_dolar.Text;
            euro_text.Text = lbl_euro.Text;
            sterlin_text.Text = lbl_sterlin.Text;
            riyal_text.Text = lbl_arap_riyali.Text;
            frank_text.Text = lbl_isviçre_frangı.Text;
            dinar_text.Text = lbl_kuveyt_dinarı.Text;

            dolar_text.Text = dolar_text.Text.ToString().Replace(".", ",");
            euro_text.Text = euro_text.Text.ToString().Replace(".", ",");
            riyal_text.Text = riyal_text.Text.ToString().Replace(".", ",");
            frank_text.Text = frank_text.Text.ToString().Replace(".", ",");
            dinar_text.Text = dinar_text.Text.ToString().Replace(".", ",");
            sterlin_text.Text = sterlin_text.Text.ToString().Replace(".", ",");





        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            try
            { 
                double toplam_ücret;

            toplam_ücret = Convert.ToDouble(txtbox_tl.Text) * Convert.ToDouble(textbox_kur_değeri.Text);

            txtbox_ücret.Text = toplam_ücret.ToString();

            }
            catch (Exception)
            {

                 MessageBox.Show("TL (₺) değeri giriniz ");
            }      
            */




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double seçilen_döviz_kuru;

            string secilenDoviz = comboBox1.SelectedItem.ToString();
            switch (secilenDoviz)
            {
                case "Dolar":
                    seçilen_döviz_kuru = Convert.ToDouble(dolar_text.Text);
                    textbox_kur_değeri.Text = dolar_text.Text;
                    label10.Text = "Dolar";
                    break;


                case "Euro":
                    seçilen_döviz_kuru = Convert.ToDouble(euro_text.Text);
                    textbox_kur_değeri.Text = euro_text.Text;
                    label10.Text = "Euro";


                    break;


                case "Sterlin":
                    seçilen_döviz_kuru = Convert.ToDouble(sterlin_text.Text);
                    textbox_kur_değeri.Text = sterlin_text.Text;


                    label10.Text = "Sterlin";



                    break;


                case "Arap Riyali":
                    seçilen_döviz_kuru = Convert.ToDouble(riyal_text.Text);
                    textbox_kur_değeri.Text = riyal_text.Text;

                    label10.Text = "Arap Riyali";



                    break;


                case "İsviçre Frangı":
                    seçilen_döviz_kuru = Convert.ToDouble(frank_text.Text);
                    textbox_kur_değeri.Text = frank_text.Text;

                    label10.Text = "İsviçre Frangı";


                    break;


                case "Kuveyt Dinarı":
                    seçilen_döviz_kuru = Convert.ToDouble(dinar_text.Text);
                    textbox_kur_değeri.Text = dinar_text.Text;


                    label10.Text = "Kuveyt Dinarı";



                    break;

                    txtbox_tl.Visible = true;


            }
        }
 
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
            txtbox_tl.Visible = false;
        }

        private void txtbox_tl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double toplam_ücret;

                toplam_ücret = Convert.ToDouble(txtbox_tl.Text) * Convert.ToDouble(textbox_kur_değeri.Text);

                txtbox_ücret.Text = toplam_ücret.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("TL (₺) değeri giriniz ");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            txtbox_tl.Visible = true;
            label9.Text = "Kaç " + label10.Text + " Almak istiyosunuz";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            txtbox_tl.Visible = true;
            label9.Text = "Kaç " + label10.Text + " Satmak  istiyosunuz";
        }
        static String constrning = ("Data Source=HAMZA;Initial Catalog=döviz;Integrated Security=True");

        SqlConnection bağlan = new SqlConnection(constrning);


        void kayıtları_getir()
        {
            dataGridView1.ForeColor = Color.Black;


            bağlan.Open();
            string getir = "Select * From döviz_tablosu ";
            SqlCommand komut = new SqlCommand(getir, bağlan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            bağlan.Close();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (bağlan.State == ConnectionState.Closed)
                {
                    bağlan.Open();
                    string kayıt = "insert into döviz_tablosu (Tarih,Dolar,Euro,Sterlin,Arap_Riyali,Kuveyt_Dinarı,İsviçre_Frangı) values (@tarih,@dolar,@euro,@sterlin,@frank,@riyal,@dinar) ";
                    SqlCommand komut = new SqlCommand(kayıt, bağlan);
                    komut.Parameters.AddWithValue("@tarih", DateTime.Parse(lbl_tarih.Text));
                    komut.Parameters.AddWithValue("@dolar", float.Parse(dolar_text.Text));
                    komut.Parameters.AddWithValue("@euro", float.Parse(euro_text.Text));
                    komut.Parameters.AddWithValue("@sterlin", float.Parse(sterlin_text.Text));
                    komut.Parameters.AddWithValue("@dinar", float.Parse(dinar_text.Text));
                    komut.Parameters.AddWithValue("@frank", float.Parse(frank_text.Text));
                    komut.Parameters.AddWithValue("@riyal", float.Parse(riyal_text.Text));

                    komut.ExecuteNonQuery();
                    bağlan.Close();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı");
                    kayıtları_getir();

                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu: " + hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayıtları_getir();
            
        }


    }
}




