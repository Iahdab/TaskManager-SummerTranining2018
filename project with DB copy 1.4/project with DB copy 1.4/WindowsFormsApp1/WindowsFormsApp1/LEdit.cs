using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class LEdit : Form
    {
        private OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dt;
        OleDbCommand cmd;
        int type;
        int indexCol;
        int num;
        string vlaue;
        string[] leditValues = new string[6];

        public LEdit()
        {
            InitializeComponent();
            this.flatLabel1.Text = DateTime.Now.ToShortDateString();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task managment.accdb";
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // no thing.
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // يفتح صفحة عرض المختبرات
            new LVew().Show();
            this.Hide();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // يفتح صفحة عرض الطباعه مختبرات 
          //  new LPDFView().Show();
           // this.Hide();
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

        private void flatButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void LEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.lab_support' table. You can move, or remove it, as needed.
            // this.lab_supportTableAdapter.Fill(this.task_managmentDataSet.lab_support);
            //this.managerTableAdapter.Fill(this.task_managmentDataSet.manager);


        }

        private void formSkin2_Click(object sender, EventArgs e)
        {

        }

        private void flatRadioButton1_CheckedChanged(object sender)
        {
            type = 0;

            con.Open();
            ad = new OleDbDataAdapter("SELECT * FROM lab_support", con);
            dt = new DataTable();
            ad.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();

            CLEAN_VALUES();
        }

        private void flatRadioButton2_CheckedChanged(object sender)
        {
            type = 1;
            con.Open();
            ad = new OleDbDataAdapter("SELECT * FROM manager", con);
            dt = new DataTable();
            ad.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();

            CLEAN_VALUES();
        }

        private void flatButton2_Click_1(object sender, EventArgs e)
        {
            new LVew().Show();
            this.Hide();

        }

        private void flatButton1_Click_1(object sender, EventArgs e)
        {
            //--------------------------------lab_support-----------------------------------------
            if (type == 0)
            {

                con.Open();

                string strdate = metroDateTime1.Value.ToShortDateString();//metroDateTime1.Value.ToString("MM'/'dd'/'yyyy");
                ad = new OleDbDataAdapter("SELECT * FROM lab_support WHERE task_date Like '" + strdate + "%'", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;

                con.Close();



            }

            //--------------------------------manager-----------------------------------------------
            if (type == 1)
            {
                con.Open();

                string strdate = metroDateTime1.Value.ToShortDateString();//metroDateTime1.Value.ToString("MM'/'dd'/'yyyy");
                ad = new OleDbDataAdapter("SELECT * FROM manager WHERE start_date Like '" + strdate + "%' OR finsh_date Like '" + strdate + "%'", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;

                con.Close();

            }

            //--------------------------------------------------------------------------------------
            CLEAN_VALUES();
        }

        //------------------------------------------CONNECTION----------------------------------------------
        private void connection(string sql)
        {

            cmd = new OleDbCommand(sql, con);

            //OPEN CON,UPDATE,RETRIEVE DGVIEW
            try
            {
                con.Open();

                ad = new OleDbDataAdapter(cmd);
                ad.UpdateCommand = con.CreateCommand();
                ad.UpdateCommand.CommandText = sql;
                ad.UpdateCommand.ExecuteNonQuery();

                con.Close();

                //-------------------------------------------------------------------------------------------
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        //-----------------------------------CLEAN VALUES FROM ROWS---------------------------------------------

        private void CLEAN_VALUES()
        {
            leditValues = new string[6];
            num = -1;
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            updateLEDIT();
            if (leditValues[0] != null || leditValues[1] != null || leditValues[2] != null || leditValues[3] != null || leditValues[4] != null || leditValues[5] != null)
            {
                MessageBox.Show("تم عملية التحديث بنجاح", "تحديث البيانات");
            }
            CLEAN_VALUES();
           // MessageBox.Show("تم عملية التحديث بنجاح", "تحديث البيانات");
        }

        //-----------------------------------------UPDATE LEdit-----------------------------------------------

        private void updateLEDIT()
        {

            string sql = null;
            //---------------------------------------QUERY FOR LAB_SUPPORT----------------------------------------
            if (type == 0)
            {
                if (leditValues[0] != null)
                {
                    sql = "UPDATE lab_support SET task_type='" + leditValues[0] + "' WHERE task_number_L=" + num + "";
                    connection(sql);
                }
                if (leditValues[1] != null)
                {

                    sql = "UPDATE lab_support SET lab_number='" + leditValues[1] + "' WHERE task_number_L=" + num + "";
                    connection(sql);
                }
                if (leditValues[2] != null)
                {

                    sql = "UPDATE lab_support SET department='" + leditValues[2] + "' WHERE task_number_L=" + num + "";
                    connection(sql);
                }
                if (leditValues[3] != null)
                {

                    sql = "UPDATE lab_support SET task_date='" + leditValues[3] + "' WHERE task_number_L=" + num + "";
                    connection(sql);
                }
                if (leditValues[4] != null)
                {

                    sql = "UPDATE lab_support SET [day]='" + leditValues[4] + "' WHERE task_number_L=" + num + "";
                    connection(sql);
                }
                if (leditValues[5] != null)
                {

                    sql = "UPDATE lab_support SET state='" + leditValues[5] + "' WHERE task_number_L=" + num + "";
                    connection(sql);
                }


            }
            //--------------------------------------QUERY FOR MANAGER------------------------------------
            if (type == 1)
            {

                if (leditValues[0] != null)
                {

                    sql = "UPDATE manager SET report_type='" + leditValues[0] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (leditValues[1] != null)
                {

                    sql = "UPDATE manager SET report_number='" + leditValues[1] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (leditValues[2] != null)
                {

                    sql = "UPDATE manager SET department='" + leditValues[2] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (leditValues[3] != null)
                {

                    sql = "UPDATE manager SET start_date='" + leditValues[3] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (leditValues[4] != null)
                {

                    sql = "UPDATE manager SET finsh_date='" + leditValues[4] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (leditValues[5] != null)
                {

                    sql = "UPDATE manager SET state='" + leditValues[5] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }



            }


        }

        private void bunifuCustomDataGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            num = Convert.ToInt32(bunifuCustomDataGrid1[0, e.RowIndex].Value.ToString());
            indexCol = e.ColumnIndex;
            vlaue = bunifuCustomDataGrid1[e.ColumnIndex, e.RowIndex].Value.ToString();

            if (indexCol == 1)
            {

                leditValues[0] = vlaue;
            }
            if (indexCol == 2)
            {

                leditValues[1] = vlaue;
            }
            if (indexCol == 3)
            {

                leditValues[2] = vlaue;
            }
            if (indexCol == 4)
            {

                leditValues[3] = vlaue;
            }
            if (indexCol == 5)
            {

                leditValues[4] = vlaue;
            }
            if (indexCol == 6)
            {

                leditValues[5] = vlaue;
            }
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

                new LMNewTask().Show();
                this.Hide();
            }
        }
    }
}
