
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

int NumberOfPages = 308;
string InputDirectory = "C:\\Users\\Steve\\Downloads\\1111";
string OutputFile = "C:\\Users\\Steve\\Desktop\\textbook.pdf";
PdfWriter writer = new PdfWriter(OutputFile);
PdfDocument pdf = new PdfDocument(writer);
pdf.SetDefaultPageSize(new iText.Kernel.Geom.PageSize(1224, 1566));
Document doc = new Document(pdf);
doc.SetBottomMargin(0);
doc.SetTopMargin(0);
doc.SetRightMargin(0);
doc.SetLeftMargin(0);
for(int i = 0; i < NumberOfPages; i++)
{
    ImageData data = ImageDataFactory.Create(InputDirectory + $"\\Page {i}.jpg");
    Image img = new Image(data);
    doc.Add(img.ScaleToFit(1224, 1566));
    
}
doc.Close();