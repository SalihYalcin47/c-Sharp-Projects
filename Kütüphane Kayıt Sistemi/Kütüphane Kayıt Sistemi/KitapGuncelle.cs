using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kütüphane_Kayıt_Sistemi
{
    public partial class KitapGuncelle : Form
    {
        public KitapGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Kütüphane ; Integrated Security = True");
        DataTable tablo = new DataTable();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                SqlDataAdapter sorgu1 = new SqlDataAdapter("update Kütüphanem set İd='"+textBox2.Text+"' where İd ='"+textBox1.Text+"'",Baglanti);
                sorgu1.Fill(tablo);
                MessageBox.Show("İşlem Başarılı Bir Şekilde gerçekleşti");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter sorgu2 = new SqlDataAdapter("update Kütüphanem set Kitap_Adi='" + textBox2.Text + "' where Kitap_Adi ='" + textBox1.Text + "'", Baglanti);
                sorgu2.Fill(tablo);
                MessageBox.Show("İşlem Başarılı Bir Şekilde gerçekleşti");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                SqlDataAdapter sorgu3 = new SqlDataAdapter("update Kütüphanem set Yazar_Adi='" + textBox2.Text + "' where Yazar_Adi ='" + textBox1.Text + "'", Baglanti);
                sorgu3.Fill(tablo);
                MessageBox.Show("İşlem Başarılı Bir Şekilde gerçekleşti");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                SqlDataAdapter sorgu4 = new SqlDataAdapter("update Kütüphanem set Yayın_Evi='" + textBox2.Text + "' where Yayın_Evi ='" + textBox1.Text + "'", Baglanti);
                sorgu4.Fill(tablo);
                MessageBox.Show("İşlem Başarılı Bir Şekilde gerçekleşti");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                SqlDataAdapter sorgu5 = new SqlDataAdapter("update Kütüphanem set Türü='" + textBox2.Text + "' where Türü ='" + textBox1.Text + "'", Baglanti);
                sorgu5.Fill(tablo);
                MessageBox.Show("İşlem Başarılı Bir Şekilde gerçekleşti");
            }
        }
    }
}
