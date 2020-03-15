namespace final_project
{
    partial class EE_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label employee_NameLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label mondayLabel;
            System.Windows.Forms.Label tuesdayLabel;
            System.Windows.Forms.Label wednesdayLabel;
            System.Windows.Forms.Label thursdayLabel;
            System.Windows.Forms.Label fridayLabel;
            System.Windows.Forms.Label saturdayLabel;
            System.Windows.Forms.Label sundayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EE_Form));
            this.employee_DBDataSet1 = new final_project.Employee_DBDataSet1();
            this.combinedTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedTableTableAdapter = new final_project.Employee_DBDataSet1TableAdapters.CombinedTableTableAdapter();
            this.tableAdapterManager = new final_project.Employee_DBDataSet1TableAdapters.TableAdapterManager();
            this.combinedTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.combinedTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.employee_NameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.mondayTextBox = new System.Windows.Forms.TextBox();
            this.tuesdayTextBox = new System.Windows.Forms.TextBox();
            this.wednesdayTextBox = new System.Windows.Forms.TextBox();
            this.thursdayTextBox = new System.Windows.Forms.TextBox();
            this.fridayTextBox = new System.Windows.Forms.TextBox();
            this.saturdayTextBox = new System.Windows.Forms.TextBox();
            this.sundayTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            iDLabel = new System.Windows.Forms.Label();
            employee_NameLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            mondayLabel = new System.Windows.Forms.Label();
            tuesdayLabel = new System.Windows.Forms.Label();
            wednesdayLabel = new System.Windows.Forms.Label();
            thursdayLabel = new System.Windows.Forms.Label();
            fridayLabel = new System.Windows.Forms.Label();
            saturdayLabel = new System.Windows.Forms.Label();
            sundayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingNavigator)).BeginInit();
            this.combinedTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(86, 119);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // employee_NameLabel
            // 
            employee_NameLabel.AutoSize = true;
            employee_NameLabel.Location = new System.Drawing.Point(299, 119);
            employee_NameLabel.Name = "employee_NameLabel";
            employee_NameLabel.Size = new System.Drawing.Size(87, 13);
            employee_NameLabel.TabIndex = 3;
            employee_NameLabel.Text = "Employee Name:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(589, 119);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Position:";
            // 
            // mondayLabel
            // 
            mondayLabel.AutoSize = true;
            mondayLabel.Location = new System.Drawing.Point(59, 241);
            mondayLabel.Name = "mondayLabel";
            mondayLabel.Size = new System.Drawing.Size(48, 13);
            mondayLabel.TabIndex = 7;
            mondayLabel.Text = "Monday:";
            // 
            // tuesdayLabel
            // 
            tuesdayLabel.AutoSize = true;
            tuesdayLabel.Location = new System.Drawing.Point(335, 241);
            tuesdayLabel.Name = "tuesdayLabel";
            tuesdayLabel.Size = new System.Drawing.Size(51, 13);
            tuesdayLabel.TabIndex = 9;
            tuesdayLabel.Text = "Tuesday:";
            // 
            // wednesdayLabel
            // 
            wednesdayLabel.AutoSize = true;
            wednesdayLabel.Location = new System.Drawing.Point(569, 241);
            wednesdayLabel.Name = "wednesdayLabel";
            wednesdayLabel.Size = new System.Drawing.Size(67, 13);
            wednesdayLabel.TabIndex = 11;
            wednesdayLabel.Text = "Wednesday:";
            // 
            // thursdayLabel
            // 
            thursdayLabel.AutoSize = true;
            thursdayLabel.Location = new System.Drawing.Point(53, 314);
            thursdayLabel.Name = "thursdayLabel";
            thursdayLabel.Size = new System.Drawing.Size(54, 13);
            thursdayLabel.TabIndex = 13;
            thursdayLabel.Text = "Thursday:";
            // 
            // fridayLabel
            // 
            fridayLabel.AutoSize = true;
            fridayLabel.Location = new System.Drawing.Point(348, 314);
            fridayLabel.Name = "fridayLabel";
            fridayLabel.Size = new System.Drawing.Size(38, 13);
            fridayLabel.TabIndex = 15;
            fridayLabel.Text = "Friday:";
            // 
            // saturdayLabel
            // 
            saturdayLabel.AutoSize = true;
            saturdayLabel.Location = new System.Drawing.Point(584, 314);
            saturdayLabel.Name = "saturdayLabel";
            saturdayLabel.Size = new System.Drawing.Size(52, 13);
            saturdayLabel.TabIndex = 17;
            saturdayLabel.Text = "Saturday:";
            // 
            // sundayLabel
            // 
            sundayLabel.AutoSize = true;
            sundayLabel.Location = new System.Drawing.Point(61, 389);
            sundayLabel.Name = "sundayLabel";
            sundayLabel.Size = new System.Drawing.Size(46, 13);
            sundayLabel.TabIndex = 19;
            sundayLabel.Text = "Sunday:";
            // 
            // employee_DBDataSet1
            // 
            this.employee_DBDataSet1.DataSetName = "Employee_DBDataSet1";
            this.employee_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combinedTableBindingSource
            // 
            this.combinedTableBindingSource.DataMember = "CombinedTable";
            this.combinedTableBindingSource.DataSource = this.employee_DBDataSet1;
            // 
            // combinedTableTableAdapter
            // 
            this.combinedTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CombinedTableTableAdapter = this.combinedTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = final_project.Employee_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combinedTableBindingNavigator
            // 
            this.combinedTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.combinedTableBindingNavigator.BindingSource = this.combinedTableBindingSource;
            this.combinedTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.combinedTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.combinedTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.combinedTableBindingNavigatorSaveItem});
            this.combinedTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.combinedTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.combinedTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.combinedTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.combinedTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.combinedTableBindingNavigator.Name = "combinedTableBindingNavigator";
            this.combinedTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.combinedTableBindingNavigator.Size = new System.Drawing.Size(1002, 25);
            this.combinedTableBindingNavigator.TabIndex = 0;
            this.combinedTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(80, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(105, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(82, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(78, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // combinedTableBindingNavigatorSaveItem
            // 
            this.combinedTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("combinedTableBindingNavigatorSaveItem.Image")));
            this.combinedTableBindingNavigatorSaveItem.Name = "combinedTableBindingNavigatorSaveItem";
            this.combinedTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.combinedTableBindingNavigatorSaveItem.Text = "Save Data";
            this.combinedTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.combinedTableBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(113, 116);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // employee_NameTextBox
            // 
            this.employee_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Employee_Name", true));
            this.employee_NameTextBox.Location = new System.Drawing.Point(392, 116);
            this.employee_NameTextBox.Name = "employee_NameTextBox";
            this.employee_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.employee_NameTextBox.TabIndex = 4;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(642, 116);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 6;
            // 
            // mondayTextBox
            // 
            this.mondayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Monday", true));
            this.mondayTextBox.Location = new System.Drawing.Point(113, 238);
            this.mondayTextBox.Name = "mondayTextBox";
            this.mondayTextBox.Size = new System.Drawing.Size(100, 20);
            this.mondayTextBox.TabIndex = 8;
            // 
            // tuesdayTextBox
            // 
            this.tuesdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Tuesday", true));
            this.tuesdayTextBox.Location = new System.Drawing.Point(392, 238);
            this.tuesdayTextBox.Name = "tuesdayTextBox";
            this.tuesdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.tuesdayTextBox.TabIndex = 10;
            // 
            // wednesdayTextBox
            // 
            this.wednesdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Wednesday", true));
            this.wednesdayTextBox.Location = new System.Drawing.Point(642, 238);
            this.wednesdayTextBox.Name = "wednesdayTextBox";
            this.wednesdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.wednesdayTextBox.TabIndex = 12;
            // 
            // thursdayTextBox
            // 
            this.thursdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Thursday", true));
            this.thursdayTextBox.Location = new System.Drawing.Point(113, 311);
            this.thursdayTextBox.Name = "thursdayTextBox";
            this.thursdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.thursdayTextBox.TabIndex = 14;
            // 
            // fridayTextBox
            // 
            this.fridayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Friday", true));
            this.fridayTextBox.Location = new System.Drawing.Point(392, 311);
            this.fridayTextBox.Name = "fridayTextBox";
            this.fridayTextBox.Size = new System.Drawing.Size(100, 20);
            this.fridayTextBox.TabIndex = 16;
            // 
            // saturdayTextBox
            // 
            this.saturdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Saturday", true));
            this.saturdayTextBox.Location = new System.Drawing.Point(642, 311);
            this.saturdayTextBox.Name = "saturdayTextBox";
            this.saturdayTextBox.Size = new System.Drawing.Size(100, 20);
            this.saturdayTextBox.TabIndex = 18;
            // 
            // sundayTextBox
            // 
            this.sundayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Sunday", true));
            this.sundayTextBox.Location = new System.Drawing.Point(113, 386);
            this.sundayTextBox.Name = "sundayTextBox";
            this.sundayTextBox.Size = new System.Drawing.Size(100, 20);
            this.sundayTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Employee Working Scheduling Form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(587, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Exit Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(338, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 23;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(89, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 31);
            this.button3.TabIndex = 24;
            this.button3.Text = "View Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(45, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(45, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 223);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Week Days";
            // 
            // EE_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1002, 580);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(sundayLabel);
            this.Controls.Add(this.sundayTextBox);
            this.Controls.Add(saturdayLabel);
            this.Controls.Add(this.saturdayTextBox);
            this.Controls.Add(fridayLabel);
            this.Controls.Add(this.fridayTextBox);
            this.Controls.Add(thursdayLabel);
            this.Controls.Add(this.thursdayTextBox);
            this.Controls.Add(wednesdayLabel);
            this.Controls.Add(this.wednesdayTextBox);
            this.Controls.Add(tuesdayLabel);
            this.Controls.Add(this.tuesdayTextBox);
            this.Controls.Add(mondayLabel);
            this.Controls.Add(this.mondayTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(employee_NameLabel);
            this.Controls.Add(this.employee_NameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.combinedTableBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EE_Form";
            this.ShowIcon = false;
            this.Text = "EE_Form";
            this.Load += new System.EventHandler(this.EE_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingNavigator)).EndInit();
            this.combinedTableBindingNavigator.ResumeLayout(false);
            this.combinedTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Employee_DBDataSet1 employee_DBDataSet1;
        private System.Windows.Forms.BindingSource combinedTableBindingSource;
        private Employee_DBDataSet1TableAdapters.CombinedTableTableAdapter combinedTableTableAdapter;
        private Employee_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator combinedTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton combinedTableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox employee_NameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox mondayTextBox;
        private System.Windows.Forms.TextBox tuesdayTextBox;
        private System.Windows.Forms.TextBox wednesdayTextBox;
        private System.Windows.Forms.TextBox thursdayTextBox;
        private System.Windows.Forms.TextBox fridayTextBox;
        private System.Windows.Forms.TextBox saturdayTextBox;
        private System.Windows.Forms.TextBox sundayTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}