using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotiza.PDFBase.Domain.PDF;
using DevExpress.BarCodes;
using System.Drawing;

namespace Ecotiza.PDFBase.Implements.PDFImp
{
    public static class QrCreate
    {
        private static BarCode QrCode;

        public static Bitmap CreateQr(QR qr)
        {
            QrCode = new BarCode();
            QrCode.Symbology = Symbology.QRCode;
            QrCode.CodeText = qr.Data;
            QrCode.CodeBinaryData = Encoding.Default.GetBytes(QrCode.CodeText);

            QrCode.Options.QRCode.CompactionMode = DevExpress.BarCodes.QRCodeCompactionMode.Byte;
            QrCode.Options.QRCode.ErrorLevel = QRCodeErrorLevel.Q;
            QrCode.Options.QRCode.ShowCodeText = qr.ShowText;
            //Guardar por bitmap
            Bitmap BitImage = QrCode.BarCodeImage;
            //salvar localmente
            //_QrCode.BarCodeImage.Save(_qr._qrPath,ImageFormat.Png);

            return BitImage;
        }
    }
}
