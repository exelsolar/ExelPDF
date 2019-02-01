using DevExpress.Pdf;
using Ecotiza.PDFBase.Domain.PDF;
using Ecotiza.PDFBase.Domain.SolicitudDCredito;
using Ecotiza.PDFBase.Implements.PDFImp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecotiza.PDFBase.Infrastructure.String;
using Ecotiza.PDFBase.Domain.Enum;

namespace Ecotiza.PDFBase.Implements.SolicitudDCreditoImp
{
    /// <summary>
    /// Clase para agregar elementos en el PDF Solicitud De Credito L4
    /// </summary>
    public static class SolicitudCreditoContent
    {
        private static float degree = 0;
        const float DrawIngDpi = 72f;
        private static SolicitudCreditoL4 _SolicitudL4;
        public static SolicitudCreditoPointF _PointF;

        private static DrawText _drawText = new DrawText();

        public static void NPageContent(PdfGraphics graphics, int NPage, float width, float height, SolicitudCreditoL4 SolicitudL4)
        {
            _SolicitudL4 = SolicitudL4;
            DrawinUbication(width, height);

            switch (NPage)
            {
                case 0:
                    #region 1 Credito Solicitado

                    AddCircle(graphics, _PointF.TipoProducto);
                    AddCircle(graphics, _PointF.TipoCredito);

                    if (_SolicitudL4.CreditoEnPesos == true)
                    {
                        AddCircle(graphics, _PointF.CreditoEnPesos);
                    }
                    else
                    {
                        AddCircle(graphics, _PointF.CreditoEnPesos);
                    }

                    AddCircle(graphics, _PointF.DestinoCredito);

                    AddCircle(graphics, _PointF.PlazoCredito);
                    if (_SolicitudL4.SegundoCreditoSolicitado == true)
                    {
                        AddCircle(graphics, _PointF.SegundoCreditoSolicitado);
                    }
                    else
                    {
                        AddCircle(graphics, _PointF.SegundoCreditoSolicitado);
                    }
                    #endregion
                    #region 2 Datos para determinar monto credito
                    if (!String.IsNullOrEmpty(_SolicitudL4.MontoDCredSolicDerechoH))
                    {
                        _drawText.Default(_SolicitudL4.MontoDCredSolicDerechoH);
                        AddDraw(graphics, _drawText, _PointF.MontoDCredSolicDerechoH);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.MontoDAhorroVol))
                    {
                        _drawText.Default(_SolicitudL4.MontoDAhorroVol);
                        AddDraw(graphics, _drawText, _PointF.MontoDAhorroVol);
                    }
                    #endregion
                    #region 3 Datos de la vivienda destino del credito
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredCalle))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredCalle);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredCalle);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredNoExt))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredNoExt);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredNoExt);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredNoInt))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredNoInt);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredNoInt);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredLote))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredLote);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredLote);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredMza))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredMza);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredMza);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredColFrac))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredColFrac);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredColFrac);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredEntidad))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredEntidad);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredEntidad);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredMunicDeleg))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredMunicDeleg);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredMunicDeleg);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredCP))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredCP);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredCP);
                    }
                    if (_SolicitudL4.DatoViviendaCredPDiscap == true)
                    {
                        AddCircle(graphics, _PointF.DatoViviendaCredPDiscap);
                    }
                    else
                    {
                        AddCircle(graphics, _PointF.DatoViviendaCredPDiscap);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatoViviendaCredMontoPresup))
                    {
                        _drawText.Default(_SolicitudL4.DatoViviendaCredMontoPresup);
                        AddDraw(graphics, _drawText, _PointF.DatoViviendaCredMontoPresup);
                    }
                    if (_SolicitudL4.DatoViviendaCredMontoAfectacion == true)
                    {
                        AddCircle(graphics, _PointF.DatoViviendaCredMontoAfectacion);
                    }
                    else
                    {
                        AddCircle(graphics, _PointF.DatoViviendaCredMontoAfectacion);
                    }
                    #endregion
                    #region 4 Datos de la empresa

                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosEmprPatrNombre))
                    {
                        _drawText.Default(_SolicitudL4.DatosEmprPatrNombre);
                        AddDraw(graphics, _drawText, _PointF.DatosEmprPatrNombre);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosEmprPatrNRegistroP))
                    {
                        _drawText.Default(_SolicitudL4.DatosEmprPatrNRegistroP);
                        AddDraw(graphics, _drawText, _PointF.DatosEmprPatrNRegistroP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosEmprPatrLada))
                    {
                        _drawText.Default(_SolicitudL4.DatosEmprPatrLada);
                        AddDraw(graphics, _drawText, _PointF.DatosEmprPatrLada);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosEmprPatrNumero))
                    {
                        _drawText.Default(_SolicitudL4.DatosEmprPatrNumero);
                        AddDraw(graphics, _drawText, _PointF.DatosEmprPatrNumero);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosEmprPatrExt))
                    {
                        _drawText.Default(_SolicitudL4.DatosEmprPatrExt);
                        AddDraw(graphics, _drawText, _PointF.DatosEmprPatrExt);
                    }

                    #endregion
                    break;
                case 1:

                    #region 5. DATOS DE IDENTIFICACIÓN DEL DERECHOHABIENTE

                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHNSS))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHNSS);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHNSS);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHCURP))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHCURP);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHCURP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHRFC))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHRFC);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHRFC);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHAPellidoP))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHAPellidoP);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHAPellidoP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHApellidoM))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHApellidoM);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHApellidoM);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHNombre))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHNombre);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHNombre);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHCalle))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHCalle);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHCalle);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHColonia))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHColonia);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHColonia);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHEntidad))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHEntidad);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHEntidad);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHMunicipio))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHMunicipio);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHMunicipio);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHCP))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHCP);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHCP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHLada))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHLada);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHLada);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHNumero))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHNumero);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHNumero);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHCelular))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHCelular);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHCelular);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosIDDerechoHEmail))
                    {
                        _drawText.Default(_SolicitudL4.DatosIDDerechoHEmail);
                        AddDraw(graphics, _drawText, _PointF.DatosIDDerechoHEmail);
                    }
                    if (_SolicitudL4.DatosIDDerechoHGenero != null)
                    {
                        AddCircle(graphics, _PointF.DatosIDDerechoHGenero);
                    }
                    if (_SolicitudL4.DatosIDDerechoHEstadoCivil != null)
                    {
                        AddCircle(graphics, _PointF.DatosIDDerechoHEstadoCivil);
                    }
                    if (_SolicitudL4.DatosIDDerechoHRegimenMatrimonial != null)
                    {
                        AddCircle(graphics, _PointF.DatosIDDerechoHRegimenMatrimonial);
                    }

                    #endregion
                    #region 7. REFERENCIAS FAMILIARES DEL DERECHOHABIENTE

                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef1APellidoP))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1APellidoP);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1APellidoP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef1ApellidoM))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1ApellidoM);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1ApellidoM);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef1Nombre))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1Nombre);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1Nombre);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef1Lada))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1Lada);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1Lada);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef1Numero))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1Numero);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1Numero);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef1Celular))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1Celular);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1Celular);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef2APellidoP))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef2APellidoP);
                        AddDraw(graphics, _drawText, _PointF.DatosRef2APellidoP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef2ApellidoM))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef2ApellidoM);
                        AddDraw(graphics, _drawText, _PointF.DatosRef2ApellidoM);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef2Nombre))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef2Nombre);
                        AddDraw(graphics, _drawText, _PointF.DatosRef2Nombre);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef2Lada))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef2Lada);
                        AddDraw(graphics, _drawText, _PointF.DatosRef2Lada);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef2Numero))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef2Numero);
                        AddDraw(graphics, _drawText, _PointF.DatosRef2Numero);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRef2Celular))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef2Celular);
                        AddDraw(graphics, _drawText, _PointF.DatosRef2Celular);
                    }

                    #endregion

                    break;
                case 2:

                    #region 8. DATOS PARA ABONO EN CUENTA DEL CRÉDITO
                    AddCircle(graphics, _PointF.DatosAbonoCuentaCDatoDel);
                    AddCircle(graphics, _PointF.DatosAbonoCuentaCAdminContruccion);

                    /*if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCDatoDel))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1APellidoP);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1APellidoP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCAdminContruccion))
                    {
                        _drawText.Default(_SolicitudL4.DatosRef1APellidoP);
                        AddDraw(graphics, _drawText, _PointF.DatosRef1APellidoP);
                    }*/
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCNombre))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCNombre);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCNombre);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCRFC))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCRFC);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCRFC);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCNombreEstadoCuenta))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCNombreEstadoCuenta);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCNombreEstadoCuenta);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCClabe))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCClabe);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCClabe);
                    }

                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCNCInfonavit1))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCNCInfonavit1);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCNCInfonavit1);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCNCInfonavit2)){
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCNCInfonavit2);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCNCInfonavit2);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCNInventario))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCNInventario);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCNInventario);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosAbonoCuentaCNCFinanciera))
                    {
                        _drawText.Default(_SolicitudL4.DatosAbonoCuentaCNCFinanciera);
                        AddDraw(graphics, _drawText, _PointF.DatosAbonoCuentaCNCFinanciera);
                    }


                    #endregion
                    #region 9. DESIGNACIÓN DE REPRESENTANTE

                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteApellidoP))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteApellidoP);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteApellidoP);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteApellidoM))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteApellidoM);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteApellidoM);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteNombre))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteNombre);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteNombre);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteLada))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteLada);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteLada);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteNumero))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteNumero);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteNumero);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteCelular))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteCelular);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteCelular);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.DatosRepresentanteIFEPasaporte))
                    {
                        _drawText.Default(_SolicitudL4.DatosRepresentanteIFEPasaporte);
                        AddDraw(graphics, _drawText, _PointF.DatosRepresentanteIFEPasaporte);
                    }

                    #endregion
                    #region 10. DATOS DE IDENTIFICACIÓN DEL CONTACTO
                    #endregion
                    #region 11. OFERTA VINCULANTE
                    AddCircle(graphics, _PointF.RequiereOfertaVinculante);

                    if (!String.IsNullOrEmpty(_SolicitudL4.CiudadD)) {
                        _drawText.Default(_SolicitudL4.CiudadD);
                        AddDraw(graphics, _drawText, _PointF.CiudadD);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.a)) {
                        _drawText.Default(_SolicitudL4.a);
                        AddDraw(graphics, _drawText, _PointF.a);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.de)) {
                        _drawText.Default(_SolicitudL4.de);
                        AddDraw(graphics, _drawText, _PointF.de);
                    }
                    if (!String.IsNullOrEmpty(_SolicitudL4.del)) {
                        _drawText.Default(_SolicitudL4.del);
                        AddDraw(graphics, _drawText, _PointF.del);
                    }


                    #endregion

                    break;
                default:
                    break;
            }
        }


        #region Contenido para PDF
        private static void AddDrawWSpace(PdfGraphics graphics, DrawText drawText, PointF pointF,float space)
        {
            string str = drawText.Text.ToString().Trim();
            //string str = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
           // string str = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

            string newStr = "";
            int numberCharacter = 1;
            int countLength = 0;
            for (int i = 0; i < str.Length; i++)
            {
                newStr = str[i].ToString();
                graphics.DrawString(newStr, drawText.FontText, drawText.SolidBrush, pointF);
                pointF.X += space;
                countLength++;

            }
        }
        private static void AddDraw(PdfGraphics graphics, DrawText drawText, PointF pointF)
        {
            SizeF TextSize = graphics.MeasureString(drawText.Text, drawText.FontText, PdfStringFormat.GenericDefault, DrawIngDpi, DrawIngDpi);
            graphics.DrawString(drawText.Text.ToString(), drawText.FontText, drawText.SolidBrush, pointF);
        }
        private static void AddCircle(PdfGraphics graphics, PointF pointF)
        {
            float width = 5;
            float height = 5;
            Pen _Pen = new Pen(Color.FromArgb(23, 0, 0), 5);

            graphics.DrawEllipse(_Pen, new RectangleF(pointF, new SizeF(width, height)));
        }
        private static void AddQr(PdfGraphics graphics, QR qr, PointF pointF)
        {
            Bitmap image = QrCreate.CreateQr(qr);
            graphics.DrawImage(image, new RectangleF(pointF, new SizeF(qr.width, qr.height)));
        }
        private static void addPage(PdfDocumentProcessor processor, int newPage)
        {
            for (int i = 1; i < newPage; i++)
            {
                PdfGraphics graph = processor.CreateGraphics();
                processor.RenderNewPage(PdfPaperSize.Legal, graph);
            }
        }
        private static void AddWaterMark(PdfGraphics graphics, DrawText drawText, PointF pointF)
        {
            SizeF waterTextSize = graphics.MeasureString(drawText.Text, drawText.FontText, PdfStringFormat.GenericDefault, DrawIngDpi, DrawIngDpi);
            graphics.RotateTransform(degree);//55 vertical letter//40horizontar letter//65LegarV//30 LegalH
            graphics.DrawString(drawText.Text, drawText.FontText, drawText.SolidBrush, pointF);

        }
        #endregion


        public static SolicitudCreditoPointF DrawinUbication(float width, float height)
        {
            _PointF = new SolicitudCreditoPointF();
            //Carta vertical
            if (width == 612 && height == 792)
            {
                _PointF.TipoProducto = new PointF(117, 101);
                _PointF.TipoCredito = new PointF(168, 126);
                _PointF.CreditoEnPesos = new PointF(429, 126);
                _PointF.DestinoCredito = new PointF(380, 147);
                _PointF.PlazoCredito = new PointF(62, 255);
                //_PointF.PlazoCredito = new PointF(101, 256);
                //_PointF.PlazoCredito = new PointF(140, 256);
                //_PointF.PlazoCredito = new PointF(178, 256);
                //_PointF.PlazoCredito = new PointF(216, 256);
                //_PointF.PlazoCredito = new PointF(255, 256);
                //_PointF.SegundoCreditoSolicitado = new PointF(488, 246);
                _PointF.SegundoCreditoSolicitado = new PointF(531, 247);
                _PointF.MontoDCredSolicDerechoH = new PointF(220, 361);
                _PointF.MontoDAhorroVol = new PointF(145, 394);
                _PointF.DatoViviendaCredCalle = new PointF(43, 462);
                _PointF.DatoViviendaCredNoExt = new PointF(43, 478);
                _PointF.DatoViviendaCredNoInt = new PointF(85, 478);
                _PointF.DatoViviendaCredLote = new PointF(130, 478);
                _PointF.DatoViviendaCredMza = new PointF(173, 478);
                _PointF.DatoViviendaCredColFrac = new PointF(230, 478);
                _PointF.DatoViviendaCredEntidad = new PointF(41, 495);
                _PointF.DatoViviendaCredMunicDeleg = new PointF(281, 495);
                _PointF.DatoViviendaCredCP = new PointF(483, 495);
                //_PointF.DatoViviendaCredPDiscap = new PointF(262, 518);
                _PointF.DatoViviendaCredPDiscap = new PointF(262, 518);
                _PointF.DatoViviendaCredMontoPresup = new PointF(325, 571);
                _PointF.DatoViviendaCredMontoAfectacion = new PointF(421, 599);




                _PointF.DatosEmprPatrNombre = new PointF(41, 645);
                _PointF.DatosEmprPatrNRegistroP = new PointF(400, 645);
                _PointF.DatosEmprPatrLada = new PointF(160, 666);
                _PointF.DatosEmprPatrNumero = new PointF(200, 666);
                _PointF.DatosEmprPatrExt = new PointF(305, 666);


                //faltan
                _PointF.DatosIDDerechoHNSS = new PointF(50, 88);
                _PointF.DatosIDDerechoHCURP = new PointF(190, 88);
                _PointF.DatosIDDerechoHRFC = new PointF(380, 88);
                _PointF.DatosIDDerechoHAPellidoP = new PointF(50, 108);
                _PointF.DatosIDDerechoHApellidoM = new PointF(307, 108);
                _PointF.DatosIDDerechoHNombre = new PointF(50, 128);
                _PointF.DatosIDDerechoHCalle = new PointF(50, 157);
                _PointF.DatosIDDerechoHColonia = new PointF(50, 177);
                _PointF.DatosIDDerechoHEntidad = new PointF(305, 177);
                _PointF.DatosIDDerechoHMunicipio = new PointF(50, 197);
                _PointF.DatosIDDerechoHCP = new PointF(235, 197);
                _PointF.DatosIDDerechoHLada = new PointF(80, 219);
                _PointF.DatosIDDerechoHNumero = new PointF(120, 219);
                _PointF.DatosIDDerechoHCelular = new PointF(255, 219);
                _PointF.DatosIDDerechoHEmail = new PointF(115, 246);


                if (_SolicitudL4.DatosIDDerechoHGenero==EGenero.F)
                {
                    _PointF.DatosIDDerechoHGenero = new PointF(424, 225);
                }
                else if (_SolicitudL4.DatosIDDerechoHGenero == EGenero.M)
                {
                    _PointF.DatosIDDerechoHGenero = new PointF(407, 226);
                }

                if (_SolicitudL4.DatosIDDerechoHEstadoCivil == EEstadoCivil.Soltero)
                {
                    _PointF.DatosIDDerechoHEstadoCivil = new PointF(112, 262);
                }
                else if (_SolicitudL4.DatosIDDerechoHEstadoCivil == EEstadoCivil.Casado)
                {
                    _PointF.DatosIDDerechoHEstadoCivil = new PointF(149, 263);
                }

                if (_SolicitudL4.DatosIDDerechoHRegimenMatrimonial == ERegimen.SeparadoBienes)
                {
                    _PointF.DatosIDDerechoHRegimenMatrimonial = new PointF(348, 262);
                }
                else if (_SolicitudL4.DatosIDDerechoHRegimenMatrimonial == ERegimen.SociedadConyugal)
                {
                    _PointF.DatosIDDerechoHRegimenMatrimonial = new PointF(422, 262);
                }
                else if (_SolicitudL4.DatosIDDerechoHRegimenMatrimonial == ERegimen.SociedadLegal)
                {
                    _PointF.DatosIDDerechoHRegimenMatrimonial = new PointF(485, 262);
                }

                _PointF.DatosRef1APellidoP = new PointF(50, 544);
                _PointF.DatosRef1ApellidoM = new PointF(50, 565);
                _PointF.DatosRef1Nombre = new PointF(50, 586);
                _PointF.DatosRef1Lada = new PointF(80, 609);
                _PointF.DatosRef1Numero = new PointF(120, 609);
                _PointF.DatosRef1Celular = new PointF(80, 626);

                _PointF.DatosRef2APellidoP = new PointF(310, 544);
                _PointF.DatosRef2ApellidoM = new PointF(310, 565);
                _PointF.DatosRef2Nombre = new PointF(310, 586);
                _PointF.DatosRef2Lada = new PointF(345, 609);
                _PointF.DatosRef2Numero = new PointF(375, 609);
                _PointF.DatosRef2Celular = new PointF(345, 629);

                //tercera hoja
                _PointF.DatosAbonoCuentaCDatoDel= new PointF(272, 72);
                _PointF.DatosAbonoCuentaCAdminContruccion = new PointF(179, 90);
                _PointF.DatosAbonoCuentaCNombre = new PointF(55, 99);
                _PointF.DatosAbonoCuentaCRFC = new PointF(60, 154);
                _PointF.DatosAbonoCuentaCNombreEstadoCuenta = new PointF(55, 170);
                _PointF.DatosAbonoCuentaCClabe = new PointF(55, 234);

                _PointF.DatosAbonoCuentaCNCInfonavit1 = new PointF(175, 274);



                _PointF.DatosRepresentanteApellidoP = new PointF(55, 372);
                _PointF.DatosRepresentanteApellidoM = new PointF(310, 372);
                _PointF.DatosRepresentanteNombre = new PointF(55, 389);
                _PointF.DatosRepresentanteLada = new PointF(84, 405);
                _PointF.DatosRepresentanteNumero = new PointF(120, 405);
                _PointF.DatosRepresentanteCelular = new PointF(255, 405);
                _PointF.DatosRepresentanteIFEPasaporte = new PointF(390, 405);

                _PointF.RequiereOfertaVinculante = new PointF(225, 607);
                _PointF.CiudadD = new PointF(110, 677);
                _PointF.a = new PointF(338, 677);
                _PointF.de = new PointF(374, 677);
                _PointF.del = new PointF(505, 677);

            }
            //Carta Horizontal
            if (width == 792 && height == 612)
            {
            }

            //Officio Vertical
            if (width == 612 && height == 1008)
            {
            }
            //oficio Horizontal
            if (width == 1008 && height == 612)
            {
            }
            return _PointF;
        }


    }
}
