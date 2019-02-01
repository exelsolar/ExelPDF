using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Infrastructure.Files
{
    public static class StreamFile { 
        /// <summary>
        /// Convertir archivo PDF a Stream asignar
        /// </summary>
        /// <param name="path">Ruta del archivo</param>
        /// <returns></returns>
        public static Stream ConverPDFToStream(string path)
        {
            var pdfContent = new MemoryStream(System.IO.File.ReadAllBytes(path));
            pdfContent.Position = 0;
            return pdfContent;
        }
    }
}
