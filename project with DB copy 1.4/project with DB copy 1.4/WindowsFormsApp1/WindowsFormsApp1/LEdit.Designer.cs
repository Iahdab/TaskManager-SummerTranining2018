namespace WindowsFormsApp1
{
    partial class LEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flatButton3 = new FlatUI.FlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatMax1 = new FlatUI.FlatMax();
            this.FlatMini = new FlatUI.FlatMini();
            this.FlatClose = new FlatUI.FlatClose();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatStickyButton2 = new FlatUI.FlatStickyButton();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.formSkin1 = new FlatUI.FormSkin();
            this.formSkin2 = new FlatUI.FormSkin();
            this.flatRadioButton2 = new FlatUI.FlatRadioButton();
            this.flatRadioButton1 = new FlatUI.FlatRadioButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.flatButton2 = new FlatUI.FlatButton();
            this.task_managmentDataSet = new WindowsFormsApp1.task_managmentDataSet();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerTableAdapter = new WindowsFormsApp1.task_managmentDataSetTableAdapters.managerTableAdapter();
            this.tasknumberLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labsupportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab_supportTableAdapter = new WindowsFormsApp1.task_managmentDataSetTableAdapters.lab_supportTableAdapter();
            this.formSkin1.SuspendLayout();
            this.formSkin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_managmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsupportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(328, 628);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(154, 32);
            this.flatButton3.TabIndex = 29;
            this.flatButton3.Text = "حفظ التعديل";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(62, 212);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(910, 16);
            this.bunifuSeparator1.TabIndex = 47;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(866, 165);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(77, 32);
            this.flatLabel2.TabIndex = 46;
            this.flatLabel2.Text = "التاريخ";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(100, 159);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(182, 38);
            this.flatButton1.TabIndex = 44;
            this.flatButton1.Text = "تاكيد";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click_1);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(934, 13);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 43;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // FlatMini
            // 
            this.FlatMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatMini.BackColor = System.Drawing.Color.White;
            this.FlatMini.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FlatMini.Font = new System.Drawing.Font("Marlett", 12F);
            this.FlatMini.Location = new System.Drawing.Point(970, 13);
            this.FlatMini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatMini.Name = "FlatMini";
            this.FlatMini.Size = new System.Drawing.Size(18, 18);
            this.FlatMini.TabIndex = 42;
            this.FlatMini.Text = "Minimize";
            this.FlatMini.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // FlatClose
            // 
            this.FlatClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatClose.BackColor = System.Drawing.Color.White;
            this.FlatClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FlatClose.Font = new System.Drawing.Font("Marlett", 10F);
            this.FlatClose.Location = new System.Drawing.Point(1006, 13);
            this.FlatClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatClose.Name = "FlatClose";
            this.FlatClose.Size = new System.Drawing.Size(18, 18);
            this.FlatClose.TabIndex = 41;
            this.FlatClose.Text = "Exit";
            this.FlatClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
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
            this.flatComboBox1.Location = new System.Drawing.Point(694, 80);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(296, 24);
            this.flatComboBox1.TabIndex = 35;
            this.flatComboBox1.SelectedIndexChanged += new System.EventHandler(this.flatComboBox1_SelectedIndexChanged_1);
            // 
            // flatStickyButton2
            // 
            this.flatStickyButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton2.Location = new System.Drawing.Point(32, 72);
            this.flatStickyButton2.Name = "flatStickyButton2";
            this.flatStickyButton2.Rounded = false;
            this.flatStickyButton2.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton2.TabIndex = 33;
            this.flatStickyButton2.Text = "عرض";
            this.flatStickyButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton2.Click += new System.EventHandler(this.flatStickyButton2_Click_1);
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(363, 72);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton1.TabIndex = 34;
            this.flatStickyButton1.Text = "تحرير";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.formSkin2);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1042, 685);
            this.formSkin1.TabIndex = 3;
            this.formSkin1.Text = "تحرير";
            // 
            // formSkin2
            // 
            this.formSkin2.BackColor = System.Drawing.Color.White;
            this.formSkin2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin2.Controls.Add(this.flatRadioButton2);
            this.formSkin2.Controls.Add(this.flatRadioButton1);
            this.formSkin2.Controls.Add(this.flatLabel1);
            this.formSkin2.Controls.Add(this.bunifuCustomDataGrid1);
            this.formSkin2.Controls.Add(this.metroDateTime1);
            this.formSkin2.Controls.Add(this.flatButton2);
            this.formSkin2.Controls.Add(this.flatButton3);
            this.formSkin2.Controls.Add(this.bunifuSeparator1);
            this.formSkin2.Controls.Add(this.flatLabel2);
            this.formSkin2.Controls.Add(this.flatButton1);
            this.formSkin2.Controls.Add(this.flatMax1);
            this.formSkin2.Controls.Add(this.FlatMini);
            this.formSkin2.Controls.Add(this.FlatClose);
            this.formSkin2.Controls.Add(this.flatComboBox1);
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
            this.formSkin2.TabIndex = 1;
            this.formSkin2.Text = "تحرير فني مختبرات";
            this.formSkin2.Click += new System.EventHandler(this.formSkin2_Click);
            // 
            // flatRadioButton2
            // 
            this.flatRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatRadioButton2.Checked = false;
            this.flatRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatRadioButton2.Location = new System.Drawing.Point(492, 165);
            this.flatRadioButton2.Name = "flatRadioButton2";
            this.flatRadioButton2.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton2.Size = new System.Drawing.Size(100, 22);
            this.flatRadioButton2.TabIndex = 52;
            this.flatRadioButton2.Text = "اداري";
            this.flatRadioButton2.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.flatRadioButton2_CheckedChanged);
            // 
            // flatRadioButton1
            // 
            this.flatRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatRadioButton1.Checked = false;
            this.flatRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatRadioButton1.Location = new System.Drawing.Point(328, 165);
            this.flatRadioButton1.Name = "flatRadioButton1";
            this.flatRadioButton1.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton1.Size = new System.Drawing.Size(100, 22);
            this.flatRadioButton1.TabIndex = 51;
            this.flatRadioButton1.Text = "فني";
            this.flatRadioButton1.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.flatRadioButton1_CheckedChanged);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(435, 13);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(42, 21);
            this.flatLabel1.TabIndex = 50;
            this.flatLabel1.Text = "Date";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(62, 244);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 29;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(928, 377);
            this.bunifuCustomDataGrid1.TabIndex = 49;
            this.bunifuCustomDataGrid1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellEndEdit);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(628, 158);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 39);
            this.metroDateTime1.TabIndex = 48;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(534, 630);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(154, 32);
            this.flatButton2.TabIndex = 30;
            this.flatButton2.Text = "PDF حفظ";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click_1);
            // 
            // task_managmentDataSet
            // 
            this.task_managmentDataSet.DataSetName = "task_managmentDataSet";
            this.task_managmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "manager";
            this.managerBindingSource.DataSource = this.task_managmentDataSet;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
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
            // labsupportBindingSource
            // 
            this.labsupportBindingSource.DataMember = "lab_support";
            this.labsupportBindingSource.DataSource = this.task_managmentDataSet;
            // 
            // lab_supportTableAdapter
            // 
            this.lab_supportTableAdapter.ClearBeforeFill = true;
            // 
            // LEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 685);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.LEdit_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin2.ResumeLayout(false);
            this.formSkin2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_managmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labsupportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FlatUI.FlatButton flatButton3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatMini FlatMini;
        private FlatUI.FlatClose FlatClose;
        private FlatUI.FlatComboBox flatComboBox1;
        private FlatUI.FlatStickyButton flatStickyButton2;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FormSkin formSkin2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private FlatUI.FlatButton flatButton2;
        private FlatUI.FlatLabel flatLabel1;
        private task_managmentDataSet task_managmentDataSet;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private task_managmentDataSetTableAdapters.managerTableAdapter managerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasknumberLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private FlatUI.FlatRadioButton flatRadioButton2;
        private FlatUI.FlatRadioButton flatRadioButton1;
        private System.Windows.Forms.BindingSource labsupportBindingSource;
        private task_managmentDataSetTableAdapters.lab_supportTableAdapter lab_supportTableAdapter;
    }
}