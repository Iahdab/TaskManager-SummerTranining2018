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
    public partial class MEdit : Form
    {

        private OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dt;
        OleDbCommand cmd;
        int indexCol;
        string vlaue;
        int num;
        string[] leditValues = new string[6];


        public MEdit()
        {
            InitializeComponent();
            this.flatLabel2.Text = DateTime.Now.ToShortDateString();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task managment.accdb";
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // no thing
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

        private void flatButton3_Click(object sender, EventArgs e)
        {
            // يدخل على صفحة مهمه جديدة للتعديل على المهمات السابقه
            // new MNewTask().Show();
            // this.Hide();
            con.Open();
            string strdate = metroDateTime1.Value.ToShortDateString();//metroDateTime1.Value.ToString("MM'/'dd'/'yyyy");
            // ad = new OleDbDataAdapter("SELECT * FROM manager WHERE start_date = '" + strdate + "' OR finsh_date = '" + strdate + "'", con);
            ad = new OleDbDataAdapter("SELECT * FROM manager WHERE start_date Like '" + strdate+ "%' OR finsh_date Like '" + strdate + "%'", con);
            dt = new DataTable();
            ad.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();

        }

        private void flatStickyButton3_Click(object sender, EventArgs e)
        {
            // يودي على مهمه جديدة اداري
            new MNewTask().Show();
            this.Hide();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            // يحفظ ويدخل على عرض اداري
            // new MView().Show();
            // this.Hide();

            updateMEdit();
            if (leditValues[0] != null || leditValues[1] != null || leditValues[2] != null || leditValues[3] != null || leditValues[4] != null || leditValues[5] != null)
            {
                MessageBox.Show("تم عملية التحديث بنجاح", "تحديث البيانات");
            }
            CLEAN_VALUES();
           // MessageBox.Show("تم عملية التحديث بنجاح", "تحديث البيانات");
        }

        private void MEdit_Load(object sender, EventArgs e)
        {

            con.Open();
            ad = new OleDbDataAdapter("SELECT * FROM manager", con);
            dt = new DataTable();
            ad.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;

            con.Close();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          /*  try
            {
                this.managerTableAdapter.FillBy(this.task_managmentDataSet.manager);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        //---------------------------------------UPDATE MANAGER-------------------------------------------

        private void updateMEdit()
        {

            string sql;


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

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bunifuCustomDataGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
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

        //-------------------------------------------------------------------------------------------------------
    }
}
