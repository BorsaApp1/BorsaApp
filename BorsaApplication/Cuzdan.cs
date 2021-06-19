using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BorsaApplication
{
    public partial class Cuzdan : MetroFramework.Forms.MetroForm
    {
        string kullaniciAdi;

        public Cuzdan(string userid)
        {
            InitializeComponent();
            kullaniciAdi = userid;
        }
        Sqlbaglanti baglanti = new Sqlbaglanti();

        private void Cuzdan_Load(object sender, EventArgs e)
        {
            ItemGoster();
        }
        void ItemGoster()
        {
            SqlCommand komut = new SqlCommand("Execute CuzdanItem "+"'"+kullaniciAdi+"'", baglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCuzdan.DataSource = dt;
        }
    }
}
