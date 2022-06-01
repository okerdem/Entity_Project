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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }

        DbEntityProjectEntities db = new DbEntityProjectEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            //var kategoriler = db.Tbl_Kategori.ToList();
            //dataGridViewKategori.DataSource = kategoriler;
            dataGridViewKategori.DataSource = db.Tbl_Kategori.ToList();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori kat = new Tbl_Kategori();
            kat.Ad = textBoxKatAd.Text;
            db.Tbl_Kategori.Add(kat);
            db.SaveChanges();

            dataGridViewKategori.DataSource = db.Tbl_Kategori.ToList();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int iİd = Convert.ToInt32(textBoxKatİd.Text);
            db.Tbl_Kategori.Remove(db.Tbl_Kategori.Find(iİd));
            db.SaveChanges();

            dataGridViewKategori.DataSource = db.Tbl_Kategori.ToList();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int iİd = Convert.ToInt32(textBoxKatİd.Text);
            var vBul = db.Tbl_Kategori.Find(iİd);
            vBul.Ad = textBoxKatAd.Text;
            db.SaveChanges();

            dataGridViewKategori.DataSource = db.Tbl_Kategori.ToList();
        }
    }
}
