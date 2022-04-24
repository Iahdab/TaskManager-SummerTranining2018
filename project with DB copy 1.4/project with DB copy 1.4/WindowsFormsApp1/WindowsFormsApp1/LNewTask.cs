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
    public partial class LNewTask : Form
    {
        public LNewTask()
        {
            InitializeComponent();
          //  metroDateTime1.Value=
            
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يودي على تحرير مختبرات 
         //   new LEdit().Show();
          //  this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // يودي على عرض مختبرات
           // new LVew().Show();
          //  this.Hide();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            // يودي على عرض طباعة مختبرات
          //  new LPDFView().Show();
          //  this.Hide();
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 0)
            {
               // no thing
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {
                // يروح صفحة جديدة  مختبرات اداري
                //  new  LMNewTask().Show();
                //  this.Hide();
              //  new LMNewTask().Show();
               // this.Hide();
            }
        }

        private void flatComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 0)
            {
                // no thing
            }

            else if (flatComboBox1.SelectedIndex == 1)
            {
                // يروح صفحة جديدة  مختبرات اداري
           
                  new LMNewTask().Show();
                  this.Hide();
            }
        }

        private void flatStickyButton1_Click_1(object sender, EventArgs e)
        {
            // يودي على تحرير مختبرات 
           new LEdit().Show();
           this.Hide();
        }

        private void flatStickyButton2_Click_1(object sender, EventArgs e)
        {

            // يودي على عرض مختبرات
            new LVew().Show();
            this.Hide();
        }

        private void LNewTask_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.lab_support' table. You can move, or remove it, as needed.
            this.lab_supportTableAdapter.Fill(this.task_managmentDataSet.lab_support);
            this.flatLabel7.Text = DateTime.Now.ToShortDateString();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            labsupportBindingSource.RemoveCurrent();
            lab_supportTableAdapter.Update(task_managmentDataSet.lab_support);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            labsupportBindingSource.AddNew();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            labsupportBindingSource.EndEdit();
           lab_supportTableAdapter.Update(task_managmentDataSet.lab_support);
        }

        private void flatButton3_Click_1(object sender, EventArgs e)
        {
            new LVew().Show();
            this.Hide();

        }
    }
}

