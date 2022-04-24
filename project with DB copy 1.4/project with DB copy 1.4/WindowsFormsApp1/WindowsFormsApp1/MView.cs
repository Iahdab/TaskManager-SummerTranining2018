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
    public partial class MView : Form
    {
        public MView()
        {
            InitializeComponent();
            this.flatLabel4.Text = DateTime.Now.ToShortDateString();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            // يدخلك على عرض الطباعة 
            new MPDFView(metroDateTime1.Value.ToShortDateString(),metroDateTime2.Value.ToShortDateString(),flatComboBox2.SelectedIndex).Show();
            this.Hide();
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يدخلك على صفحة التحرير الاداري
            new MEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // no thing
        }

        private void flatStickyButton3_Click(object sender, EventArgs e)
        {
            // يدخل على مهمه جديدة اداري
            new MNewTask().Show();
            this.Hide();
        }
    }
}
