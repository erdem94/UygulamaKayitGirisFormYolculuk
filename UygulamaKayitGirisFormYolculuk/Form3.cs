using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UygulamaKayitGirisFormYolculuk
{
     partial class Form3:Form1

    {
        
        public Form3()
        {
            InitializeComponent();
        }
      


        private void btnGiris_Click(object sender, EventArgs e)
            {
            
                foreach (var Kayit in listKayit)
                {


                    if (txtGirisKullaniciAdi.Text == Kayit.KullaniciAdi)
                    {
                        if (txtGirisSifre.Text == Kayit.SifreTekrar.ToString())
                        {
                            Form2 form2 = new Form2();
                            form2.ShowDialog();
                        }
                    }

                }
            }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void Form3_Load(object sender, EventArgs e)
        {
        
    }

      
    }
    }

      
   

