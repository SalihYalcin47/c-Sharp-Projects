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
    public partial class KitapArama : Form
    {
        public KitapArama()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source = localhost; Initial Catalog=Kütüphane; Integrated Security = True");
        DataTable tablo = new DataTable();

        private void KitapArama_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Kütüphanem", Baglanti);
            sorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
            Baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            Baglanti.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Kütüphanem where Kitap_Adi like '" + textBox1.Text + "%'", Baglanti);
            DataTable tablo2 = new DataTable();
            adapt.Fill(tablo2);
            dataGridView1.DataSource = tablo2;
            Baglanti.Close();
        }
    }
}
