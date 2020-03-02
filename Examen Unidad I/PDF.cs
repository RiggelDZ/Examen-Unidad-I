using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;


namespace Examen_Unidad_I
{
    class PDF
    {
        public void exportar(DataGridView dgLog, string filename)
        {
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);

            PdfPTable pTable = new PdfPTable(dgLog.Columns.Count);
            pTable.DefaultCell.Padding = 2;
            pTable.WidthPercentage = 85;
            pTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pTable.DefaultCell.BorderWidth = 1;
            pTable.SpacingBefore = 35f;
            pTable.SpacingAfter = 45f;

            Font font = new Font(baseFont, 9, Font.NORMAL);

            foreach (DataGridViewColumn column in dgLog.Columns)
            {
                PdfPCell pCell = new PdfPCell(new Phrase(column.HeaderText, font));
                pCell.BackgroundColor = new BaseColor(204, 255, 229);
                pTable.AddCell(pCell);
            }

            foreach (DataGridViewRow row in dgLog.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pTable.AddCell(new Phrase(cell.Value.ToString(), font));
                }
            }

            var dialog = new SaveFileDialog
            {
                FileName = filename,
                DefaultExt = ".pdf"
            };

            Font fontTitulo = new Font(Font.FontFamily.TIMES_ROMAN, 20, Font.BOLD);
            Font fontFooter = new Font(Font.FontFamily.TIMES_ROMAN, 13, Font.BOLD);

            Paragraph titulo = new Paragraph(string.Format("RPG - David & Dan"), fontTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            Paragraph p1 = new Paragraph(string.Format("Reporte de Acciones"),fontTitulo);
            p1.Alignment = Element.ALIGN_CENTER;
            Paragraph footer = new Paragraph(string.Format("Gracias por probar el demo. \nApóyanos comprando el juego."), fontFooter);
            footer.Alignment = Element.ALIGN_CENTER;

            Document document = new Document(PageSize.A4, 15, 15, 35, 35);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(document, fileStream);

                    document.Open();
                    document.AddCreator("Riggel Dehesa");
                    document.AddCreationDate();
                    document.Add(titulo);
                    document.Add(p1);
                    document.Add(pTable);
                    document.Add(footer);

                    document.Close();

                    fileStream.Close();
                }
            }
        }
        
    }
}
