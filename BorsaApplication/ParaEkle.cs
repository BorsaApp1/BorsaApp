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
    public partial class ParaEkle : MetroFramework.Forms.MetroForm
    {
        string userid1;
        public ParaEkle(string userid)
        {
            userid1 = userid;
            InitializeComponent();
        }

        Sqlbaglanti baglanti = new Sqlbaglanti();
        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut =new SqlCommand("Execute ParaEkleme " + "'"+userid1+"'"+","+txtParaEkle.Text, baglanti.baglanti());
            komut.ExecuteNonQuery();
            MessageBox.Show("Onay için bekleniyor");  //Para Ekleme procedure ile admin sayfasına istenilen para gonderiliyor.
            baglanti.baglanti().Close();
            this.Close();
        }
    }
}
