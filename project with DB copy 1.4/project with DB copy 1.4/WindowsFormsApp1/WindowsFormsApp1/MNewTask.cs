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
    public partial class MNewTask : Form
    {
        public MNewTask()
        {
            InitializeComponent();
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
           // يدخل على تحرير اداري
            new MEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
           // يدخل على عرض اداري
            new MView().Show();
            this.Hide();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // يدخل على عرض طباعة اداري
           new MView().Show();
           this.Hide();
        }

        private void flatStickyButton3_Click(object sender, EventArgs e)
        {
            // no thing
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            // حفظ يودي على عرض اداري

            //   new MView().Show();
            //  this.Hide();
            managerBindingSource.EndEdit();
            managerTableAdapter.Update(task_managmentDataSet.manager);
        }

        private void MNewTask_Load(object sender, EventArgs e)
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
    }
}
