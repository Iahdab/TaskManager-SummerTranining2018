using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class TSNewTask : Form
    {
        public TSNewTask()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.technical_support' table. You can move, or remove it, as needed.
            this.technical_supportTableAdapter.Fill(this.task_managmentDataSet.technical_support);


        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // تودي على تحرير فني

            new TSEdit().Show();
            this.Hide();
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 0)
            {
              // nothing
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {

                new TSMNewTask().Show();
                this.Hide();
            }
           
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // تودي على عرض فني
            new TSView().Show();
            this.Hide();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            technicalsupportBindingSource.EndEdit();
            technical_supportTableAdapter.Update(task_managmentDataSet.technical_support);
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // تودي على عرض الطباعه فني
            new TSView().Show();
            this.Hide();
        }

        private void formSkin2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            technicalsupportBindingSource.AddNew();
            flatLabel8.Text = DateTime.Now.ToShortDateString();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            technicalsupportBindingSource.RemoveCurrent();
            technical_supportTableAdapter.Update(task_managmentDataSet.technical_support);
        }
    }
}
    