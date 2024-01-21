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
    public partial class InvoiceView : Form
    {
        public InvoiceView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "select invoice.id, invoice.date, product.name, product.price, product_invoice.quality, employee.name as seller " +
                "from employee inner join invoice on employee.id = invoice.seller_id " +
                "inner join product_invoice on product_invoice.invoice_id = invoice.id " +
                "inner join product on product_invoice.product_id = product.id;";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgID);
            lb.Items.Add(dvgDate);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgPrice);
            lb.Items.Add(dvgQuality);
            lb.Items.Add(dvgSeller);
            DbConnection.LoadData(query, invoidView, lb);
            foreach (DataGridViewRow row in invoidView.Rows)
            {
                row.Cells["dvgAmount"].Value = int.Parse(row.Cells["dvgPrice"].Value.ToString()) *
                        double.Parse(row.Cells["dvgQuality"].Value.ToString());
            }
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void invoidView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewPosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            POS pos = new POS();
            pos.Show();
        }
    }
}
