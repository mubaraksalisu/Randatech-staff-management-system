namespace final_project
{
    partial class AE_Form
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
            System.Windows.Forms.Label reasonForAbsentLabel;
            System.Windows.Forms.Label mMondayLabel;
            System.Windows.Forms.Label tTuesdayLabel;
            System.Windows.Forms.Label wWednesdayLabel;
            System.Windows.Forms.Label tThursdayLabel;
            System.Windows.Forms.Label fFridayLabel;
            System.Windows.Forms.Label sSaturdayLabel;
            System.Windows.Forms.Label sSundayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AE_Form));
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
            this.reasonForAbsentTextBox = new System.Windows.Forms.TextBox();
            this.mMondayTextBox = new System.Windows.Forms.TextBox();
            this.tTuesdayTextBox = new System.Windows.Forms.TextBox();
            this.wWednesdayTextBox = new System.Windows.Forms.TextBox();
            this.tThursdayTextBox = new System.Windows.Forms.TextBox();
            this.fFridayTextBox = new System.Windows.Forms.TextBox();
            this.sSaturdayTextBox = new System.Windows.Forms.TextBox();
            this.sSundayTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            employee_NameLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            reasonForAbsentLabel = new System.Windows.Forms.Label();
            mMondayLabel = new System.Windows.Forms.Label();
            tTuesdayLabel = new System.Windows.Forms.Label();
            wWednesdayLabel = new System.Windows.Forms.Label();
            tThursdayLabel = new System.Windows.Forms.Label();
            fFridayLabel = new System.Windows.Forms.Label();
            sSaturdayLabel = new System.Windows.Forms.Label();
            sSundayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingNavigator)).BeginInit();
            this.combinedTableBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.Location = new System.Drawing.Point(103, 110);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // employee_NameLabel
            // 
            employee_NameLabel.AutoSize = true;
            employee_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employee_NameLabel.Location = new System.Drawing.Point(310, 110);
            employee_NameLabel.Name = "employee_NameLabel";
            employee_NameLabel.Size = new System.Drawing.Size(115, 17);
            employee_NameLabel.TabIndex = 3;
            employee_NameLabel.Text = "Employee Name:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            positionLabel.Location = new System.Drawing.Point(577, 110);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(62, 17);
            positionLabel.TabIndex = 5;
            positionLabel.Text = "Position:";
            // 
            // reasonForAbsentLabel
            // 
            reasonForAbsentLabel.AutoSize = true;
            reasonForAbsentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reasonForAbsentLabel.Location = new System.Drawing.Point(201, 65);
            reasonForAbsentLabel.Name = "reasonForAbsentLabel";
            reasonForAbsentLabel.Size = new System.Drawing.Size(134, 17);
            reasonForAbsentLabel.TabIndex = 7;
            reasonForAbsentLabel.Text = "Reason For Absent:";
            // 
            // mMondayLabel
            // 
            mMondayLabel.AutoSize = true;
            mMondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mMondayLabel.Location = new System.Drawing.Point(67, 208);
            mMondayLabel.Name = "mMondayLabel";
            mMondayLabel.Size = new System.Drawing.Size(62, 17);
            mMondayLabel.TabIndex = 9;
            mMondayLabel.Text = "Monday:";
            // 
            // tTuesdayLabel
            // 
            tTuesdayLabel.AutoSize = true;
            tTuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tTuesdayLabel.Location = new System.Drawing.Point(339, 208);
            tTuesdayLabel.Name = "tTuesdayLabel";
            tTuesdayLabel.Size = new System.Drawing.Size(67, 17);
            tTuesdayLabel.TabIndex = 11;
            tTuesdayLabel.Text = "Tuesday:";
            // 
            // wWednesdayLabel
            // 
            wWednesdayLabel.AutoSize = true;
            wWednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            wWednesdayLabel.Location = new System.Drawing.Point(546, 208);
            wWednesdayLabel.Name = "wWednesdayLabel";
            wWednesdayLabel.Size = new System.Drawing.Size(87, 17);
            wWednesdayLabel.TabIndex = 13;
            wWednesdayLabel.Text = "Wednesday:";
            // 
            // tThursdayLabel
            // 
            tThursdayLabel.AutoSize = true;
            tThursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tThursdayLabel.Location = new System.Drawing.Point(63, 278);
            tThursdayLabel.Name = "tThursdayLabel";
            tThursdayLabel.Size = new System.Drawing.Size(72, 17);
            tThursdayLabel.TabIndex = 15;
            tThursdayLabel.Text = "Thursday:";
            // 
            // fFridayLabel
            // 
            fFridayLabel.AutoSize = true;
            fFridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fFridayLabel.Location = new System.Drawing.Point(353, 278);
            fFridayLabel.Name = "fFridayLabel";
            fFridayLabel.Size = new System.Drawing.Size(51, 17);
            fFridayLabel.TabIndex = 17;
            fFridayLabel.Text = "Friday:";
            // 
            // sSaturdayLabel
            // 
            sSaturdayLabel.AutoSize = true;
            sSaturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sSaturdayLabel.Location = new System.Drawing.Point(565, 278);
            sSaturdayLabel.Name = "sSaturdayLabel";
            sSaturdayLabel.Size = new System.Drawing.Size(69, 17);
            sSaturdayLabel.TabIndex = 19;
            sSaturdayLabel.Text = "Saturday:";
            // 
            // sSundayLabel
            // 
            sSundayLabel.AutoSize = true;
            sSundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sSundayLabel.Location = new System.Drawing.Point(71, 347);
            sSundayLabel.Name = "sSundayLabel";
            sSundayLabel.Size = new System.Drawing.Size(60, 17);
            sSundayLabel.TabIndex = 21;
            sSundayLabel.Text = "Sunday:";
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
            this.combinedTableBindingNavigator.Size = new System.Drawing.Size(876, 25);
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
            this.combinedTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.combinedTableBindingNavigatorSaveItem_Click_1);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(130, 107);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 23);
            this.iDTextBox.TabIndex = 2;
            // 
            // employee_NameTextBox
            // 
            this.employee_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Employee_Name", true));
            this.employee_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_NameTextBox.Location = new System.Drawing.Point(378, 24);
            this.employee_NameTextBox.Name = "employee_NameTextBox";
            this.employee_NameTextBox.Size = new System.Drawing.Size(145, 23);
            this.employee_NameTextBox.TabIndex = 4;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "Position", true));
            this.positionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTextBox.Location = new System.Drawing.Point(597, 24);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 23);
            this.positionTextBox.TabIndex = 6;
            // 
            // reasonForAbsentTextBox
            // 
            this.reasonForAbsentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "ReasonForAbsent", true));
            this.reasonForAbsentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonForAbsentTextBox.Location = new System.Drawing.Point(341, 62);
            this.reasonForAbsentTextBox.Name = "reasonForAbsentTextBox";
            this.reasonForAbsentTextBox.Size = new System.Drawing.Size(280, 23);
            this.reasonForAbsentTextBox.TabIndex = 8;
            // 
            // mMondayTextBox
            // 
            this.mMondayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "MMonday", true));
            this.mMondayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMondayTextBox.Location = new System.Drawing.Point(89, 16);
            this.mMondayTextBox.Name = "mMondayTextBox";
            this.mMondayTextBox.Size = new System.Drawing.Size(100, 23);
            this.mMondayTextBox.TabIndex = 10;
            // 
            // tTuesdayTextBox
            // 
            this.tTuesdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "TTuesday", true));
            this.tTuesdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTuesdayTextBox.Location = new System.Drawing.Point(364, 19);
            this.tTuesdayTextBox.Name = "tTuesdayTextBox";
            this.tTuesdayTextBox.Size = new System.Drawing.Size(100, 23);
            this.tTuesdayTextBox.TabIndex = 12;
            // 
            // wWednesdayTextBox
            // 
            this.wWednesdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "WWednesday", true));
            this.wWednesdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wWednesdayTextBox.Location = new System.Drawing.Point(591, 16);
            this.wWednesdayTextBox.Name = "wWednesdayTextBox";
            this.wWednesdayTextBox.Size = new System.Drawing.Size(100, 23);
            this.wWednesdayTextBox.TabIndex = 14;
            // 
            // tThursdayTextBox
            // 
            this.tThursdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "TThursday", true));
            this.tThursdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tThursdayTextBox.Location = new System.Drawing.Point(89, 86);
            this.tThursdayTextBox.Name = "tThursdayTextBox";
            this.tThursdayTextBox.Size = new System.Drawing.Size(100, 23);
            this.tThursdayTextBox.TabIndex = 16;
            // 
            // fFridayTextBox
            // 
            this.fFridayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "FFriday", true));
            this.fFridayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fFridayTextBox.Location = new System.Drawing.Point(364, 86);
            this.fFridayTextBox.Name = "fFridayTextBox";
            this.fFridayTextBox.Size = new System.Drawing.Size(100, 23);
            this.fFridayTextBox.TabIndex = 18;
            // 
            // sSaturdayTextBox
            // 
            this.sSaturdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "SSaturday", true));
            this.sSaturdayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSaturdayTextBox.Location = new System.Drawing.Point(592, 89);
            this.sSaturdayTextBox.Name = "sSaturdayTextBox";
            this.sSaturdayTextBox.Size = new System.Drawing.Size(100, 23);
            this.sSaturdayTextBox.TabIndex = 20;
            // 
            // sSundayTextBox
            // 
            this.sSundayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.combinedTableBindingSource, "SSunday", true));
            this.sSundayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSundayTextBox.Location = new System.Drawing.Point(89, 158);
            this.sSundayTextBox.Name = "sSundayTextBox";
            this.sSundayTextBox.Size = new System.Drawing.Size(100, 23);
            this.sSundayTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reasonForAbsentTextBox);
            this.groupBox1.Controls.Add(reasonForAbsentLabel);
            this.groupBox1.Controls.Add(this.positionTextBox);
            this.groupBox1.Controls.Add(this.employee_NameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(48, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tTuesdayTextBox);
            this.groupBox2.Controls.Add(this.wWednesdayTextBox);
            this.groupBox2.Controls.Add(this.sSaturdayTextBox);
            this.groupBox2.Controls.Add(this.fFridayTextBox);
            this.groupBox2.Controls.Add(this.tThursdayTextBox);
            this.groupBox2.Controls.Add(this.sSundayTextBox);
            this.groupBox2.Controls.Add(this.mMondayTextBox);
            this.groupBox2.Location = new System.Drawing.Point(48, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 194);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "View reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(655, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Exit Application";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Absent Record Form";
            // 
            // AE_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(876, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(sSundayLabel);
            this.Controls.Add(sSaturdayLabel);
            this.Controls.Add(fFridayLabel);
            this.Controls.Add(tThursdayLabel);
            this.Controls.Add(wWednesdayLabel);
            this.Controls.Add(tTuesdayLabel);
            this.Controls.Add(mMondayLabel);
            this.Controls.Add(positionLabel);
            this.Controls.Add(employee_NameLabel);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.combinedTableBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AE_Form";
            this.Text = "AE_Form";
            this.Load += new System.EventHandler(this.AE_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedTableBindingNavigator)).EndInit();
            this.combinedTableBindingNavigator.ResumeLayout(false);
            this.combinedTableBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox reasonForAbsentTextBox;
        private System.Windows.Forms.TextBox mMondayTextBox;
        private System.Windows.Forms.TextBox tTuesdayTextBox;
        private System.Windows.Forms.TextBox wWednesdayTextBox;
        private System.Windows.Forms.TextBox tThursdayTextBox;
        private System.Windows.Forms.TextBox fFridayTextBox;
        private System.Windows.Forms.TextBox sSaturdayTextBox;
        private System.Windows.Forms.TextBox sSundayTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;

    }
}