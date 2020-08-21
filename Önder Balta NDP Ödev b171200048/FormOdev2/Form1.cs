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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBoxKisiselBilgiler_Enter(object sender, EventArgs e)
        {

        }

        private void kişiselBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {//Menu strip'e tıklandığında 
            groupBoxKisiselBilgiler.Enabled = true;
            //Kisisel Bilgiler'in bulunduğu groupbox'u aktif ediyoruz
        }

        private void Form1_Load(object sender, EventArgs e)
        {//Form yüklendiğinde
            groupBoxKisiselBilgiler.Enabled = false;//Kisisel bilgiler group box'u pasif ediyoruz.
            buttonListele.Enabled = false;//Listele butonunu pasif ediyoruz 
        }

        public static string TCNo, AdSoyad, TelNo, Adres, Cinsiyet, Semt;

        private void comboBoxSemt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Değişkenleri public olarak tanımlıyoruz.
        public void buttonKaydet_Click(object sender, EventArgs e)
        {//Kaydet butonuna tıklandığında
           //Textboxlardaki değerleri değişkenlere aktarıyoruz
            TCNo = textBoxTCNo.Text.ToString();
            AdSoyad = textBoxAdSoyad.Text.ToString();
            TelNo = textBoxTelNo.Text.ToString();
            Adres = textBoxAdres.Text.ToString();
            if (radioButtonErkek.Checked == true)
            {
                Cinsiyet = "Erkek";
            } 
            else
            {
                Cinsiyet = "Kadın";
            }
            Semt = comboBoxSemt.Text.ToString();
            buttonListele.Enabled = true;//Listele butonunu aktifleştiriyoruz.          
       }
     
        private void buttonListele_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//Forma ulaşmak için yeni bir class oluşturuyoruz 
            frm2.Show();//Form 2'yi gösteriyoruz
            this.Hide();//Bulunduğumuz formu gizliyoruz           
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {//Temizle butonuna tıklandığında textboxtaki değerleri sıfırlıyoruz
            textBoxTCNo.Text = "";
            textBoxAdSoyad.Text = "";
            textBoxTelNo.Text = "";
            textBoxAdres.Text = "";
            comboBoxSemt.Text = "";
        }

        private void siparişGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                MessageBox.Show("Önder Balta B171200048");
            }
            
        } 
        
    }
}
