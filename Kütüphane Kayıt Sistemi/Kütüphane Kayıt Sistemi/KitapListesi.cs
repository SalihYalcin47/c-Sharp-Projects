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
    public partial class KitapListesi : Form
    {
        public KitapListesi()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Kütüphane ; Integrated Security = True");
        DataTable tablo = new DataTable();
        private void KitapListesi_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sorgu = new SqlDataAdapter("select * from Kütüphanem order by İd", Baglanti);
            sorgu.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
