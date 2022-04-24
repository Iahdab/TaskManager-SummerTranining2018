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

namespace WindowsFormsApp1
{

    public partial class LPDFView : Form
    {
        // Difining variables.
        private OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dt;
        String StartDate, FinishDate; // from calender in Lvew Form.
        int index; // monthly or yearly.
        int tybe; // technichal or manager.


        public LPDFView(String SDate, String FDate, int i, int t)
        {
            InitializeComponent();
            flatLabel1.Text = DateTime.Now.ToShortDateString();

            // Opining the connection.
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Task managment.accdb";

            this.StartDate = SDate;
            this.FinishDate = FDate;
            this.index = i;
            this.tybe = t;

            if (tybe == 0)  // lab suppor.
            {
                // making the quere .
                ad = new OleDbDataAdapter("Select * from lab_support  where task_date BETWEEN #" + SDate + "#  AND #" + FDate + "#", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            }


            else if (tybe == 1) //  manager.
            {
                // making the quere.
                ad = new OleDbDataAdapter("Select * from manager  where start_date  BETWEEN #" + SDate + "#  AND #" + FDate + "# or finsh_date BETWEEN #" + SDate + "#  AND #" + FDate + "#", con);
                dt = new DataTable();
                ad.Fill(dt);
                bunifuCustomDataGrid1.DataSource = dt;
                con.Close();
            } // end else.

        } // end constructor.


        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يفتح صفحة تحرير المختبرات
            new LEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            //  يفتح صفحة عرض المختبرات 
            new LVew().Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //  يرجع الى صفحة عرض المختبرات 
            new LVew().Show();
            this.Hide();
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

            //  PDF انشاء ملف  .
            String folder = "إدارة المهام";  // the folder that will be saved in .
            String date = "//" + DateTime.Now.ToShortDateString().Replace("/", "-") + ".pdf"; // here adding the date of the report.
            String path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), folder); // the path of the file is in the documents.
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path + date, FileMode.Create));

            // open the pdf file .
            doc.Open();


            // addimg the space .
            doc.Add(new Paragraph("                                                                                        " + "                                                                "));

            // doing the table .

            PdfPTable table = new PdfPTable(bunifuCustomDataGrid1.Columns.Count);
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


            BaseFont baseFont = BaseFont.CreateFont("c:\\\\windows\\\\fonts\\\\tahoma.ttf", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font FontAr = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);



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



                if (tybe == 0) // technical.
                {
                    // adding the headers of the table.
                    table.AddCell(new Phrase("رقم المهمة", FontAr));
                    table.AddCell(new Phrase("نوع المهمة", FontAr));
                    table.AddCell(new Phrase("رقم المعمل", FontAr));
                    table.AddCell(new Phrase("القسم", FontAr));
                    table.AddCell(new Phrase("تاريخ المهمة", FontAr));
                    table.AddCell(new Phrase("اليوم", FontAr));
                    table.AddCell(new Phrase("حالة المهمة", FontAr));

                }
                else if (tybe == 1) // manager.
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
                    if (i == 0) { } // do no thing.

                    else if (bunifuCustomDataGrid1[4, i].Value != null && bunifuCustomDataGrid1[4, i - 1].Value != null)
                    {
                        String[] Date1 = bunifuCustomDataGrid1[4, i].Value.ToString().Split('/');
                        String[] Date2 = bunifuCustomDataGrid1[4, i - 1].Value.ToString().Split('/');

                        if (!Date1[0].Equals(Date2[0]))
                            // adding the headers of the table.
                            if (tybe == 0)
                            {
                                table.AddCell(new Phrase("رقم المهمة", FontAr));
                                table.AddCell(new Phrase("نوع المهمة", FontAr));
                                table.AddCell(new Phrase("رقم المعمل", FontAr));
                                table.AddCell(new Phrase("القسم", FontAr));
                                table.AddCell(new Phrase("تاريخ المهمة", FontAr));
                                table.AddCell(new Phrase("اليوم", FontAr));
                                table.AddCell(new Phrase("حالة المهمة", FontAr));

                            }
                            else if (tybe == 1)
                            {
                                table.AddCell(new Phrase("رقم المهمة", FontAr));
                                table.AddCell(new Phrase("نوع الخطاب", FontAr));
                                table.AddCell(new Phrase("رقم الخطاب", FontAr));
                                table.AddCell(new Phrase("القسم", FontAr));
                                table.AddCell(new Phrase("تاريخ البداية", FontAr));
                                table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                                table.AddCell(new Phrase("حالة الخطاب", FontAr));
                            } // end else.


                    } // end else.


                    // adding the calls .
                    for (int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                    {
                        if (bunifuCustomDataGrid1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString(), FontAr));
                        }
                    } // end of for.
                } // end of for.
            } // end for if.



            else if (index == 1) // if yearly.
            {
                PdfPTable table2 = new PdfPTable(1); // a table with 1 cell
                Phrase text = new Phrase("جدول المهام السنوية ", FontAr);
                PdfPCell cell = new PdfPCell(text);
                table2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table2.AddCell(cell);
                doc.Add(table2);
                // addimg the space .
                doc.Add(new Paragraph("                                                                                        " + "                                                                "));




                if (tybe == 0) // technical.
                {
                    // adding the headers of the table.
                    table.AddCell(new Phrase("رقم المهمة", FontAr));
                    table.AddCell(new Phrase("نوع المهمة", FontAr));
                    table.AddCell(new Phrase("رقم المعمل", FontAr));
                    table.AddCell(new Phrase("القسم", FontAr));
                    table.AddCell(new Phrase("تاريخ المهمة", FontAr));
                    table.AddCell(new Phrase("اليوم", FontAr));
                    table.AddCell(new Phrase("حالة المهمة", FontAr));

                }
                else if (tybe == 1) // manager.
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
                    if (i == 0) { } // do no thing.

                    else if (bunifuCustomDataGrid1[4, i].Value != null && bunifuCustomDataGrid1[4, i - 1].Value != null)
                    {
                        String[] Date1 = bunifuCustomDataGrid1[4, i].Value.ToString().Split('/');
                        String[] Date2 = bunifuCustomDataGrid1[4, i - 1].Value.ToString().Split('/');

                        String[] Date11 = Date1[2].Split();
                        String[] Date22 = Date2[2].Split();

                        if (!Date11[0].Equals(Date22[0]))
                        {

                            if (tybe == 0) // techincal.
                            {
                                // adding the headers of the table.
                                table.AddCell(new Phrase("رقم المهمة", FontAr));
                                table.AddCell(new Phrase("نوع المهمة", FontAr));
                                table.AddCell(new Phrase("رقم المعمل", FontAr));
                                table.AddCell(new Phrase("القسم", FontAr));
                                table.AddCell(new Phrase("تاريخ المهمة", FontAr));
                                table.AddCell(new Phrase("اليوم", FontAr));
                                table.AddCell(new Phrase("حالة المهمة", FontAr));

                            }
                            else if (tybe == 1) // manager.
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

                        }// end if.
                    }//end if.


                    // adding the cells.
                    for (int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                    {
                        if (bunifuCustomDataGrid1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString(), FontAr));
                        }// end if
                    }// end for
                }// end for
            }// end if


            // adding the table to the file.
            doc.Add(table);

            // closing the document.
            doc.Close();


            // يحفظ ويرجع للعرض
            new LVew().Show();
            this.Hide();
        }
    }
}
