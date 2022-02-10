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
    public partial class KitapEkleme : Form
    {
        public KitapEkleme()
        {
            InitializeComponent();
        }
            SqlConnection Baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Kütüphane ; Integrated Security = True");
            DataTable tablo = new DataTable();

        private void KitapEkleme_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sorgu = new SqlDataAdapter("select * From Kütüphanem", Baglanti);
            sorgu.Fill(tablo);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = tablo.Rows.Count;
            sayac++;
            DataTable tablo2 = new DataTable();

            if (textBox1.Text != "" && textBox2.Text!= "" && textBox3.Text != "" && textBox4.Text !="")
            {
                SqlDataAdapter sorgu = new SqlDataAdapter("INSERT INTO Kütüphanem (İd,Kitap_Adi , Yazar_Adi , Yayın_Evi , Türü) VALUES ('" + sayac + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", Baglanti);
                sorgu.Fill(tablo2);

                MessageBox.Show("Kitap Başarılı Bir Şekilde Kütüphaneye Eklendi");
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakamazsınız");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
