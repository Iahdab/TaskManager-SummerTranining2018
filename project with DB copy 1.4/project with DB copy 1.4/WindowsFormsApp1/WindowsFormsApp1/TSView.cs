using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TSView : Form
    {
        int TSorM;
        int ViewTybe;
        String PC = "";


        public TSView()
        {
            InitializeComponent();
            this.flatLabel3.Text = DateTime.Now.ToShortDateString();
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يودي على تحرير فني
            new TSEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // no thing
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            //  يودي على صفحة عرض طباعه فني 

            if (flatComboBox2.Text == "")
            {

                MessageBox.Show("الرجاء ملء الحقول المطلوبة");

                return;
            }
            else
            {
                if (flatComboBox2.Text=="سنوي")
                 {
                Properties.Settings.Default.ConditionString = "SELECT Query1.t, Query1.DYear, Query1.device_number FROM Query1 WHERE(((Query1.device_number) ='" + flatTextBox1.Text + "'))";

            
             
                 }
                 else
                {
                Properties.Settings.Default.ConditionString = "SELECT Query2.t, Query2.Dyear FROM Query2 WHERE(((Query2.device_number) = '" + flatTextBox1.Text + "'))";
                 }
            }

            if (ViewTybe == 1)
            PC = flatTextBox1.Text.ToString();
            new TSPDFView(metroDateTime1.Value.ToShortDateString(),metroDateTime2.Value.ToShortDateString(),flatComboBox2.SelectedIndex,TSorM,ViewTybe,PC).Show();
            this.Hide();
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (flatComboBox1.SelectedIndex == 0)
            {
                // يروح صفحة جديدة  فني 
                new TSNewTask().Show();
                this.Hide();
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {
                // يروح صفحة جديدة  فني اداري
                new TSMNewTask().Show();
                this.Hide();
            }
        }

        private void manager_CheckedChanged(object sender)
        {
            TSorM = 1;
            flatRadioButton2.Enabled = false;
        }

        private void tech_CheckedChanged(object sender)
        {
            TSorM = 0;
            flatRadioButton2.Enabled = true;


        }

        private void flatRadioButton1_CheckedChanged(object sender)
        {
            ViewTybe = 0;
            flatTextBox1.ReadOnly = true;
        }

        private void flatRadioButton2_CheckedChanged(object sender)
        {
            ViewTybe = 1;
            flatTextBox1.ReadOnly = false;
        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }
    }
}
