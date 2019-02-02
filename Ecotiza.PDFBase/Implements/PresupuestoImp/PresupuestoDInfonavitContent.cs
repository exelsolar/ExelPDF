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
using Ecotiza.PDFBase.Domain.Presupuesto;

namespace Ecotiza.PDFBase.Implements.PresupuestoImp
{
    /// <summary>
    /// Clase para agregar elementos en el PDF Solicitud De Credito L4
    /// </summary>
    public static class PresupuestoDInfonavitContent
    {
        private static float degree = 0;
        const float DrawIngDpi = 72f;
        private static PresupuestoDInfonavit _Presupuesto;
        public static PresupuestoDInfonavitPointF _PointF;

        private static DrawText _drawText = new DrawText();

        public static void NPageContent(PdfGraphics graphics, int NPage, float width, float height, PresupuestoDInfonavit Presupuesto)
        {
            _Presupuesto = Presupuesto;
            DrawinUbication(width, height);

            switch (NPage)
            {
                case 0:

                    #region 1 Datos desglose
                    foreach (var i in Presupuesto.PresupuestoDModelLst) {
                        if (!String.IsNullOrEmpty(i.Unidad))
                        {
                            _drawText.Default(i.Unidad);
                            AddDraw(graphics, _drawText, _PointF.Unidad);
                        }
                        if (!String.IsNullOrEmpty(i.Cantidad))
                        {
                            _drawText.Default(i.Cantidad);
                            AddDraw(graphics, _drawText, _PointF.Cantidad);
                        }
                        if (!String.IsNullOrEmpty(i.PrecioUnitario))
                        {
                            _drawText.Default(i.PrecioUnitario);
                            AddDraw(graphics, _drawText, _PointF.PrecioUnitario);
                        }
                        if (!String.IsNullOrEmpty(i.Importe))
                        {
                            _drawText.Default(i.Importe);
                            AddDraw(graphics, _drawText, _PointF.Importe);
                        }
                        if (!String.IsNullOrEmpty(i.SubTotal))
                        {
                            _drawText.Default(i.SubTotal);
                            AddDraw(graphics, _drawText, _PointF.SubTotal);
                        }
                    }
                    if (!String.IsNullOrEmpty(Presupuesto.TotalTexto))
                    {
                        _drawText.Default(Presupuesto.TotalTexto);
                        AddDraw(graphics, _drawText, _PointF.TotalTexto);
                    }
                    if (!String.IsNullOrEmpty(Presupuesto.TotalCTexto))
                    {
                        _drawText.Default(Presupuesto.TotalCTexto);
                        AddDraw(graphics, _drawText, _PointF.TotalCTexto);
                    }
                    #endregion
                    break;
                case 1:


                    break;

                default:
                    break;
            }
        }


        #region Contenido para PDF

        private static void AddDraw(PdfGraphics graphics, DrawText drawText, PointF pointF)
        {
            SizeF TextSize = graphics.MeasureString(drawText.Text, drawText.FontText, PdfStringFormat.GenericDefault, DrawIngDpi, DrawIngDpi);
            graphics.DrawString(drawText.Text.ToString(), drawText.FontText, drawText.SolidBrush, pointF);
        }

        private static void addPage(PdfDocumentProcessor processor, int newPage)
        {
            for (int i = 1; i < newPage; i++)
            {
                PdfGraphics graph = processor.CreateGraphics();
                processor.RenderNewPage(PdfPaperSize.Legal, graph);
            }
        }

        #endregion


        public static PresupuestoDInfonavitPointF DrawinUbication(float width, float height)
        {
            _PointF = new PresupuestoDInfonavitPointF();
            //Carta vertical
            if (width == 612 && height == 792)
            {
                _PointF.Nombre = new PointF(117, 101);
                _PointF.Unidad = new PointF(117, 101);
                _PointF.Cantidad = new PointF(168, 126);
                _PointF.PrecioUnitario = new PointF(168, 126);
                _PointF.Importe = new PointF(168, 126);
                _PointF.SubTotal = new PointF(168, 126);
                _PointF.TotalTexto = new PointF(168, 126);
                _PointF.TotalCTexto = new PointF(168, 126);


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
