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
    public partial class LMNewTask : Form
    {
        public LMNewTask()
        {
            InitializeComponent();
          
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 0)
            {
                new LNewTask().Show();
                this.Hide();
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {

                // nothing
            }
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يفتح صفحة تحرير المختبرات
            new LEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        { //  يفتح صفحة عرض المختبرات 
            new LVew().Show();
            this.Hide();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // يفتح صفحة الطباعه المختبرات
           // new LPDFView().Show();
            //this.Hide();
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void LMNewTask_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.task_managmentDataSet.manager);
            this.flatLabel7.Text = DateTime.Now.ToShortDateString();

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

        private void flatButton2_Click_1(object sender, EventArgs e)
        {
            new LVew().Show();
            this.Hide();
        }

        private void flatStickyButton1_Click_1(object sender, EventArgs e)
        {
            new LEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click_1(object sender, EventArgs e)
        {
            new LVew().Show();
            this.Hide();
        }

        private void flatComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 0)
            {
                new LNewTask().Show();
                this.Hide();
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {

                // nothing
            }
        }
    }
}
