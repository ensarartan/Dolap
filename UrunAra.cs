using Amazon.CloudFormation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolap
{
    public partial class UrunAra : Form
    {
        public UrunAra()
        {
            InitializeComponent();
        }

        private void UrunAra_Load(object sender, EventArgs e)
        {


        }
        DolapDBEntities DolapDBEntities = new DolapDBEntities();


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (DolapDBEntities dolapDB = new DolapDBEntities())
                {
                    var query1 = from o in dolapDB.Products
                                 where o.ProductID.ToString() == textBox1.Text
                                 select o;

                    if (query1.SingleOrDefault() == null)
                    {
                        MessageBox.Show("ID bulunamadı.Lütfen Başka bir ID giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var file = dolapDB.Products
                            .Where(f => f.ProductID.ToString() == textBox1.Text)
                            .Select(f => new
                            {
                                f.ProductID,
                                f.ProductName,
                                f.ProductSize,
                                f.Productcolor,
                                f.ProductType,
                                f.ProductInputDate,
                                f.ProductOutputDate,
                                f.ProductQuantity,
                                f.ProductPrice,
                                f.ProductDesc,
                            }).FirstOrDefault();

                        label11.Text = file.ProductID.ToString();
                        label12.Text = file.ProductName;
                        label13.Text = file.ProductSize;
                        label14.Text = file.Productcolor;
                        label15.Text = file.ProductType;
                        label16.Text = file.ProductInputDate.ToString();
                        label17.Text = file.ProductOutputDate.ToString();
                        label18.Text = file.ProductQuantity.ToString();
                        label19.Text = String.Format("{0:N2} TL", file.ProductPrice);
                        // label19.Text = file.ProductPrice.ToString();
                        label20.Text = file.ProductDesc;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hay Aksi, Lütfen Tekrar Deneyin.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem sistem = new Sistem();
            sistem.Show();
            this.Hide();
        }
    }
}
