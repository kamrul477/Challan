

using Challan.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Challan.ViewModels
{
    public class PdfCreation
    {
        //File.Create("D:\\kamruls folder\\software\\simple.pdf"

        //"D:\\kamruls folder\\software\\simple.pdf"
        ChallanContext context;
        public PdfCreation(ChallanContext _context)
        {
            context = _context;

        }


        public void pdfCreate()
        {
            PdfPTable table = createTable();
            

            Document document = new Document();
            var output = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(document, output);
            document.Open();
            document.Add(table);
            document.Close();
            HttpContext.Current.Response.ContentType = "application/pdf";
            HttpContext.Current.Response.AddHeader("Content-Disposition",
                "attachment;filename=file.pdf");
            HttpContext.Current.Response.BinaryWrite(output.ToArray());
        }

        private static PdfPTable createTable()
        {
            PdfPTable table = new PdfPTable(7);
            PdfPCell cell = new PdfPCell(new Phrase("must filled up by depositor"));
            cell.Colspan = 4;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("pdf with colsp2"));
            cell.Rowspan = 2;
            table.AddCell(cell);

            table.AddCell("row 1; cell 1");
            table.AddCell("row 1; cell 2");
            table.AddCell("row 2; cell 1");
            table.AddCell("row 2; cell 2");
            return table;
        }
        //document.Add(new Paragraph("Hello World!"));
        //document.Close();
        //public PdfPTable table;
        //public PdfPCell fundamentalCell;
        //public PdfCreation()
        //{
        //    table = new PdfPTable(3);

        //}

        //public void CreatePdfDocument()
        //{
        //    Document document = new Document();
        //    PdfWriter.GetInstance(document, new FileOutputStream(RESULT));
        //}

        //public void CreateTable()
        //{
        //    fundamentalCell = new PdfPCell(new Phrase("Cell with colspan 3"));
        //    fundamentalCell.Colspan = 3;
        //    table.AddCell(fundamentalCell);

        //    fundamentalCell = new PdfPCell(new Phrase("Cell with rowspan 2"));
        //    fundamentalCell.Rowspan = 2;
        //    table.AddCell(fundamentalCell);
        //    table.AddCell("row 1; cell 1");
        //    table.AddCell("row 1; cell 2");
        //    table.AddCell("row 2; cell 1");
        //    table.AddCell("row 2; cell 2");
        //}   
    }
}