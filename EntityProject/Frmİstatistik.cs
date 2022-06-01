using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        DbEntityProjectEntities db = new DbEntityProjectEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelTopKatSay.Text = db.Tbl_Kategori.Count().ToString();
            labelStokMarka.Text = db.stokMarka().FirstOrDefault().ToString();
            labelAMusteriSay.Text = db.Tbl_Musteri.Count(x => x.MusteriDurum == true).ToString();
            labelPMusteriSay.Text = db.Tbl_Musteri.Count(x => x.MusteriDurum == false).ToString();
            labelEnYuksek.Text = db.Tbl_Urun.Sum(x => x.UrunStok).ToString();
            labelKasaTutar.Text = db.Tbl_Satis.Sum(x => x.SatisFiyat).ToString();
            labelEnYuksek.Text = (from x in db.Tbl_Urun orderby x.UrunFiyat descending select x.UrunAd).FirstOrDefault().ToString();
        }
    }
}
