using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM.Model
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;
        Byte[] imageByteArray;

        private void categoryNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string filePath;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)| .png; *.jpg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                changeImage.Image = new Bitmap(filePath);
            }
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            string query = "select id, name from category";
            DbConnection.CBFill(query, categoryCb);
            if(cID > 0)
            {
                categoryCb.SelectedValue = cID;
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "";
            if(id == 0)
            {
                query = "Insert into product Values (@Price, ​@Name,  @Quality, @Category, @Image) ";
            }
            else
            {
                query = "update product set name = @Name, price = @Price, quality = @Quality, category_id = @Category, image = @Image where id =  @Id"; 
            }

            // For Image 
            Image temp = new Bitmap(changeImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();
            Hashtable ht =  new Hashtable();
            ht.Add("@Price", productPriceTB.Text);
            ht.Add("@Name", productNameTB.Text);
            ht.Add("@Quality", productQuantityTB.Text);
            ht.Add("@Category", Convert.ToInt32(categoryCb.SelectedValue));
            ht.Add("@Image", imageByteArray);

            if (DbConnection.SQL(query, ht)> 0)
            {
                MessageBox.Show("Success");
                id = 0;
                productNameTB.Text = "";
                productPriceTB.Text = "";
                productQuantityTB.Text = "";
                categoryCb.SelectedValue = -1;
            }
            this.Hide();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
