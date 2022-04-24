namespace WindowsFormsApp1
{
    partial class LNewTask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tasknumberLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labsupportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task_managmentDataSet = new WindowsFormsApp1.task_managmentDataSet();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.flatComboBox5 = new FlatUI.FlatComboBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton4 = new FlatUI.FlatButton();
            this.flatComboBox4 = new FlatUI.FlatComboBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatComboBox2 = new FlatUI.FlatComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatComboBox3 = new FlatUI.FlatComboBox();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.FlatMini = new FlatUI.FlatMini();
            this.FlatClose = new FlatUI.FlatClose();
            this.flatStickyButton2 = new FlatUI.FlatStickyButton();
            this.formSkin2 = new FlatUI.FormSkin();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.lab_supportTableAdapter = new WindowsFormsApp1.task_managmentDataSetTableAdapters.lab_supportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsupportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_managmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.formSkin2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tasknumberLDataGridViewTextBoxColumn,
            this.tasktypeDataGridViewTextBoxColumn,
            this.labnumberDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.taskdateDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.labsupportBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(36, 259);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 29;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(944, 360);
            this.bunifuCustomDataGrid1.TabIndex = 61;
            // 
            // tasknumberLDataGridViewTextBoxColumn
            // 
            this.tasknumberLDataGridViewTextBoxColumn.DataPropertyName = "task_number_L";
            this.tasknumberLDataGridViewTextBoxColumn.HeaderText = "task_number_L";
            this.tasknumberLDataGridViewTextBoxColumn.Name = "tasknumberLDataGridViewTextBoxColumn";
            // 
            // tasktypeDataGridViewTextBoxColumn
            // 
            this.tasktypeDataGridViewTextBoxColumn.DataPropertyName = "task_type";
            this.tasktypeDataGridViewTextBoxColumn.HeaderText = "task_type";
            this.tasktypeDataGridViewTextBoxColumn.Name = "tasktypeDataGridViewTextBoxColumn";
            // 
            // labnumberDataGridViewTextBoxColumn
            // 
            this.labnumberDataGridViewTextBoxColumn.DataPropertyName = "lab_number";
            this.labnumberDataGridViewTextBoxColumn.HeaderText = "lab_number";
            this.labnumberDataGridViewTextBoxColumn.Name = "labnumberDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // taskdateDataGridViewTextBoxColumn
            // 
            this.taskdateDataGridViewTextBoxColumn.DataPropertyName = "task_date";
            this.taskdateDataGridViewTextBoxColumn.HeaderText = "task_date";
            this.taskdateDataGridViewTextBoxColumn.Name = "taskdateDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // labsupportBindingSource
            // 
            this.labsupportBindingSource.DataMember = "lab_support";
            this.labsupportBindingSource.DataSource = this.task_managmentDataSet;
            // 
            // task_managmentDataSet
            // 
            this.task_managmentDataSet.DataSetName = "task_managmentDataSet";
            this.task_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(466, 13);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(42, 21);
            this.flatLabel7.TabIndex = 60;
            this.flatLabel7.Text = "Date";
            // 
            // flatComboBox5
            // 
            this.flatComboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labsupportBindingSource, "day", true));
            this.flatComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox5.ForeColor = System.Drawing.Color.White;
            this.flatComboBox5.FormattingEnabled = true;
            this.flatComboBox5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox5.ItemHeight = 18;
            this.flatComboBox5.Items.AddRange(new object[] {
            "الاحد ",
            "الاثنين",
            "الثلاثاء",
            "الاربعاء",
            "الخميس"});
            this.flatComboBox5.Location = new System.Drawing.Point(198, 197);
            this.flatComboBox5.Name = "flatComboBox5";
            this.flatComboBox5.Size = new System.Drawing.Size(121, 24);
            this.flatComboBox5.TabIndex = 58;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApp1.Properties.Resources.Cancel_96px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton2.Location = new System.Drawing.Point(954, 145);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(44, 45);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 57;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApp1.Properties.Resources.Plus_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton1.Location = new System.Drawing.Point(954, 187);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 56;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(510, 627);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(154, 32);
            this.flatButton3.TabIndex = 54;
            this.flatButton3.Text = "PDF حفظ";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click_1);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(304, 626);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(154, 32);
            this.flatButton4.TabIndex = 53;
            this.flatButton4.Text = "حفظ ";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // flatComboBox4
            // 
            this.flatComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labsupportBindingSource, "state", true));
            this.flatComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox4.ForeColor = System.Drawing.Color.White;
            this.flatComboBox4.FormattingEnabled = true;
            this.flatComboBox4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox4.ItemHeight = 18;
            this.flatComboBox4.Items.AddRange(new object[] {
            "تم الانجاز",
            "قيد التنفيذ",
            "استنئناف"});
            this.flatComboBox4.Location = new System.Drawing.Point(36, 197);
            this.flatComboBox4.Name = "flatComboBox4";
            this.flatComboBox4.Size = new System.Drawing.Size(144, 24);
            this.flatComboBox4.TabIndex = 51;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flatLabel6.Location = new System.Drawing.Point(64, 146);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(63, 30);
            this.flatLabel6.TabIndex = 50;
            this.flatLabel6.Text = "الحالة";
            // 
            // flatComboBox2
            // 
            this.flatComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labsupportBindingSource, "task_type", true));
            this.flatComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox2.ForeColor = System.Drawing.Color.White;
            this.flatComboBox2.FormattingEnabled = true;
            this.flatComboBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox2.ItemHeight = 18;
            this.flatComboBox2.Items.AddRange(new object[] {
            "تجهيز معمل",
            "اختبار"});
            this.flatComboBox2.Location = new System.Drawing.Point(788, 197);
            this.flatComboBox2.Name = "flatComboBox2";
            this.flatComboBox2.Size = new System.Drawing.Size(156, 24);
            this.flatComboBox2.TabIndex = 49;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(36, 235);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(920, 18);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(940, 13);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 40;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labsupportBindingSource, "lab_number", true));
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Location = new System.Drawing.Point(710, 197);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = false;
            this.flatTextBox2.Size = new System.Drawing.Size(66, 38);
            this.flatTextBox2.TabIndex = 38;
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            // 
            // flatComboBox3
            // 
            this.flatComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labsupportBindingSource, "department", true));
            this.flatComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox3.ForeColor = System.Drawing.Color.White;
            this.flatComboBox3.FormattingEnabled = true;
            this.flatComboBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox3.ItemHeight = 18;
            this.flatComboBox3.Items.AddRange(new object[] {
            "الادارة",
            "علوم رياضيات",
            "علوم فيزياء",
            "علوم كيمياء",
            "علوم كيمياء حيوية",
            "علوم احياء",
            "علوم احصاء"});
            this.flatComboBox3.Location = new System.Drawing.Point(486, 197);
            this.flatComboBox3.Name = "flatComboBox3";
            this.flatComboBox3.Size = new System.Drawing.Size(208, 24);
            this.flatComboBox3.TabIndex = 37;
            this.flatComboBox3.Tag = "القسم";
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flatLabel5.Location = new System.Drawing.Point(219, 159);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(57, 30);
            this.flatLabel5.TabIndex = 33;
            this.flatLabel5.Text = "اليوم";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flatLabel4.Location = new System.Drawing.Point(372, 146);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(70, 30);
            this.flatLabel4.TabIndex = 33;
            this.flatLabel4.Text = "التاريخ";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flatLabel3.Location = new System.Drawing.Point(550, 146);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(74, 30);
            this.flatLabel3.TabIndex = 33;
            this.flatLabel3.Text = "القسم ";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flatLabel2.Location = new System.Drawing.Point(714, 146);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(57, 30);
            this.flatLabel2.TabIndex = 33;
            this.flatLabel2.Text = "الرقم";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flatLabel1.Location = new System.Drawing.Point(810, 146);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(111, 30);
            this.flatLabel1.TabIndex = 33;
            this.flatLabel1.Text = "نوع المهمة";
            // 
            // flatComboBox1
            // 
            this.flatComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox1.ForeColor = System.Drawing.Color.White;
            this.flatComboBox1.FormattingEnabled = true;
            this.flatComboBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox1.ItemHeight = 18;
            this.flatComboBox1.Items.AddRange(new object[] {
            "فني مختبرات",
            "اداري"});
            this.flatComboBox1.Location = new System.Drawing.Point(698, 96);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(296, 24);
            this.flatComboBox1.TabIndex = 32;
            this.flatComboBox1.SelectedIndexChanged += new System.EventHandler(this.flatComboBox1_SelectedIndexChanged_1);
            // 
            // FlatMini
            // 
            this.FlatMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatMini.BackColor = System.Drawing.Color.White;
            this.FlatMini.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FlatMini.Font = new System.Drawing.Font("Marlett", 12F);
            this.FlatMini.Location = new System.Drawing.Point(975, 13);
            this.FlatMini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatMini.Name = "FlatMini";
            this.FlatMini.Size = new System.Drawing.Size(18, 18);
            this.FlatMini.TabIndex = 31;
            this.FlatMini.Text = "Minimize";
            this.FlatMini.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // FlatClose
            // 
            this.FlatClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatClose.BackColor = System.Drawing.Color.White;
            this.FlatClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FlatClose.Font = new System.Drawing.Font("Marlett", 10F);
            this.FlatClose.Location = new System.Drawing.Point(1011, 13);
            this.FlatClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatClose.Name = "FlatClose";
            this.FlatClose.Size = new System.Drawing.Size(18, 18);
            this.FlatClose.TabIndex = 30;
            this.FlatClose.Text = "Exit";
            this.FlatClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatStickyButton2
            // 
            this.flatStickyButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton2.Location = new System.Drawing.Point(36, 86);
            this.flatStickyButton2.Name = "flatStickyButton2";
            this.flatStickyButton2.Rounded = false;
            this.flatStickyButton2.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton2.TabIndex = 19;
            this.flatStickyButton2.Text = "عرض";
            this.flatStickyButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton2.Click += new System.EventHandler(this.flatStickyButton2_Click_1);
            // 
            // formSkin2
            // 
            this.formSkin2.BackColor = System.Drawing.Color.White;
            this.formSkin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formSkin2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin2.Controls.Add(this.metroDateTime1);
            this.formSkin2.Controls.Add(this.bunifuCustomDataGrid1);
            this.formSkin2.Controls.Add(this.flatLabel7);
            this.formSkin2.Controls.Add(this.flatComboBox5);
            this.formSkin2.Controls.Add(this.bunifuImageButton2);
            this.formSkin2.Controls.Add(this.bunifuImageButton1);
            this.formSkin2.Controls.Add(this.flatButton3);
            this.formSkin2.Controls.Add(this.flatButton4);
            this.formSkin2.Controls.Add(this.flatComboBox4);
            this.formSkin2.Controls.Add(this.flatLabel6);
            this.formSkin2.Controls.Add(this.flatComboBox2);
            this.formSkin2.Controls.Add(this.bunifuSeparator1);
            this.formSkin2.Controls.Add(this.flatMax1);
            this.formSkin2.Controls.Add(this.flatTextBox2);
            this.formSkin2.Controls.Add(this.flatComboBox3);
            this.formSkin2.Controls.Add(this.flatLabel5);
            this.formSkin2.Controls.Add(this.flatLabel4);
            this.formSkin2.Controls.Add(this.flatLabel3);
            this.formSkin2.Controls.Add(this.flatLabel2);
            this.formSkin2.Controls.Add(this.flatLabel1);
            this.formSkin2.Controls.Add(this.flatComboBox1);
            this.formSkin2.Controls.Add(this.FlatMini);
            this.formSkin2.Controls.Add(this.FlatClose);
            this.formSkin2.Controls.Add(this.flatStickyButton2);
            this.formSkin2.Controls.Add(this.flatStickyButton1);
            this.formSkin2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin2.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin2.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin2.HeaderMaximize = false;
            this.formSkin2.Location = new System.Drawing.Point(0, 0);
            this.formSkin2.Name = "formSkin2";
            this.formSkin2.Size = new System.Drawing.Size(1042, 685);
            this.formSkin2.TabIndex = 4;
            this.formSkin2.Text = "مهمة جديدة فني مختبرات";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labsupportBindingSource, "task_date", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(342, 187);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(126, 39);
            this.metroDateTime1.TabIndex = 62;
            this.metroDateTime1.Value = new System.DateTime(2018, 7, 24, 0, 0, 0, 0);
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(368, 86);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton1.TabIndex = 20;
            this.flatStickyButton1.Text = "تحرير";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click_1);
            // 
            // lab_supportTableAdapter
            // 
            this.lab_supportTableAdapter.ClearBeforeFill = true;
            // 
            // LNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 685);
            this.Controls.Add(this.formSkin2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LNewTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "q\\\\\\\\sd";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.LNewTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsupportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_managmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.formSkin2.ResumeLayout(false);
            this.formSkin2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private FlatUI.FlatLabel flatLabel7;
        private FlatUI.FlatComboBox flatComboBox5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatComboBox flatComboBox4;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatComboBox flatComboBox2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatComboBox flatComboBox3;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatComboBox flatComboBox1;
        private FlatUI.FlatMini FlatMini;
        private FlatUI.FlatClose FlatClose;
        private FlatUI.FlatStickyButton flatStickyButton2;
        private FlatUI.FormSkin formSkin2;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private task_managmentDataSet task_managmentDataSet;
        private System.Windows.Forms.BindingSource labsupportBindingSource;
        private task_managmentDataSetTableAdapters.lab_supportTableAdapter lab_supportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasknumberLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}