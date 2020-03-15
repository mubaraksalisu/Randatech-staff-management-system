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
    public partial class View_VE_form : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Employee_DBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        public View_VE_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Form mf = new Main_Form();
            mf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM AdminTable WHERE UserName= '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {

                VE_Form fT = new VE_Form();
                fT.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Not a Registered ADMIN, OR Invalid Username or Password");
            }
            con.Close();
        }
    }
}
