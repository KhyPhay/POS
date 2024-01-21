using POS_SYSTEM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM.View
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "select product.id, product.name, product.price, product.quality, category.name from product inner join category on product.category_id = category.id";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgID);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgPrice);
            lb.Items.Add(dvgQuality);
            lb.Items.Add(dvgCategory);
            DbConnection.LoadData(query, categoryDataTable, lb);
        }
        private void ProductList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addCategory_Click(object sender, EventArgs e)
        {

            ProductAdd product = new ProductAdd();
            product.ShowDialog();
            GetData();
        }

        private void categoryDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
