﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WeddingPlanner
{
    public partial class displaybooking : Form
    {
        SqlConnection conn = new SqlConnection(connect.constr);
        public displaybooking()
        {
            InitializeComponent();
        }

        private void Displaybooking_Load(object sender, EventArgs e)
        {
            displaydata1();
        }



        public void displaydata1()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT c.customer_name, c.[mobile _number], c.alternate_mobile_number,c.email, c.addr, c.landmark, c.state, c.city, c.pincode, pd.package_name, pd.package_price, pd.wedding_types, pd.discount, pd.capacity,v.venue_name, v.venue_address FROM Normal_package_customer cc INNER JOIN Customerinfo c ON cc.CusId = c.cusId INNER JOIN package_tbl pd ON cc.packageId = pd.p_id INNER JOIN venues v ON cc.venueid = v.venueid; ",conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }
        }

        private void Btnpdf_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (.pdf)|.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4.Rotate(), 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                // Create a heading with larger font size and bold
                                iTextSharp.text.Font headingFont = FontFactory.GetFont("Arial", 24, CMYKColor.MAGENTA);
                                Paragraph heading = new Paragraph("WeddingPlanner", headingFont);
                                heading.SpacingAfter = 50;

                                // Center the heading
                                heading.Alignment = Element.ALIGN_CENTER;

                                // Add the heading to the document
                                document.Add(heading);


                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
