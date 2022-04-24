namespace WindowsFormsApp1
{
    partial class TSView
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
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.flatRadioButton2 = new FlatUI.FlatRadioButton();
            this.flatRadioButton1 = new FlatUI.FlatRadioButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatMax1 = new FlatUI.FlatMax();
            this.FlatMini = new FlatUI.FlatMini();
            this.FlatClose = new FlatUI.FlatClose();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatComboBox2 = new FlatUI.FlatComboBox();
            this.flatStickyButton2 = new FlatUI.FlatStickyButton();
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.manager = new FlatUI.FlatRadioButton();
            this.tech = new FlatUI.FlatRadioButton();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.formSkin1.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.SuspendLayout();
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
            "فني دعم",
            "اداري"});
            this.flatComboBox1.Location = new System.Drawing.Point(692, 107);
            this.flatComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(296, 24);
            this.flatComboBox1.TabIndex = 35;
            this.flatComboBox1.SelectedIndexChanged += new System.EventHandler(this.flatComboBox1_SelectedIndexChanged);
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(361, 100);
            this.flatStickyButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton1.TabIndex = 34;
            this.flatStickyButton1.Text = "تحرير";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(429, 514);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(142, 28);
            this.flatLabel2.TabIndex = 51;
            this.flatLabel2.Text = "ادخل رقم الجهاز ";
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(409, 565);
            this.flatTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = true;
            this.flatTextBox1.Size = new System.Drawing.Size(202, 38);
            this.flatTextBox1.TabIndex = 50;
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            this.flatTextBox1.TextChanged += new System.EventHandler(this.flatTextBox1_TextChanged);
            // 
            // flatRadioButton2
            // 
            this.flatRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatRadioButton2.Checked = false;
            this.flatRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton2.Enabled = false;
            this.flatRadioButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatRadioButton2.Location = new System.Drawing.Point(9, 30);
            this.flatRadioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatRadioButton2.Name = "flatRadioButton2";
            this.flatRadioButton2.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flatRadioButton2.Size = new System.Drawing.Size(168, 22);
            this.flatRadioButton2.TabIndex = 1;
            this.flatRadioButton2.Text = "تقرير لجهاز معين";
            this.flatRadioButton2.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.flatRadioButton2_CheckedChanged);
            // 
            // flatRadioButton1
            // 
            this.flatRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatRadioButton1.Checked = false;
            this.flatRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatRadioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatRadioButton1.Location = new System.Drawing.Point(198, 30);
            this.flatRadioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatRadioButton1.Name = "flatRadioButton1";
            this.flatRadioButton1.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.flatRadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flatRadioButton1.Size = new System.Drawing.Size(188, 22);
            this.flatRadioButton1.TabIndex = 1;
            this.flatRadioButton1.Text = "مجمل التقارير";
            this.flatRadioButton1.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.flatRadioButton1_CheckedChanged);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(144, 221);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(181, 43);
            this.flatButton1.TabIndex = 44;
            this.flatButton1.Text = "تاكيد";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(935, 13);
            this.flatMax1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.FlatMini.Location = new System.Drawing.Point(969, 13);
            this.FlatMini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.FlatClose.Location = new System.Drawing.Point(1005, 13);
            this.FlatClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlatClose.Name = "FlatClose";
            this.FlatClose.Size = new System.Drawing.Size(18, 18);
            this.FlatClose.TabIndex = 41;
            this.FlatClose.Text = "Exit";
            this.FlatClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Search_52px;
            this.pictureBox1.Location = new System.Drawing.Point(577, 514);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(75, 390);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(859, 10);
            this.bunifuSeparator1.TabIndex = 47;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(805, 191);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(119, 28);
            this.flatLabel1.TabIndex = 46;
            this.flatLabel1.Text = "نوع التصنيف";
            // 
            // flatComboBox2
            // 
            this.flatComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flatComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flatComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flatComboBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatComboBox2.ForeColor = System.Drawing.Color.White;
            this.flatComboBox2.FormattingEnabled = true;
            this.flatComboBox2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatComboBox2.ItemHeight = 18;
            this.flatComboBox2.Items.AddRange(new object[] {
            "شهري",
            "سنوي"});
            this.flatComboBox2.Location = new System.Drawing.Point(717, 240);
            this.flatComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatComboBox2.Name = "flatComboBox2";
            this.flatComboBox2.Size = new System.Drawing.Size(208, 24);
            this.flatComboBox2.TabIndex = 45;
            // 
            // flatStickyButton2
            // 
            this.flatStickyButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton2.Location = new System.Drawing.Point(30, 100);
            this.flatStickyButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatStickyButton2.Name = "flatStickyButton2";
            this.flatStickyButton2.Rounded = false;
            this.flatStickyButton2.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton2.TabIndex = 33;
            this.flatStickyButton2.Text = "عرض";
            this.flatStickyButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton2.Click += new System.EventHandler(this.flatStickyButton2_Click);
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatGroupBox2);
            this.formSkin1.Controls.Add(this.flatGroupBox1);
            this.formSkin1.Controls.Add(this.flatLabel5);
            this.formSkin1.Controls.Add(this.flatLabel4);
            this.formSkin1.Controls.Add(this.flatLabel3);
            this.formSkin1.Controls.Add(this.metroDateTime2);
            this.formSkin1.Controls.Add(this.metroDateTime1);
            this.formSkin1.Controls.Add(this.pictureBox1);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.bunifuSeparator1);
            this.formSkin1.Controls.Add(this.flatTextBox1);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.flatComboBox2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.FlatMini);
            this.formSkin1.Controls.Add(this.FlatClose);
            this.formSkin1.Controls.Add(this.flatComboBox1);
            this.formSkin1.Controls.Add(this.flatStickyButton2);
            this.formSkin1.Controls.Add(this.flatStickyButton1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1043, 685);
            this.formSkin1.TabIndex = 2;
            this.formSkin1.Text = "عرض فني دعم";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Controls.Add(this.flatRadioButton2);
            this.flatGroupBox2.Controls.Add(this.flatRadioButton1);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(314, 420);
            this.flatGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(360, 89);
            this.flatGroupBox2.TabIndex = 61;
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox1.Controls.Add(this.manager);
            this.flatGroupBox1.Controls.Add(this.tech);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox1.Location = new System.Drawing.Point(361, 171);
            this.flatGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(264, 132);
            this.flatGroupBox1.TabIndex = 60;
            // 
            // manager
            // 
            this.manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.manager.Checked = false;
            this.manager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.manager.Location = new System.Drawing.Point(163, 59);
            this.manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manager.Name = "manager";
            this.manager.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.manager.Size = new System.Drawing.Size(100, 22);
            this.manager.TabIndex = 59;
            this.manager.Text = "إداري";
            this.manager.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.manager_CheckedChanged);
            // 
            // tech
            // 
            this.tech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tech.Checked = false;
            this.tech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tech.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tech.Location = new System.Drawing.Point(28, 59);
            this.tech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tech.Name = "tech";
            this.tech.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.tech.Size = new System.Drawing.Size(100, 22);
            this.tech.TabIndex = 58;
            this.tech.Text = "فني";
            this.tech.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.tech_CheckedChanged);
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(870, 329);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(74, 38);
            this.flatLabel5.TabIndex = 57;
            this.flatLabel5.Text = ": من ";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(373, 329);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(70, 38);
            this.flatLabel4.TabIndex = 56;
            this.flatLabel4.Text = ": إلى";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(406, 13);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(42, 21);
            this.flatLabel3.TabIndex = 55;
            this.flatLabel3.Text = "Date";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Location = new System.Drawing.Point(109, 329);
            this.metroDateTime2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(259, 39);
            this.metroDateTime2.TabIndex = 54;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(577, 328);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(287, 39);
            this.metroDateTime1.TabIndex = 53;
            // 
            // TSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 685);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TSView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatComboBox flatComboBox1;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatRadioButton flatRadioButton2;
        private FlatUI.FlatRadioButton flatRadioButton1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatMini FlatMini;
        private FlatUI.FlatClose FlatClose;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatComboBox flatComboBox2;
        private FlatUI.FlatStickyButton flatStickyButton2;
        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private FlatUI.FlatRadioButton manager;
        private FlatUI.FlatRadioButton tech;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatGroupBox flatGroupBox1;
    }
}