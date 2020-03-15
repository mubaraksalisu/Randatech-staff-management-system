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
    public partial class VC_Form : Form
    {
        public VC_Form()
        {
            InitializeComponent();
        }

        private void VC_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Employee_DBDataSet1.CombinedTable' table. You can move, or remove it, as needed.
            this.CombinedTableTableAdapter.Fill(this.Employee_DBDataSet1.CombinedTable);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.CombinedTableTableAdapter.FillBy(this.Employee_DBDataSet1.CombinedTable, ((int)(System.Convert.ChangeType(textBox1.Text, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CombinedTableTableAdapter.Fill(this.Employee_DBDataSet1.CombinedTable);

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Form M = new Main_Form();
            M.Show();
            this.Hide();
        }
    }
}
