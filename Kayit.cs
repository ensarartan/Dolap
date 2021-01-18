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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        DolapDBEntities DolapDBEntities = new DolapDBEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();

            //bool BOS = false;
            bool TCara = false;
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                MessageBox.Show("Lütfen Firma İsmi Giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                MessageBox.Show("Lütfen kullanici adi giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.textBox3.Text))
            {
                MessageBox.Show("Lütfen parola giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                MessageBox.Show("Lütfen mail adresi giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(this.dateTimePicker1.Text))
            {
                MessageBox.Show("Lütfen Yaşınızı giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            else
            {
                label8.Text = dateTimePicker1.Value.ToString("MM/dd/yy");
            }
            if (radioButton1.Checked==false && radioButton2.Checked==false)
            {
                MessageBox.Show("Lütfen cinsiyetinizi seçiniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    label7.Text = "K";
                }
                if (radioButton2.Checked == true)
                {
                    label7.Text = "E";
                }
            }
            try
            {
                using (DolapDBEntities test = new DolapDBEntities())
                {

                    var query1 = from o in test.Users
                                 where o.UserName == textBox2.Text
                                 select o;

                    if (query1.SingleOrDefault() != null)
                    {
                        MessageBox.Show("Farklı kullanıcı adı giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TCara = true;

                    }

                    var query3 = from o in test.Users
                                 where o.UserMail == textBox4.Text
                                 select o;

                    if (query3.SingleOrDefault() != null)
                    {
                        MessageBox.Show("Farklı mail adresi giriniz..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TCara = true;

                    }
                    if (TCara == false)
                    {

                        MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        user.UserCampany = textBox1.Text;
                        user.UserName = textBox2.Text;
                        user.UserPass = textBox3.Text;
                        user.UserMail = textBox4.Text;
                        user.UserAge = label8.Text;
                        user.UserSex = label7.Text;

                        DolapDBEntities.Users.Add(user);
                        DolapDBEntities.SaveChanges();

                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Üzgünüm işlem gerçekleştiremedim :/ Lütfen tekrar deneyin.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
