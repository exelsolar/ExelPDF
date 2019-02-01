using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DevExpress.Pdf;
using Ecotiza.PDFBase.Domain.PDF;
using Ecotiza.PDFBase.Implements.SolicitudDCreditoImp;
using Ecotiza.PDFBase.Domain.SolicitudDCredito;

namespace Ecotiza.PDFBase.Implements.PDFImp
{
    public class AddGraphics
    {
        const float DrawIngDpi = 72f;

        private static PointF Center = new PointF();
        private static float degree = 0;

        private readonly PrepareGraphics PrepareGraphics = new PrepareGraphics();

        public AddGraphics()
        {

        }
        //, DrawText waterMark, DrawText numberDowload, QR qr
        public void AddGraphicJoin(PdfDocumentProcessor processor, SolicitudCreditoL4 SolicitudL4)
        {
            IList<PdfPage> Pages = processor.Document.Pages;
            for (int i = 0; i < Pages.Count; i++)
            {
                PdfPage Page = Pages[i];
                using (PdfGraphics graphics = processor.CreateGraphics())
                {
                    SizeF actualPageSize = PrepareGraphics.PrepareGraphicsSizeF(Page, graphics, DrawIngDpi, DrawIngDpi);

                    SolicitudCreditoContent.NPageContent(graphics,i, actualPageSize.Width, actualPageSize.Height, SolicitudL4);

                    graphics.AddToPageForeground(Page, DrawIngDpi, DrawIngDpi);

                }
            }
        }
    }
}
