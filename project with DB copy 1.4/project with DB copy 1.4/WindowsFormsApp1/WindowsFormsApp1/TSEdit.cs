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
    public partial class TSEdit : Form

    {
        private OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dt;
        OleDbCommand cmd;
        int type;
        int indexCol;
        string vlaue;
        int num = -1;
        string[] tseditValues = new string[7];

        public TSEdit()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task managment.accdb";
            this.flatLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // no thing
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            //  يودي على عرض فني
            new TSView().Show();
            this.Hide();

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            //--------------------------------technical_support----------------------------
            if (type == 0)
            {
                con.Open();
                string date = metroDateTime1.Value.ToShortDateString();///metroDateTime1.Value.ToString("MM'/'dd'/'yyyy");
                ad = new OleDbDataAdapter("Select * from technical_support  where task_date_default = #" + date + "#", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }

            //--------------------------------manager----------------------------
            if (type == 1)
            {
                con.Open();
                string date = metroDateTime1.Value.ToShortDateString();///metroDateTime1.Value.ToString("MM'/'dd'/'yyyy");
                // ad = new OleDbDataAdapter("SELECT * FROM manager WHERE start_date = '" + date + "' OR finsh_date = '" + date + "'", con);
                ad = new OleDbDataAdapter("SELECT * FROM manager WHERE start_date Like '" + date + "%' OR finsh_date Like '" + date + "%'", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;

                con.Close();
            }
            // CLEAN VALUE FROM ROWS
            CLEAN_VALUES();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            // يفتح صفحة عرض طباعه فني
            new TSView().Show();
            this.Hide();
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // فني او اداري

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

        private void flatRadioButton1_CheckedChanged(object sender)
        {
            type = 0;
            con.Open();
            ad = new OleDbDataAdapter("Select task_number_T,requester,device_number,department,task,start_time,finsh_time,state from technical_support", con);
            dt = new DataTable();
            ad.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
            CLEAN_VALUES();
        }

        private void TSEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.technical_support' table. You can move, or remove it, as needed.
            // this.technical_supportTableAdapter.Fill(this.task_managmentDataSet.technical_support);
            // TODO: This line of code loads data into the 'task_managmentDataSet.manager' table. You can move, or remove it, as needed.
            //  this.managerTableAdapter.Fill(this.task_managmentDataSet.manager);
            // flatRadioButton1.Checked = true;


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

        private void flatButton3_Click(object sender, EventArgs e)
        {
            updateTSEdit();
            if (tseditValues[0] != null || tseditValues[1] != null || tseditValues[2] != null || tseditValues[3] != null || tseditValues[4] != null || tseditValues[5] != null || tseditValues[6] != null)
            {
                MessageBox.Show("تم عملية التحديث بنجاح", "تحديث البيانات");
            }
            CLEAN_VALUES();
            //MessageBox.Show("تم عملية التحديث بنجاح", "تحديث البيانات");
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //----------------------------------------UPDATE TSEdit------------------------------------------------
        private void updateTSEdit()
        {

            string sql = null;
            //---------------------------------QUERY FOR TECHNICAL_SUPPORT------------------------------------
            if (type == 0)
            {
                if (tseditValues[0] != null)
                {
                    sql = "UPDATE technical_support SET requester='" + tseditValues[0] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }
                if (tseditValues[1] != null)
                {

                    sql = "UPDATE technical_support SET device_number='" + tseditValues[1] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }
                if (tseditValues[2] != null)
                {

                    sql = "UPDATE technical_support SET department='" + tseditValues[2] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }
                if (tseditValues[3] != null)
                {

                    sql = "UPDATE technical_support SET task='" + tseditValues[3] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }
                if (tseditValues[4] != null)
                {

                    sql = "UPDATE technical_support SET start_time='" + tseditValues[4] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }
                if (tseditValues[5] != null)
                {

                    sql = "UPDATE technical_support SET finsh_time='" + tseditValues[5] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }
                if (tseditValues[6] != null)
                {

                    sql = "UPDATE technical_support SET state='" + tseditValues[6] + "' WHERE task_number_T=" + num + "";
                    connection(sql);
                }

                //------------------------------------- END CONDITIONS --------------------------------------

            }
            //--------------------------------- QUERY FOR MANAGER ---------------------------------------
            if (type == 1)
            {

                if (tseditValues[0] != null)
                {

                    sql = "UPDATE manager SET report_type='" + tseditValues[0] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (tseditValues[1] != null)
                {

                    sql = "UPDATE manager SET report_number='" + tseditValues[1] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (tseditValues[2] != null)
                {

                    sql = "UPDATE manager SET department='" + tseditValues[2] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (tseditValues[3] != null)
                {

                    sql = "UPDATE manager SET start_date='" + tseditValues[3] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (tseditValues[4] != null)
                {

                    sql = "UPDATE manager SET finsh_date='" + tseditValues[4] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }
                if (tseditValues[5] != null)
                {

                    sql = "UPDATE manager SET state='" + tseditValues[5] + "' WHERE task_number_M=" + num + "";
                    connection(sql);
                }

                //-------------------------------------------------------------------------------------

            }


        }
        //---------------------------------------END UPDATE---------------------------------------------

        //-----------------------------------CONNECTION----------------------------------------------
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

        //-----------------------------------CLEAN VALUES FROM ROWS----------------------------------

        private void CLEAN_VALUES()
        {
            tseditValues = new string[7];
            num = -1;
        }

        private void bunifuCustomDataGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            num = Convert.ToInt32(bunifuCustomDataGrid1[0, e.RowIndex].Value.ToString());
            indexCol = e.ColumnIndex;
            vlaue = bunifuCustomDataGrid1[e.ColumnIndex, e.RowIndex].Value.ToString();

            if (indexCol == 1)
            {

                tseditValues[0] = vlaue;
            }
            if (indexCol == 2)
            {

                tseditValues[1] = vlaue;
            }
            if (indexCol == 3)
            {

                tseditValues[2] = vlaue;
            }
            if (indexCol == 4)
            {

                tseditValues[3] = vlaue;
            }
            if (indexCol == 5)
            {

                tseditValues[4] = vlaue;
            }
            if (indexCol == 6)
            {

                tseditValues[5] = vlaue;
            }
            if (indexCol == 7)
            {

                tseditValues[6] = vlaue;
            }
        }
    }
}
