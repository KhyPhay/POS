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
    public partial class CategoryView : Form
    {
        public CategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "select * from category";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgID);
            lb.Items.Add(dvgName);
            DbConnection.LoadData(query, categoryDataTable, lb);
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            CategoryAdd cat = new CategoryAdd();
            cat.ShowDialog();
            GetData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
