using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class TSPDFView : Form
    {


        // Difining variables.
        private OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dt;
        String StartDate, FinishDate; // from calender in Lvew Form.
        int index; // monthly or yearly.
        int TSorM; // technichal or manager.
        int viewTybe; // table or chart.
        String PcNumber;

        public TSPDFView(String SDate, String FDate, int i, int TSM,int Tybe,String s)
        {
            InitializeComponent();
            this.flatLabel1.Text = DateTime.Now.ToShortDateString();
        //     ViweData.Checked = true;

            // Opining the connection.
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Task managment.accdb";

            this.StartDate = SDate;
            this.FinishDate = FDate;
            this.index = i;
            this.TSorM = TSM;
            this.viewTybe = Tybe;
            this.PcNumber = s;


            if (TSorM == 0) // technical.
            {
                ad = new OleDbDataAdapter("Select * from  technical_support where task_date_default BETWEEN #" + SDate + "#  AND #" + FDate + "#", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }


            else if (TSorM == 1) // manager.
            {
                ad = new OleDbDataAdapter("Select * from manager  where start_date  BETWEEN #" + SDate + "#  AND #" + FDate + "# or finsh_date BETWEEN #" + SDate + "#  AND #" + FDate + "#", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يفتح تحرير فني
            new TSEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // يفتح عرض فني
            new TSView().Show();
            this.Hide();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {

           
            // adding the arabic font.
            BaseFont baseFont = BaseFont.CreateFont("c:\\\\windows\\\\fonts\\\\tahoma.ttf", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font FontAr = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);


            if (viewTybe == 0)
            {
                //  PDF انشاء ملف  .
                String folder = "إدارة المهام";  // the folder that will be saved in .
                String date = "//" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".pdf"; // here adding the date of the report.
                String path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folder); // the path of the file is in the documents.
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path + date, FileMode.Create));
                // open the pdf file .
                doc.Open();

                // doing the table .
                PdfPTable table = new PdfPTable(bunifuCustomDataGrid1.Columns.Count);
                table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                if (index == 0)
                {
                    PdfPTable table2 = new PdfPTable(1); // a table with 1 cell
                    Phrase text = new Phrase("جدول المهام الشهرية ", FontAr);
                    PdfPCell cell = new PdfPCell(text);
                    table2.RunDirection = PdfWriter.RUN_DIRECTION_RTL; 
                    table2.AddCell(cell);
                    doc.Add(table2);
                    // addimg the space .
                    doc.Add(new Paragraph("                                                                                        " + "                                                                "));


                    if (TSorM == 0)
                    {
                        // adding the headers of the table.
                        table.AddCell(new Phrase("رقم المهمة", FontAr));
                        table.AddCell(new Phrase("طالب الطلب", FontAr));
                        table.AddCell(new Phrase("رقم الجهاز", FontAr));
                        table.AddCell(new Phrase("القسم", FontAr));
                        table.AddCell(new Phrase("المهمه", FontAr));
                        table.AddCell(new Phrase("وقت البداية", FontAr));
                        table.AddCell(new Phrase("وقت النهاية", FontAr));
                        table.AddCell(new Phrase("حالة المهمة", FontAr));
                        table.AddCell(new Phrase("تاريخ المهمة", FontAr));

                    }
                    else if (TSorM == 1)
                    {
                        // adding the headers of the table.
                        table.AddCell(new Phrase("رقم المهمة", FontAr));
                        table.AddCell(new Phrase("نوع الخطاب", FontAr));
                        table.AddCell(new Phrase("رقم الخطاب", FontAr));
                        table.AddCell(new Phrase("القسم", FontAr));
                        table.AddCell(new Phrase("تاريخ البداية", FontAr));
                        table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                        table.AddCell(new Phrase("حالة الخطاب", FontAr));
                    }
                    table.HeaderRows = 1;

                    // adding the rows.
                    for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
                    {

                        if (i == 0) { } // do nothing.
                        else if (TSorM == 0)
                        {
                            if (bunifuCustomDataGrid1[8, i].Value != null && bunifuCustomDataGrid1[8, i - 1].Value != null)
                            {
                                String[] Date1 = bunifuCustomDataGrid1[8, i].Value.ToString().Split('/');
                                String[] Date2 = bunifuCustomDataGrid1[8, i - 1].Value.ToString().Split('/');

                                if (!Date1[0].Equals(Date2[0]))
                                    if (TSorM == 0)
                                    {
                                        // adding the headers of the table.
                                        table.AddCell(new Phrase("رقم المهمة", FontAr));
                                        table.AddCell(new Phrase("طالب الطلب", FontAr));
                                        table.AddCell(new Phrase("رقم الجهاز", FontAr));
                                        table.AddCell(new Phrase("القسم", FontAr));
                                        table.AddCell(new Phrase("المهمه", FontAr));
                                        table.AddCell(new Phrase("وقت البداية", FontAr));
                                        table.AddCell(new Phrase("وقت النهاية", FontAr));
                                        table.AddCell(new Phrase("حالة المهمة", FontAr));
                                        table.AddCell(new Phrase("تاريخ المهمة", FontAr));

                                    }
                                    else if (TSorM == 1)
                                    {
                                        // adding the headers of the table.
                                        table.AddCell(new Phrase("رقم المهمة", FontAr));
                                        table.AddCell(new Phrase("نوع الخطاب", FontAr));
                                        table.AddCell(new Phrase("رقم الخطاب", FontAr));
                                        table.AddCell(new Phrase("القسم", FontAr));
                                        table.AddCell(new Phrase("تاريخ البداية", FontAr));
                                        table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                                        table.AddCell(new Phrase("حالة الخطاب", FontAr));
                                    } // end else.



                            }// end if
                        } // end if.


                        else if (bunifuCustomDataGrid1[4, i].Value != null && bunifuCustomDataGrid1[4, i - 1].Value != null)
                        {
                            String[] Date1 = bunifuCustomDataGrid1[4, i].Value.ToString().Split('/');
                            String[] Date2 = bunifuCustomDataGrid1[4, i - 1].Value.ToString().Split('/');

                            if (!Date1[0].Equals(Date2[0]))
                                if (TSorM == 0)
                                {
                                    // adding the headers of the table.
                                    table.AddCell(new Phrase("رقم المهمة", FontAr));
                                    table.AddCell(new Phrase("طالب الطلب", FontAr));
                                    table.AddCell(new Phrase("رقم الجهاز", FontAr));
                                    table.AddCell(new Phrase("القسم", FontAr));
                                    table.AddCell(new Phrase("المهمه", FontAr));
                                    table.AddCell(new Phrase("وقت البداية", FontAr));
                                    table.AddCell(new Phrase("وقت النهاية", FontAr));
                                    table.AddCell(new Phrase("حالة المهمة", FontAr));
                                    table.AddCell(new Phrase("تاريخ المهمة", FontAr));
                                }
                                else if (TSorM == 1)
                                {
                                    // adding the headers of the table.
                                    table.AddCell(new Phrase("رقم المهمة", FontAr));
                                    table.AddCell(new Phrase("نوع الخطاب", FontAr));
                                    table.AddCell(new Phrase("رقم الخطاب", FontAr));
                                    table.AddCell(new Phrase("القسم", FontAr));
                                    table.AddCell(new Phrase("تاريخ البداية", FontAr));
                                    table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                                    table.AddCell(new Phrase("حالة الخطاب", FontAr));
                                } // end else.
                        } // end if.

                        // adding cells.
                        for (int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                        {
                            if (bunifuCustomDataGrid1[k, i].Value != null)
                            {
                                table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString(), FontAr));
                            } // end if.
                        } // end for.
                    } // end for.
                } // end if.


                else if (index == 1)
                {
                    PdfPTable table2 = new PdfPTable(1); // a table with 1 cell
                    Phrase text = new Phrase("جدول المهام السنوية ", FontAr);
                    PdfPCell cell = new PdfPCell(text);
                    table2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table2.AddCell(cell);
                    doc.Add(table2);
                    // addimg the space .
                    doc.Add(new Paragraph("                                                                                        " + "                                                                "));


                    if (TSorM == 0)
                    {
                        // adding the headers of the table.
                        table.AddCell(new Phrase("رقم المهمة", FontAr));
                        table.AddCell(new Phrase("طالب الطلب", FontAr));
                        table.AddCell(new Phrase("رقم الجهاز", FontAr));
                        table.AddCell(new Phrase("القسم", FontAr));
                        table.AddCell(new Phrase("المهمه", FontAr));
                        table.AddCell(new Phrase("وقت البداية", FontAr));
                        table.AddCell(new Phrase("وقت النهاية", FontAr));
                        table.AddCell(new Phrase("حالة المهمة", FontAr));
                        table.AddCell(new Phrase("تاريخ المهمة", FontAr));

                    }
                    else if (TSorM == 1)
                    {
                        // adding the headers of the table.
                        table.AddCell(new Phrase("رقم المهمة", FontAr));
                        table.AddCell(new Phrase("نوع الخطاب", FontAr));
                        table.AddCell(new Phrase("رقم الخطاب", FontAr));
                        table.AddCell(new Phrase("القسم", FontAr));
                        table.AddCell(new Phrase("تاريخ البداية", FontAr));
                        table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                        table.AddCell(new Phrase("حالة الخطاب", FontAr));
                    }
                    table.HeaderRows = 1;

                    // adding the rows.
                    for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
                    {
                        if (i == 0) { } // do nothing .
                        else if (bunifuCustomDataGrid1[4, i].Value != null && bunifuCustomDataGrid1[4, i - 1].Value != null)
                        {
                            String[] Date1 = bunifuCustomDataGrid1[4, i].Value.ToString().Split('/');
                            String[] Date2 = bunifuCustomDataGrid1[4, i - 1].Value.ToString().Split('/');

                            String[] Date11 = Date1[2].Split();
                            String[] Date22 = Date2[2].Split();

                            if (!Date11[0].Equals(Date22[0]))
                            {
                                if (TSorM == 0)
                                {
                                    // adding the headers of the table.
                                    table.AddCell(new Phrase("رقم المهمة", FontAr));
                                    table.AddCell(new Phrase("طالب الطلب", FontAr));
                                    table.AddCell(new Phrase("رقم الجهاز", FontAr));
                                    table.AddCell(new Phrase("القسم", FontAr));
                                    table.AddCell(new Phrase("المهمه", FontAr));
                                    table.AddCell(new Phrase("وقت البداية", FontAr));
                                    table.AddCell(new Phrase("وقت النهاية", FontAr));
                                    table.AddCell(new Phrase("حالة المهمة", FontAr));
                                    table.AddCell(new Phrase("تاريخ المهمة", FontAr));
                                }
                                else if (TSorM == 1)
                                {
                                    // adding the headers of the table.
                                    table.AddCell(new Phrase("رقم المهمة", FontAr));
                                    table.AddCell(new Phrase("نوع الخطاب", FontAr));
                                    table.AddCell(new Phrase("رقم الخطاب", FontAr));
                                    table.AddCell(new Phrase("القسم", FontAr));
                                    table.AddCell(new Phrase("تاريخ البداية", FontAr));
                                    table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                                    table.AddCell(new Phrase("حالة الخطاب", FontAr));
                                }// end if.

                            } // end if.
                        } // end if.

                        // adding the cells.
                        for (int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                        {
                            if (bunifuCustomDataGrid1[k, i].Value != null)
                            {
                                table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString(), FontAr));
                            } // end if.
                        }// end for.
                    }// end for.
                } // end if.


                // adding the table to the file.
                doc.Add(table);

                // closing the document.
                doc.Close();
            } // end the view tybe = table.

            else if (viewTybe == 1) { // chart.
                //  PDF انشاء ملف  .
                String folder = "إدارة المهام";  // the folder that will be saved in .
                String date = "//" + DateTime.Now.ToShortDateString().Replace("/", "-") + "CHART.pdf"; // here adding the date of the report.
                String path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folder); // the path of the file is in the documents.
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path + date, FileMode.Create));

                // open the pdf file .
                doc.Open();

               // how to print the chart in pdf.
               var chartimage = new MemoryStream();
              chart1.SaveImage(chartimage, ChartImageFormat.Png);
              iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
              doc.Add(Chart_image);


              // closing the document.
              doc.Close();
                             }


                     // يحفظ ويرجع لصفحة العرض 
                     new TSView().Show();
                             this.Hide();
                         }

                         private void formSkin1_Click(object sender, EventArgs e)
                         {




                         }

                         private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
                         {

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



                         private void FlatMini_Click(object sender, EventArgs e)
                         {

                         }

                         private void FlatClose_Click(object sender, EventArgs e)
                         {

                         }

                         private void flatButton2_Click(object sender, EventArgs e)
                         {
                             // no thing.
                         }

                         private void ViewChart_CheckedChanged(object sender)
                         {
                          bunifuCustomDataGrid1.Visible = false;
                           chart1.Visible = true;

                             string mystoredValue = Properties.Settings.Default.ConditionString;
                             String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\task managment.accdb;Persist Security Info=True";
                             OleDbConnection con = new OleDbConnection(connection);
                             OleDbCommand cmd = new OleDbCommand(mystoredValue, con);

                            // OleDbCommand cmd = new OleDbCommand("Select * from Query2" , con);
                             OleDbDataReader myreader;

                             con.Open();
                             myreader = cmd.ExecuteReader();
                             chart1.DataSource = myreader;

                             chart1.Series["Series1"].XValueMember = "Dyear";
                             chart1.Series["Series1"].YValueMembers = "T";

                             chart1.Titles.Clear();
                             chart1.Titles.Add(PcNumber+"رسم بياني لمعدل عدد مرات صيانة الجهاز رقم  ");
                             chart1.DataBind();



                 }

                         private void ViweData_CheckedChanged(object sender)
                         {
                         bunifuCustomDataGrid1.Visible = true;
                         chart1.Visible = false;
                         }

                         private void bunifuImageButton2_Click(object sender, EventArgs e)
                         {
                             // ترجع لصفحة عرض فني
                             new TSView().Show();
                             this.Hide();
                          //
                         }
                     }
                 }
