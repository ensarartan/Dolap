using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dolap
{
    public partial class Urunekle : Form
    {
        string filename;
        List<Product> list;
        public Urunekle()
        {
            InitializeComponent();
        }
        DolapDBEntities dolapDBEntities = new DolapDBEntities();

        //Convert binary to image
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        
        private  void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            //if (string.IsNullOrWhiteSpace(this.maskedTextBox1.Text))
            //{
            //    MessageBox.Show("Lütfen ürün ID giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    maskedTextBox1.Focus();
            //    return;

            //}
            if (string.IsNullOrWhiteSpace(this.textBox2.Text))
            {
                MessageBox.Show("Lütfen ürün Adı giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.maskedTextBox2.Text))
            {
                MessageBox.Show("Lütfen stok adedi giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox2.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                textBox4.Text = "--";

            }
            if (string.IsNullOrWhiteSpace(this.textBox5.Text))
            {
                MessageBox.Show("Lütfen ürün cinsi veya türünü giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.textBox6.Text))
            {
                textBox6.Text = "--";

            }

            if (string.IsNullOrWhiteSpace(this.maskedTextBox3.Text))
            {
                MessageBox.Show("Lütfen ürün fiyatı giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox3.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(this.richTextBox1.Text))
            {
                richTextBox1.Text = "--";

            }
            Boolean ara = false;

            using (DolapDBEntities test = new DolapDBEntities())
            {

                //var query = from o in test.Products
                //            where o.ProductID.ToString() == maskedTextBox1.Text
                //            select o;

                //if (query.SingleOrDefault() != null)
                //{
                //    MessageBox.Show("Farklı bir ID giriniz.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ara = true;

                //}


                if (ara == false)
                {

                    
                    product.ProductName = textBox2.Text;
                    product.ProductQuantity = Convert.ToInt32(maskedTextBox2.Text);
                    product.Productcolor = textBox4.Text;
                    product.ProductType = textBox5.Text;
                    product.ProductSize = textBox6.Text;
                    product.ProductPrice = Convert.ToDecimal(maskedTextBox3.Text);
                    product.ProductDesc = richTextBox1.Text;
                    //Product pic = new Product() { ProductName = filename, ProductImage = ConvertImageToBinary(pictureBox1.Image) };
                   
                    
                    


                    dolapDBEntities.Products.Add(product);
                    dolapDBEntities.SaveChanges();
                    MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png|Bitmap|*.bmp", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem sistem = new Sistem();
            sistem.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
