using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVR.Application.Utils.GeneratorPDF
{
    public class PdfGenerator
    {
        public byte[] GenerateTransactionConfirmationPdf(string customerName, double depositAmount, string transactionNo)
        {
            using (var memoryStream = new MemoryStream())
            {
                var document = new Document(PageSize.A4);
                var writer = PdfWriter.GetInstance(document, memoryStream);
                document.Open();

                // Add content to the PDF
                document.Add(new Paragraph("Xác nhận giao dịch"));
                document.Add(new Paragraph($"Khách hàng: {customerName}"));
                document.Add(new Paragraph($"Số tiền đặt cọc: {depositAmount}"));
                document.Add(new Paragraph($"Số giao dịch: {transactionNo}"));
                document.Add(new Paragraph($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));

                document.Close();
                return memoryStream.ToArray();
            }
        }

        public byte[] GenerateBankTransferConfirmationPdf(string customerName, double depositAmount, string bankName, string transactionNo)
        {
            using (var memoryStream = new MemoryStream())
            {
                var document = new Document(PageSize.A4);
                var writer = PdfWriter.GetInstance(document, memoryStream);
                document.Open();

                // Add content to the PDF
                document.Add(new Paragraph("Xác nhận chuyển khoản"));
                document.Add(new Paragraph($"Khách hàng: {customerName}"));
                document.Add(new Paragraph($"Số tiền: {depositAmount}"));
                document.Add(new Paragraph($"Ngân hàng: {bankName}"));
                document.Add(new Paragraph($"Số giao dịch: {transactionNo}"));
                document.Add(new Paragraph($"Ngày: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));

                document.Close();
                return memoryStream.ToArray();
            }
        }
    }
}
