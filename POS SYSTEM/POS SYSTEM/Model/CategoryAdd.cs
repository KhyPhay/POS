using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM.Model
{
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "";
            if(id == 0)
            {
                query = "insert  into category values(@Name)";
            }else if(id == 1)
            {
                query = "update category set name = @Name where id = @Id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@Id", id);
            ht.Add("@Name", categoryNameTB.Text);
            if(DbConnection.SQL(query, ht) > 0)
            {
                MessageBox.Show("Save Successfull...");
                id = 0;
                categoryNameTB.Focus();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
