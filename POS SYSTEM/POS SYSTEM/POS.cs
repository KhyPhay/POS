using POS_SYSTEM.Model;
using POS_SYSTEM.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void ucProduct3_Load(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            LoadingProduct();

        }
        private void AddItems(string id, string name, string cat, string price, string quality, Image image)
        {
            var w = new ucProduct()
            {
                PName = name,
                PCategory = cat,
                PPrice = price,
                PQuality = quality,
                PImage = image,
                id = Convert.ToInt32(id)

            };
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                if (Convert.ToInt32(wdg.PQuality) <= 0)
                {
                    MessageBox.Show("Product no stock right now!");
                    return;
                }
                else
                {
                    int q = Convert.ToInt32(wdg.PQuality) - 1;
                    w.PQuality = q.ToString();
                }
                foreach (DataGridViewRow item in invoidView.Rows)
                {

                    if (Convert.ToInt32(item.Cells["dvgId"].Value) == wdg.id)
                    {
                        item.Cells["dvgQuality"].Value = int.Parse(item.Cells["dvgQuality"].Value.ToString()) + 1;
                        item.Cells["dvgAmount"].Value = int.Parse(item.Cells["dvgPrice"].Value.ToString()) *
                        double.Parse(item.Cells["dvgQuality"].Value.ToString());
                        GetTotal();
                        return;
                    }

                }
                // add product
                invoidView.Rows.Add(new object[] { wdg.id, wdg.PName, wdg.PPrice, 1, wdg.PPrice });
                GetTotal();

            };



        }

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadingProduct()
        {
            {
                string query = "select product.id, product.name, product.price, product.quality, product.image, category.name as catName from product inner join category on product.category_id = category.id";
                SqlCommand cmd = new SqlCommand(query, DbConnection.con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    Byte[] imageArray = (byte[])item["image"];
                    byte[] imageByteArray = imageArray;
                    AddItems(item["id"].ToString(), item["name"].ToString(), item["catName"].ToString(), item["price"].ToString(), item["quality"].ToString(), Image.FromStream(new MemoryStream(imageByteArray)));
                }
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void GetTotal()
        {
            double total = 0;
            Total.Text = "";
            foreach (DataGridViewRow item in invoidView.Rows)
            {
                total += double.Parse(item.Cells["dvgAmount"].Value.ToString());
            }
            Total.Text = total.ToString("N2");
        }
        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            string query = "select product.id, product.name, product.price, product.quality, product.image, category.name as catName from product inner join category on product.category_id = category.id where product.name like '%" + searchTB.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, DbConnection.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["image"];
                byte[] imageByteArray = imageArray;
                AddItems(item["id"].ToString(), item["name"].ToString(), item["catName"].ToString(), item["price"].ToString(), item["quality"].ToString(), Image.FromStream(new MemoryStream(imageByteArray)));
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchTB_TextChanged_1(object sender, EventArgs e)
        {
            ProductPanel.Controls.Clear();
            string query = "select product.id, product.name, product.price, product.quality, product.image, category.name as catName from product inner join category on product.category_id = category.id where product.name like '%" + searchTB.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, DbConnection.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["image"];
                byte[] imageByteArray = imageArray;
                AddItems(item["id"].ToString(), item["name"].ToString(), item["catName"].ToString(), item["price"].ToString(), item["quality"].ToString(), Image.FromStream(new MemoryStream(imageByteArray)));
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string qInvoice = "insert into invoice values(@date, @description, @sellerId)";
            Hashtable ht = new Hashtable();
            ht.Add("@date", DateTime.UtcNow.ToString());
            ht.Add("@description", "");
            ht.Add("@sellerId", DbConnection.ID.ToString());
            string invoiceId;
            DbConnection.SQL(qInvoice, ht);
            try
            {
                string query = "SELECT TOP 1 * FROM invoice ORDER BY ID DESC";
                SqlCommand cmd = new SqlCommand(query, DbConnection.con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                invoiceId= dt.Rows[0]["id"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            foreach (DataGridViewRow item in invoidView.Rows)
            {
                try
                {
                    Hashtable htInvoicPro = new Hashtable();
                    string queryInPro = "insert into product_invoice values(@productId, @invoiceId, @quality)";
                    htInvoicPro.Add("@productId", item.Cells["dvgId"].Value.ToString());
                    htInvoicPro.Add("@invoiceId", invoiceId);
                    htInvoicPro.Add("@quality", item.Cells["dvgQuality"].Value.ToString());
                    DbConnection.SQL(queryInPro, htInvoicPro);




                    string qu = "SELECT quality FROM product where id = " + item.Cells["dvgId"].Value.ToString();
                    SqlCommand cmd = new SqlCommand(qu, DbConnection.con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    string quantity = (int.Parse(dt.Rows[0]["quality"].ToString()) - int.Parse(item.Cells["dvgQuality"].Value.ToString())).ToString();

                    string queryUpdate = "update product set quality = @quantity where id = @id";
                    Hashtable htP = new Hashtable();
                    htP.Add("@quantity", quantity);
                    htP.Add("@id", item.Cells["dvgId"].Value.ToString());
                    DbConnection.SQL(queryUpdate, htP);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            this.Hide();
            InvoiceView invoice = new InvoiceView();
            invoice.Show();
        }

        private void viewHisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvoiceView invoice = new InvoiceView();
            invoice.Show();
        }
    }
}
