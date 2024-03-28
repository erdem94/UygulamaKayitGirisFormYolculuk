using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaKayitGirisFormYolculuk
{
    
    public partial class Form1 : Form
    {
       public  List<Kayit> listKayit = new List<Kayit>();

       public Kayit kayit = new Kayit();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            if(txtSifre.Text==txtSifreTekrar.Text)
            {
                Kayit kayit = new Kayit();
                kayit.AdSoyad = txtAdSoyad.Text;
                kayit.KullaniciAdi = txtKullaniciAdi.Text;
                listKayit.Add(kayit);
                Bagla();
                txtAdSoyad.Clear();
                txtKullaniciAdi.Clear();
                txtSoru.Clear();
                txtCevap.Clear();
                txtSifre.Clear();
                txtSifreTekrar.Clear();
                Form3 form3 = new Form3();
                form3.Show();
                
                
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor.");
                txtAdSoyad.Clear();
                txtKullaniciAdi.Clear();
                txtSoru.Clear();
                txtCevap.Clear();
                txtSifre.Clear();
                txtSifreTekrar.Clear();
            }
            
            
        }
        private void Bagla()
        {
            kayit.Cevap=txtCevap.Text;
            kayit.AdSoyad=txtAdSoyad.Text;
            kayit.KullaniciAdi = txtKullaniciAdi.Text;
            kayit.Sifre = Convert.ToInt32(txtSifre.Text);  
            kayit.SifreTekrar=Convert.ToInt32(txtSifreTekrar.Text);
            txtSifreTekrar.Text = kayit.ToString();
            txtSoru.Text = kayit.Soru;
           
        }

        
    }
}
