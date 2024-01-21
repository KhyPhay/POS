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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!DbConnection.isValidUser(telTB.Text, passwordTB.Text))
            {
                MessageBox.Show("Invalid Phone Number or Password !");
                return;
            }
            else
            {
                this.Hide();
                if (DbConnection.TYPE == "Controller")
                {
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    POS pos = new POS();
                    pos.Show();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
