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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        DbEntityProjectEntities db = new DbEntityProjectEntities();

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            dataGridViewUrun.DataSource = (from x in db.Tbl_Urun
                                           select new
                                           {
                                               x.Urunİd,
                                               x.UrunAd,
                                               x.UrunMarka,
                                               x.UrunStok,
                                               x.UrunFiyat,
                                               x.UrunDurum,
                                               x.Tbl_Kategori.Ad
                                           }).ToList();

            var vKategoriler = (from x in db.Tbl_Kategori select new { x.Ad, x.İd }).ToList();
            comboBoxKategori.DataSource = vKategoriler;
            comboBoxKategori.ValueMember = "İd";
            comboBoxKategori.DisplayMember = "Ad";

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urun turun = new Tbl_Urun();
            turun.UrunAd = textBoxAd.Text;
            turun.UrunMarka = textBoxMarka.Text;
            turun.UrunStok = short.Parse(textBoxStok.Text);
            turun.UrunKategori = int.Parse(comboBoxKategori.SelectedValue.ToString());
            turun.UrunFiyat = decimal.Parse(textBoxFiyat.Text);
            turun.UrunDurum = true;
            db.Tbl_Urun.Add(turun);
            db.SaveChanges();

            dataGridViewUrun.DataSource = db.Tbl_Urun.ToList();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int iİd = Convert.ToInt32(textBoxİd.Text);
            db.Tbl_Urun.Remove(db.Tbl_Urun.Find(iİd));
            db.SaveChanges();

            dataGridViewUrun.DataSource = db.Tbl_Urun.ToList();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int iİd = Convert.ToInt32(textBoxİd.Text);
            var vGuncel = db.Tbl_Urun.Find(iİd);
            vGuncel.UrunAd = textBoxAd.Text;
            vGuncel.UrunMarka = textBoxMarka.Text;
            vGuncel.UrunStok = short.Parse(textBoxStok.Text);
            vGuncel.UrunKategori = int.Parse(comboBoxKategori.SelectedValue.ToString());
            vGuncel.UrunFiyat = decimal.Parse(textBoxFiyat.Text);
            vGuncel.UrunDurum = true;
            db.SaveChanges();

            dataGridViewUrun.DataSource = db.Tbl_Urun.ToList();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
        }
    }
}
