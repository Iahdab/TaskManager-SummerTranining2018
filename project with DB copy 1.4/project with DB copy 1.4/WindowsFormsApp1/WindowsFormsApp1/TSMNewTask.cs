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
    public partial class TSMNewTask : Form
    {
        public TSMNewTask()
        {
            InitializeComponent();
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يروح صفحة تحرير فني
            new TSEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // يروح عرض  فني
            new TSView().Show();
            this.Hide();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // يروح صفحة عرض طباعه فني
           new TSView().Show();
            this.Hide();
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 0)
            {
                new TSNewTask().Show();
                this.Hide();
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {

           // no thing
                }

            }

        private void TSMNewTask_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.task_managmentDataSet.manager);
            flatLabel7.Text = DateTime.Now.ToShortDateString();


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            managerBindingSource.AddNew();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            managerBindingSource.RemoveCurrent();
            managerTableAdapter.Update(task_managmentDataSet.manager);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            managerBindingSource.EndEdit();
            managerTableAdapter.Update(task_managmentDataSet.manager);

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


