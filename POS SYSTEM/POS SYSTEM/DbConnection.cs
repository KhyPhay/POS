
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace POS_SYSTEM
{
    internal class DbConnection
    {
        public static readonly string connectionString = "Data Source=DESKTOP-J2BPSMV;Initial Catalog=pos;Integrated Security=True;Encrypt=False;";
        public static SqlConnection con = new SqlConnection(connectionString);
        public static bool isValidUser(string phoneNumber, string password)
        {
            bool valid = false;
            string query = "select * from employee where tel = '" + phoneNumber + "' and password = '" + password + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                valid = true;
                USER = dt.Rows[0]["name"].ToString();
                type = dt.Rows[0]["type"].ToString();
                id = dt.Rows[0]["id"].ToString();
            }
            return valid;
        }
        public static string user;
        public static string type;
        public static string id;
        public static string ID
        {
            get { return id; }
            set { id = value; }
        }
        
        public static string TYPE
        {
            get { return type; }
            set { type = value; }
        }
        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }


        // Method for crud operation
        public static int SQL(string qeury, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qeury, con);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            return res;
        }
        public static void LoadData(string query, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
        public static void CBFill(string query, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }
    }
}
