using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WinForm.Functions
{
    public class MyFunctions
    {
        public void CustomersExportToPdf(DataTable dataTable,string filePath)
        {
            Document pdfDoc=new Document(PageSize.A4,10f, 10f, 10f, 10f);

            try
            {
                //Başlık ekleme
                PdfWriter.GetInstance(pdfDoc,new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                string fontPath=Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                BaseFont baseFont=BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font font=new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);

                Paragraph title = new Paragraph("Müşteri Listesi",font);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter= 20f;
                pdfDoc.Add(title);

                //Datatable'dan PDF tablosu oluşturma
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                pdfTable.WidthPercentage = 100;

                //Sütun Başlıkları
                foreach (DataColumn column in dataTable.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName,font));
                    cell.BackgroundColor=BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                //Satırlar

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        pdfTable.AddCell(new Phrase(item.ToString(),font));
                    }
                }

                pdfDoc.Add(pdfTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                pdfDoc.Close();
            }
        }
    }
}
