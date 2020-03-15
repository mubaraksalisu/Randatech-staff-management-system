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
    public partial class VE_Form : Form
    {
        public VE_Form()
        {
            InitializeComponent();
        }

       

        private void VE_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_DBDataSet1.CombinedTable' table. You can move, or remove it, as needed.
            this.combinedTableTableAdapter.Fill(this.employee_DBDataSet1.CombinedTable);
           
        }

        private void combinedTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.combinedTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employee_DBDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VC_Form V = new VC_Form();
            V.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Form M = new Main_Form();
            M.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
