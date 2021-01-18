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
    public partial class Sistem : Form
    {
        public Sistem()
        {
            InitializeComponent();
        }

        private void Sistem_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            this.Hide();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunekle urunekle = new Urunekle();
            urunekle.Show();
            this.Hide();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            UrunAra urunAra = new UrunAra();
            urunAra.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.Show();
            this.Hide();
        }
    }
}
