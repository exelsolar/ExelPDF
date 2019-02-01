using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotiza.PDFBase.Domain.PDF;
using DevExpress.Pdf;
using System.IO;
using Ecotiza.PDFBase.Domain.SolicitudDCredito;

namespace Ecotiza.PDFBase.Implements.PDFImp
{
    public class PDFEdit
    {
        private const float DrawIngDpi = 72f;
        public PDFEdit()
        {

        }
        PdfDocumentProcessor PdfDocProcessor;
        AddGraphics AddGrapic;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentsPaths">List<string></param>
        /// <param name="finalName">string</param>
        /// <param name="waterMark">DrawText</param>
        /// <param name="mark">DrawText</param>
        /// <param name="qr">QR</param>, List<Stream> documentsPathsStream,string finalName, DrawText waterMark, DrawText mark, QR qr
        public Stream PDFJoin(List<string> documentsPaths, string finalName, SolicitudCreditoL4 SolicitudL4)
        {

            PdfDocProcessor = new PdfDocumentProcessor();

            var streamDoc = new MemoryStream();

            //Se unen los pdf
            if (documentsPaths != null)
            {
                //Se unen los pdf
                foreach (var data in documentsPaths)
                {
                    if (data != null)
                        PdfDocProcessor.AppendDocument(data.ToString());
                }
            }
            /*if (documentsPathsStream != null)
            {
                //Se unen los pdf
                foreach (var data in documentsPathsStream)
                {
                    if (data != null)
                        PdfDocProcessor.AppendDocument(data);
                }
            }*/
            //Agregar marcas de agua, qr y Numero de descarga   , waterMark, mark, qr

            AddGrapic = new AddGraphics();
            AddGrapic.AddGraphicJoin(PdfDocProcessor, SolicitudL4);

            if (!String.IsNullOrEmpty(finalName))
            {
                PdfDocProcessor.SaveDocument(finalName);
            }
            else
            {
                PdfDocProcessor.SaveDocument(streamDoc);
            }
            streamDoc.Position = 0;

            return streamDoc;
        }



    }
}
