using System;
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
    public partial class ucProduct : UserControl
    {
        public event EventHandler onSelect = null;
        public ucProduct()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string PPrice { get; set; }
        public string PCategory { get; set; }
        public string PQuality { get; set; }
        public string PName
        {
            get { return productName.Text; }
            set { productName.Text = value; }

        }
        public Image PImage
        {
            get { return txImage.Image; }
            set { txImage.Image = value; }
        }






        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txImage_Click(object sender, EventArgs e)
        {
            
        }

        private void txImage_Click_1(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void product_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }

        private void productName_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
