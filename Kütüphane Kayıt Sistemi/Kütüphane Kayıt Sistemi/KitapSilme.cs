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
    public partial class KitapSilme : Form
    {
        public KitapSilme()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost ; Initial Catalog=Kütüphane ; Integrated Security=True");
        DataTable tablo = new DataTable();
        private void KitapSilme_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * From Kütüphanem order by İd",Baglanti);
            sorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo2 = new DataTable();
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
            SqlDataAdapter sorgu2 = new SqlDataAdapter("Select * From Kütüphanem Where İd like'"+textBox1.Text+"'", Baglanti);
            sorgu2.Fill(tablo2);
            dataGridView1.DataSource=tablo2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            DataTable tablo3 = new DataTable();
            SqlDataAdapter sorgu3 = new SqlDataAdapter("Delete From Kütüphanem Where İd ='"+textBox1.Text+"'",Baglanti);
            sorgu3.Fill(tablo3);
            dataGridView1.DataSource= tablo3;
        }
    }
}
