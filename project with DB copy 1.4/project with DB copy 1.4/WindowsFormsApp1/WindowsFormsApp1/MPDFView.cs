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
    public partial class MPDFView : Form
    {
        // Difining variables.
        private OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ad;
        DataTable dt;
        String StartDate, FinishDate; // from calender in Lvew Form.
        int index; // monthly or yearly.


        public MPDFView(String SDate, String FDate, int i)
        {
            InitializeComponent();
            this.flatLabel1.Text = DateTime.Now.ToShortDateString();


            // Opining the connection.
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Task managment.accdb";

            this.StartDate = SDate;
            this.FinishDate = FDate;
            this.index = i;

           // doing the quere.
            ad = new OleDbDataAdapter("Select * from manager  where start_date  BETWEEN #" + SDate + "#  AND #" + FDate + "# or finsh_date BETWEEN #" + SDate + "#  AND #" + FDate + "#", con);
            dt = new DataTable();
            ad.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
        }

        private void flatStickyButton3_Click(object sender, EventArgs e)
        {
            new MView().Show();
           this.Hide();
        }

        private void flatStickyButton1_Click(object sender, EventArgs e)
        {
            // يفتح صفحة التحرير
            new MEdit().Show();
            this.Hide();
        }

        private void flatStickyButton2_Click(object sender, EventArgs e)
        {
            // يفتح صفحة العرض
            new MView().Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            // للرجوع لصفحة العرض
            new MView().Show();
            this.Hide();
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

          
            // doing the table .
            PdfPTable table = new PdfPTable(bunifuCustomDataGrid1.Columns.Count);
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


            BaseFont baseFont = BaseFont.CreateFont("c:\\\\windows\\\\fonts\\\\tahoma.ttf", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font FontAr = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.NORMAL);



            if (index == 0) // monthly.
            {
                PdfPTable table2 = new PdfPTable(1); // a table with 1 cell
                Phrase text = new Phrase("جدول المهام الشهرية  ", FontAr);
                PdfPCell cell = new PdfPCell(text);
                table2.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                table2.AddCell(cell);
                doc.Add(table2);
                // addimg the space .
                doc.Add(new Paragraph("                                                                                        " + "                                                                "));



                // adding the headers of the table.
                {
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
                    if (i == 0) { }
                    else if (bunifuCustomDataGrid1[4, i].Value != null && bunifuCustomDataGrid1[4, i - 1].Value != null)
                    {
                        String[] Date1 = bunifuCustomDataGrid1[4, i].Value.ToString().Split('/');
                        String[] Date2 = bunifuCustomDataGrid1[4, i - 1].Value.ToString().Split('/');

                        if (!Date1[0].Equals(Date2[0]))
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


                    }

                    // adding the cells.
                    for (int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                    {
                        if (bunifuCustomDataGrid1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString(), FontAr));
                        }// end if
                    }// end for
                } // end for
            } // end if


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



                // adding the headers of the table.
                {
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
                    if (i == 0) { }
                    else if (bunifuCustomDataGrid1[4, i].Value != null && bunifuCustomDataGrid1[4, i - 1].Value != null)
                    {
                        String[] Date1 = bunifuCustomDataGrid1[4, i].Value.ToString().Split('/');
                        String[] Date2 = bunifuCustomDataGrid1[4, i - 1].Value.ToString().Split('/');

                        String[] Date11 = Date1[2].Split();
                        String[] Date22 = Date2[2].Split();




                        if (!Date11[0].Equals(Date22[0]))
                        {

                            // adding the headers of the table.
                            {
                                table.AddCell(new Phrase("رقم المهمة", FontAr));
                                table.AddCell(new Phrase("نوع الخطاب", FontAr));
                                table.AddCell(new Phrase("رقم الخطاب", FontAr));
                                table.AddCell(new Phrase("القسم", FontAr));
                                table.AddCell(new Phrase("تاريخ البداية", FontAr));
                                table.AddCell(new Phrase("تاريخ النهاية", FontAr));
                                table.AddCell(new Phrase("حالة الخطاب", FontAr));
                            }

                        }
                    }


                    // adding the cells.
                    for (int k = 0; k < bunifuCustomDataGrid1.Columns.Count; k++)
                    {
                        if (bunifuCustomDataGrid1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(bunifuCustomDataGrid1[k, i].Value.ToString(), FontAr));
                        }// end if
                    }// end for
                } // end for
            } // end if


            // adding the table to the file.
            doc.Add(table);

            // closing the document.
            doc.Close();



        // يحفظ ويرجع لصفحة العرض

        new MView().Show();
            this.Hide();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MPDFView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'task_managmentDataSet.manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.task_managmentDataSet.manager);

        }
    }
}
