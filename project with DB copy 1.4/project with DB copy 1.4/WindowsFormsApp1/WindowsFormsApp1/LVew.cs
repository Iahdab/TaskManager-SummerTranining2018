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
    public partial class LVew : Form
    {
        int tybe; // technical or manager.


        public LVew()
        {
            InitializeComponent();
            this.flatLabel4.Text= DateTime.Now.ToShortDateString();
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
                new LMNewTask().Show();
                this.Hide();
            }
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يفتح صفحة تحرير المختبرات
            new LEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // no thing
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            // تودي لعرض الطباعه
            new LPDFView(metroDateTime1.Value.ToShortDateString(),metroDateTime2.Value.ToShortDateString(),flatComboBox2.SelectedIndex,tybe).Show();
            this.Hide();
        }

        private void manager_CheckedChanged(object sender)
        {
            tybe = 1;
        }

        private void tech_CheckedChanged(object sender)
        {
            tybe = 0;
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }
    }
}
