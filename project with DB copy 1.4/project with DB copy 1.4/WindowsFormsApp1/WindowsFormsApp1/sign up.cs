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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void flatButton1_Click(object sender, EventArgs e)
        {
            accountBindingSource.EndEdit();
            accountTableAdapter.Update(task_managmentDataSet.account);
            // first index is فني 
            if (flatComboBox1.SelectedIndex == 0)
            {
                // يدخل على صفحة مهمه جديدة فني
                new TSNewTask().Show();
                this.Hide();
            }
            // second  index is اداري 
            else if (flatComboBox1.SelectedIndex == 1)
            {
                new MNewTask().Show();
                this.Hide(); 
            }

            // last index is فني مختبرات 
            else if (flatComboBox1.SelectedIndex == 2)
            {
                new LNewTask().Show();
                this.Hide();
            }

        }

        private void flatLabel3_Click(object sender, EventArgs e)
        {

        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel2_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.task_managmentDataSet.account);

        }
    }
}
