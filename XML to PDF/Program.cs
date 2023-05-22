// Create a new PDF document
using iText.Html2pdf;
using iText.Kernel.Pdf;
using System.Net.Http;

string outputFilePath = "output.pdf";
PdfWriter writer = new(outputFilePath);
PdfDocument pdfDoc = new(writer);

// Set up the pdfHTML converter
ConverterProperties converterProperties = new();

// Read HTML Content
string htmlFilePath = "index.html";
string htmlContent = File.ReadAllText(htmlFilePath);

// Convert HTML to PDF
HtmlConverter.ConvertToPdf(htmlContent, pdfDoc, converterProperties);


pdfDoc.Close();
