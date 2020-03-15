using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace final_project
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ES_View E = new ES_View();
            E.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VC_Form v = new VC_Form();
            v.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Absent_Report a = new Absent_Report();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_EE_form ee = new View_EE_form();
            ee.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_VE_form ve = new View_VE_form();
            ve.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            View_AE_form ae = new View_AE_form();
            ae.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login_Form L = new Login_Form();
            L.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login_Form L = new Login_Form();
            L.Show();
            this.Hide();
        }
    }
}
