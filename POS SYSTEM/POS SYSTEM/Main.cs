using POS_SYSTEM.Model;
using POS_SYSTEM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void AddControls(Form form)
        {
            centerPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            centerPanel.Controls.Add(form);
            form.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userLabel.Text = DbConnection.USER; 

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Category
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddControls(new CategoryView());
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AddControls(new StaffView());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            AddControls(new ProductList());
        }
    }
}
