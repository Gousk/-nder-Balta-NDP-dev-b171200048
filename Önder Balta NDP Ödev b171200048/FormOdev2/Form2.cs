using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOdev2
{
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {//Form 2 yüklendiğinde 
           groupBoxSiparisListesi.Visible=false;//Siparis listesini gizliyoruz.
        }

        private void buttonSiparisAl_Click(object sender, EventArgs e)
        {   //Siparis al butonuna tıklandığında 
            groupBoxSiparisListesi.Visible=true;
            //siparis listesi görünürlüğünü aktifleştiriyoruz 
            string Siparisler="";//siparisler değişkenini oluşturuyoruz 
            int tutar=0;

            if (checkBox1.Checked == true)
            {//Eğer checkbox checked ise siparişlere yeni değer ekliyoruz ve tutarını ekliyoruz 
                Siparisler = "iPhone 11 Pro Max";
                tutar += 13705;

            } 
            if (checkBox2.Checked == true)
            {
                Siparisler = Siparisler + "OnePlus 7T Pro";
                tutar += 7899;

            }
           if (checkBox3.Checked == true)
            {
                Siparisler = Siparisler + "Oppo Find X2";
                tutar += 10199;

            }
            if (checkBox4.Checked == true)
            {
                Siparisler = Siparisler + "Samsung Galaxy S20 Ultra";
                tutar += 10599;

            }
            if (checkBox5.Checked == true)
            {
                Siparisler = Siparisler + "Xiaomi Mi 10";
                tutar += 8515;

            }
           //Listbox'a Form 1'deki textbox değerlerini ekliyoruz.
            listBoxTCKimlikNo.Items.Add(Form1.TCNo);
            listBoxAdSoyad.Items.Add(Form1.AdSoyad);
            listBoxTelNo.Items.Add(Form1.TelNo);
            listBoxAdres.Items.Add(Form1.Adres);
            listBoxCinsiyet.Items.Add(Form1.Cinsiyet);
            listBoxIlce.Items.Add(Form1.Semt);
            listBoxSiparisler.Items.Add(Siparisler);

            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                    listBox1.Items.Add("Pazartesi");
                    break;
                case 2:
                    listBox1.Items.Add("Salı");
                    break;
                case 3:
                    listBox1.Items.Add("Çarşamba");
                    break;
                case 4:
                    listBox1.Items.Add("Perşembe");
                    break;
                case 5:
                    listBox1.Items.Add("Cuma");
                    break;
                case 6:
                    listBox1.Items.Add("Cumartesi");
                    break;
                case 7:
                    listBox1.Items.Add("Pazar");
                    break;
            }

                    labelTutar.Text = tutar.ToString() + "TL" ;//Tutarı yazdırıyoruz.
                                                           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelTutar_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxSiparisListesi_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = (int)DateTime.Now.DayOfWeek;
            switch (day)
            {
                case 1:
                    MessageBox.Show("Bugün Pazartesi");
                    break;
                case 2:
                    MessageBox.Show("Bugün Salı");
                    break;
                case 3:
                    MessageBox.Show("Bugün Çarşamba");
                    break;
                case 4:
                    MessageBox.Show("Bugün Perşembe");
                    break;
                case 5:
                    MessageBox.Show("Bugün Cuma");
                    break;
                case 6:
                    MessageBox.Show("Bugün Cumartesi");
                    break;
                case 7:
                    MessageBox.Show("Bugün Pazar");
                    break;
            }
        }
    }
}
