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
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string query = "select id, name, tel, type, gender from employee";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgID);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgTel);
            lb.Items.Add(dvgrole);
            lb.Items.Add(dvgGender);

            DbConnection.LoadData(query, categoryDataTable, lb);
        }
        private void StaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void categoryDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
