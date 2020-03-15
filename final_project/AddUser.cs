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
    public partial class AddUser : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Employee_DBConnectionString);
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminUpdate AD = new AdminUpdate();
            AD.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Enter Username or Password or Both");
                }
                cmd = new SqlCommand("SELECT * FROM UserTable WHERE UserName = '" + textBox1.Text + "' ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    MessageBox.Show("Username " + textBox1.Text + " Exists!");
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO UserTable (UserName,Password) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New User Registered Successfully!");
                }
                 }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();
            lg.Show();
            this.Hide();
        }
        
    }
}
