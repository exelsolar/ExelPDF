using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.Pdf;
namespace Ecotiza.PDFBase.Implements.PDFImp
{
    public class PrepareGraphics
    {
        public PrepareGraphics()
        {

        }
        public SizeF PrepareGraphicsSizeF(PdfPage page, PdfGraphics graphics, float dpiX, float dpiY)
        {
            PdfRectangle CropBox = page.CropBox;

            float CropBoxWidth = ConvertFromPdfUnits((float)CropBox.Width, dpiX);
            float CropBoxHeight = ConvertFromPdfUnits((float)CropBox.Height, dpiY);


            return new SizeF(CropBoxWidth, CropBoxHeight);
        }
        static float ConvertFromPdfUnits(float pdfValue, float targetDpi)
        {
            return pdfValue / 72f * targetDpi;
        }

    }
}
