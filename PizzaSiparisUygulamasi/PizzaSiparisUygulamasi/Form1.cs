using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double UcretHesapla(string pBoyu, int pAdet, string iBoyu, int iAdet, int ekstraAdet)
        {
            double sonuc;
            int pifiyati, ifiyati;
            if (pBoyu == "Büyük")
            {
                pifiyati = 20;
            }
            else if (pBoyu == "Orta")
                pifiyati = 15;
            else
                pifiyati = 10;

            //İçeceklerin Fiyatını Alalım
            if (iBoyu == "2,5 Lt Cola" || iBoyu == "2,5 Lt Gazoz")
            {
                ifiyati = 15;
            }
            else
                ifiyati = 10;
            //Toplam Ücreti Hesaplayalım

            sonuc = pifiyati * pAdet + ifiyati * iAdet + ekstraAdet;
            return sonuc;
        }
        
        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            string pboyut, iboyutu, ekstra = "";
            int pizzaAdet, icecekAdet, ekstraAdet = 0;
            double toplamucret;
            lsbAdSoyad.Items.Add(txtAdSoyad.Text);
            lsbAdres.Items.Add(txtAdres.Text);
            lsbTelNo.Items.Add(txtTelNo.Text);

            //Pizza Boyu ve İçeçek boylarını alalım

            pboyut = cmbPizzaBoyu.SelectedItem.ToString();
            iboyutu = cmbIcecekBoyu.SelectedItem.ToString();
            pizzaAdet = Convert.ToInt16(nudPizzaAdet.Value);
            icecekAdet = Convert.ToInt16(nudIcecekAdet.Value);
            //Pizza ve İçeçekleri ListBoxa ekleyelim
            lsbPizzaAdBoy.Items.Add(pboyut + "Boy " + pizzaAdet.ToString()+ " Adet");
            lsbIcecekBoyAdet.Items.Add(iboyutu + " " + icecekAdet.ToString() + " Adet");
            // Ekstraları kontrol edelim
            if (chb1.Checked)
            {
                ekstra = ekstra + " " + chb1.Text;
                ekstraAdet = ekstraAdet + 1;
            }
            if (chb2.Checked)
            {
                ekstra = ekstra + " " + chb2.Text;
                ekstraAdet = ekstraAdet + 1;
            }
            if (chb3.Checked)
            {
                ekstra = ekstra + " " + chb3.Text;
                ekstraAdet = ekstraAdet + 1;
            }
            if (chb4.Checked)
            {
                ekstra = ekstra + " " + chb4.Text;
                ekstraAdet = ekstraAdet + 1;
            }
            if (chb5.Checked)
            {
                ekstra = ekstra + " " + chb5.Text;
                ekstraAdet = ekstraAdet + 1;
            }
            if (chb6.Checked)
            {
                ekstra = ekstra + " " + chb6.Text;
                ekstraAdet = ekstraAdet + 1;
            }
            //ekstraları listboxa ekleyelim
            lsbEkstra.Items.Add(ekstra);
            toplamucret = UcretHesapla(pboyut, pizzaAdet, iboyutu, icecekAdet, ekstraAdet);
            lsbUcret.Items.Add(toplamucret + " TL");

        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtAdres.Text = "";
            cmbIcecekBoyu.SelectedIndex = -1;
            cmbPizzaBoyu.SelectedIndex = -1;
            nudIcecekAdet.Value = 0;
            nudPizzaAdet.Value = 0;
            chb1.Checked = false;
            chb2.Checked = false;
            chb3.Checked = false;
            chb4.Checked = false;
            chb5.Checked = false;
            chb6.Checked = false;

        }

        private void btnSiparisTemizle_Click(object sender, EventArgs e)
        {
            lsbAdSoyad.Items.Clear();
            lsbAdres.Items.Clear();
            lsbTelNo.Items.Clear();
            lsbIcecekBoyAdet.Items.Clear();
            lsbPizzaAdBoy.Items.Clear();
            lsbUcret.Items.Clear();
            lsbEkstra.Items.Clear();
        }
    }
}
