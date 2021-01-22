using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolap
{
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        DolapDBEntities DolapDB = new DolapDBEntities();
        public void listele()
        {
            dataGridView1.DataSource = DolapDB.Products.ToList<Product>();

        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_urunid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtb_urunisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtb_urunboyut.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtb_urunrengi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtb_uruntipi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //label16.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //label17.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtb_urunadedi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtb_urunfiyat.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtb_urunaciklama.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //pictureBox1.Image = dataGridView1.CurrentRow.Cells[9].ValueType;
        }
    }
}
