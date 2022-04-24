using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// ///Provider=Microsoft.ACE.OLEDB.12.0;Data Source="D:\Ahdab A\project without DB copy\task managment.accdb"
        /// </summary>
        [STAThread]
        static void Main()
        {


            // create folder name
            string newFolder = "إدارة المهام";

            // get the path of the user and join it with folder name 
            string path = System.IO.Path.Combine(
               Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), newFolder);
            string jobtitle = null;

            // check if the folder Exist
            if (!System.IO.Directory.Exists(path))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                catch (IOException ie)
                {
                    Console.WriteLine("IO Error: " + ie.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("General Error: " + e.Message);
                }
            }

            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=task managment.accdb";
            string queryString = "SELECT job_name FROM account";
            //-----------------------------------------------------------------------------------------------
            try
            {
                using (OleDbConnection connection = new OleDbConnection(ConnectionString))
                {
                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        jobtitle = reader.GetValue(0).ToString();

                        // Insert code to process data.
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }
            //-----------------------------------------------------------------------------------------------

            if (jobtitle.Equals("اداري"))
            {

                // go to interface new task interface.

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MNewTask());


            }
            else if (jobtitle.Equals("فني دعم "))
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TSNewTask());
            }
            else if (jobtitle.Equals("فني مختبرات"))
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LNewTask());
            }
            else
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form7‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏());

            }


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form7‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏‏());
            // Application.Run(new TSView());
        }
    }
}
