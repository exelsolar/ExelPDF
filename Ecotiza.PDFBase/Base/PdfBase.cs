using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotiza.PDFBase.Domain.Enum;
using Ecotiza.PDFBase.Domain.PDF;
using Ecotiza.PDFBase.Domain.SolicitudDCredito;
using Ecotiza.PDFBase.Implements.PDFImp;
using Ecotiza.PDFBase.Infrastructure.Files;
using Ecotiza.PDFBase.Infrastructure.Files.Enums;

namespace Ecotiza.PDFBase.Base
{
    public class PdfBase
    {
        private SolidBrush _SolidBrush { get; set; }
        private Font _Font { get; set; }
        private QR _Qr { get; set; }
        private PDFEdit PdfEdit { get; set; }
        private string FileEditPath { get; set; }

        public PdfBase()
        {
            _SolidBrush = new SolidBrush(Color.FromArgb(23, 0, 0));
            _Font = new Font("Arial", 40, FontStyle.Bold);

            PdfEdit = new PDFEdit();
            //ResolverPath();
        }

        public void EditPDf(List<string>files,string nameEnd, Object obj,EPDFFile ePdf)
        {
            PdfEdit.PDFJoin(files, nameEnd, obj, ePdf);
        }

        public Stream EditPDfStream(List<string> files, string nameEnd, Object obj, EPDFFile ePdf)
        {

            return PdfEdit.PDFJoin(files, nameEnd, obj, ePdf);
        }

    }
}
