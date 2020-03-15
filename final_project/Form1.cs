using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final_project
{
    public partial class Login_Form : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Employee_DBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        public Login_Form()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM AdminTable WHERE UserName= '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
            
                AddUser fT = new AddUser();
                fT.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not a Registered ADMIN, OR Invalid Username or Password");
            }
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM UserTable WHERE UserName= '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {

                Main_Form fT = new Main_Form();
                fT.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not a Registered ADMIN, OR Invalid Username or Password");
            }
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

    }
}
