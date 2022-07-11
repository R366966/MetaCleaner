using Spire.Xls;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using SixLabors.ImageSharp;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Image = SixLabors.ImageSharp.Image;
using Spire;



namespace ConsoleApplication1
{
    class Program
    {

       
        static async Task Main(string[] arg)
        {



            // PDF
            /*
            PdfLoadedDocument ldoc = new PdfLoadedDocument("Test.pdf");
            PdfCompressionOptions options = new PdfCompressionOptions();
            options.RemoveMetadata = true;
            ldoc.DocumentInformation.Author = "";
            ldoc.DocumentInformation.Title = "";
            ldoc.DocumentInformation.Creator = "";
            ldoc.DocumentInformation.Subject = "";
            ldoc.DocumentInformation.Producer  = "";
            ldoc.DocumentInformation.RemoveModificationDate();
            ldoc.CompressionOptions = options;
            ldoc.Save("output.pdf");
            ldoc.Close(true);
            */

            /*
            
            // PNG, TIFF, GIF, TGA, BMP, PBM, JPEG 
            using var image = await Image.LoadAsync("Test.jpg");
            image.Metadata.ExifProfile = null;
            image.Metadata.IptcProfile = null;
            image.Metadata.XmpProfile = null;
            await image.SaveAsync("Output.jpg");
            */

            /*
            
            //DOCX
            using (var package = WordprocessingDocument.Open("Test.docx", true))
            {

                package.PackageProperties.Creator = null;
                package.PackageProperties.LastModifiedBy = null;
                package.PackageProperties.Revision = null;
                package.PackageProperties.Title = null;
                package.PackageProperties.Subject = null;
                package.PackageProperties.ContentStatus = null;
                package.PackageProperties.Modified = null;

            }
            */
            
            //Xlsx 0.1 
            /*
            Workbook workbook = new Workbook();
            workbook.LoadFromFile("Test.xlsx");
            workbook.DocumentProperties.Author = "";
            workbook.DocumentProperties.Title = "";
            workbook.DocumentProperties.Keywords = "";
            workbook.DocumentProperties.Category = "";
            workbook.DocumentProperties.Company = "";
            workbook.DocumentProperties.Subject = "";
            workbook.DocumentProperties.Comments = "";
            workbook.DocumentProperties.Manager = "";
            
            workbook.SaveToFile("Output.xlsx");
            */











        }

    }
}
