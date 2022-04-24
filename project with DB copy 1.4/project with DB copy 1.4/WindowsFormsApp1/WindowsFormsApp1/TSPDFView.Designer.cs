namespace WindowsFormsApp1
{
    partial class TSPDFView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formSkin1 = new FlatUI.FormSkin();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ViewChart = new FlatUI.FlatRadioButton();
            this.ViweData = new FlatUI.FlatRadioButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.flatMax1 = new FlatUI.FlatMax();
            this.FlatMini = new FlatUI.FlatMini();
            this.FlatClose = new FlatUI.FlatClose();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatComboBox1 = new FlatUI.FlatComboBox();
            this.flatStickyButton2 = new FlatUI.FlatStickyButton();
            this.flatStickyButton1 = new FlatUI.FlatStickyButton();
            this.formSkin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.bunifuCustomDataGrid1);
            this.formSkin1.Controls.Add(this.ViewChart);
            this.formSkin1.Controls.Add(this.ViweData);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.bunifuImageButton2);
            this.formSkin1.Controls.Add(this.flatMax1);
            this.formSkin1.Controls.Add(this.FlatMini);
            this.formSkin1.Controls.Add(this.FlatClose);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.flatComboBox1);
            this.formSkin1.Controls.Add(this.flatStickyButton2);
            this.formSkin1.Controls.Add(this.flatStickyButton1);
            this.formSkin1.Controls.Add(this.chart1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(1043, 685);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "(PDF) عرض فني دعم";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(24, 197);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1000, 420);
            this.chart1.TabIndex = 57;
            this.chart1.Text = "chart1";
            // 
            // ViewChart
            // 
            this.ViewChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ViewChart.Checked = false;
            this.ViewChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewChart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ViewChart.Location = new System.Drawing.Point(564, 159);
            this.ViewChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewChart.Name = "ViewChart";
            this.ViewChart.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.ViewChart.Size = new System.Drawing.Size(192, 22);
            this.ViewChart.TabIndex = 56;
            this.ViewChart.Text = "رسومات بيانية";
            this.ViewChart.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.ViewChart_CheckedChanged);
            // 
            // ViweData
            // 
            this.ViweData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ViweData.Checked = false;
            this.ViweData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViweData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ViweData.Location = new System.Drawing.Point(361, 159);
            this.ViweData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViweData.Name = "ViweData";
            this.ViweData.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.ViweData.Size = new System.Drawing.Size(181, 22);
            this.ViweData.TabIndex = 55;
            this.ViweData.Text = "سجل البيانات";
            this.ViweData.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.ViweData_CheckedChanged);
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(24, 197);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 29;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1000, 420);
            this.bunifuCustomDataGrid1.TabIndex = 54;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(404, 13);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(42, 21);
            this.flatLabel1.TabIndex = 53;
            this.flatLabel1.Text = "Date";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApp1.Properties.Resources.icons8_undo_96;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton2.Location = new System.Drawing.Point(378, 626);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(57, 46);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 52;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(942, 13);
            this.flatMax1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 41;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // FlatMini
            // 
            this.FlatMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatMini.BackColor = System.Drawing.Color.White;
            this.FlatMini.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FlatMini.Font = new System.Drawing.Font("Marlett", 12F);
            this.FlatMini.Location = new System.Drawing.Point(976, 13);
            this.FlatMini.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlatMini.Name = "FlatMini";
            this.FlatMini.Size = new System.Drawing.Size(18, 18);
            this.FlatMini.TabIndex = 31;
            this.FlatMini.Text = "Minimize";
            this.FlatMini.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FlatMini.Click += new System.EventHandler(this.FlatMini_Click);
            // 
            // FlatClose
            // 
            this.FlatClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatClose.BackColor = System.Drawing.Color.White;
            this.FlatClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FlatClose.Font = new System.Drawing.Font("Marlett", 10F);
            this.FlatClose.Location = new System.Drawing.Point(1012, 13);
            this.FlatClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlatClose.Name = "FlatClose";
            this.FlatClose.Size = new System.Drawing.Size(18, 18);
            this.FlatClose.TabIndex = 30;
            this.FlatClose.Text = "Exit";
            this.FlatClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FlatClose.Click += new System.EventHandler(this.FlatClose_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(454, 641);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(154, 32);
            this.flatButton1.TabIndex = 27;
            this.flatButton1.Text = "حفظ ";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
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
            this.flatComboBox1.Location = new System.Drawing.Point(710, 96);
            this.flatComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatComboBox1.Name = "flatComboBox1";
            this.flatComboBox1.Size = new System.Drawing.Size(296, 24);
            this.flatComboBox1.TabIndex = 21;
            this.flatComboBox1.SelectedIndexChanged += new System.EventHandler(this.flatComboBox1_SelectedIndexChanged);
            // 
            // flatStickyButton2
            // 
            this.flatStickyButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton2.Location = new System.Drawing.Point(36, 87);
            this.flatStickyButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatStickyButton2.Name = "flatStickyButton2";
            this.flatStickyButton2.Rounded = false;
            this.flatStickyButton2.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton2.TabIndex = 19;
            this.flatStickyButton2.Text = "عرض";
            this.flatStickyButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton2.Click += new System.EventHandler(this.flatStickyButton2_Click);
            // 
            // flatStickyButton1
            // 
            this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatStickyButton1.Location = new System.Drawing.Point(368, 87);
            this.flatStickyButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flatStickyButton1.Name = "flatStickyButton1";
            this.flatStickyButton1.Rounded = false;
            this.flatStickyButton1.Size = new System.Drawing.Size(296, 45);
            this.flatStickyButton1.TabIndex = 20;
            this.flatStickyButton1.Text = "تحرير";
            this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click);
            // 
            // TSPDFView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 685);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TSPDFView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatComboBox flatComboBox1;
        private FlatUI.FlatStickyButton flatStickyButton2;
        private FlatUI.FlatStickyButton flatStickyButton1;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatMini FlatMini;
        private FlatUI.FlatClose FlatClose;
        private FlatUI.FlatMax flatMax1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatRadioButton ViewChart;
        private FlatUI.FlatRadioButton ViweData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}