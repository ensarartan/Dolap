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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_kullanici.Text))
            {

                MessageBox.Show("Lütfen Mail Adresinizi Girin", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_kullanici.Focus();
                return;
            }
            try
            {
                using (DolapDBEntities test = new DolapDBEntities())
                {

                    var query = from o in test.Users
                                where o.UserName == txt_kullanici.Text && o.UserPass == txt_pass.Text
                                select o;

                    if (query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("Başarıyla giriş yaptınız.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Sistem sistem = new Sistem();
                        sistem.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Your username or password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
