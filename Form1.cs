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
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Lütfen Mail Adresinizi Girin", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            try
            {
                using (DolapDBEntities test = new DolapDBEntities())
                {

                    var query = from o in test.Users
                                where o.UserName == textBox1.Text && o.UserPass == textBox2.Text
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
