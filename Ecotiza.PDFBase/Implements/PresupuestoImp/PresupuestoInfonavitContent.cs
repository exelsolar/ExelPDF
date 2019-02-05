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
    public static class PresupuestoInfonavitContent
    {
        private static float degree = 0;
        const float DrawIngDpi = 72f;
        private static PresupuestoInfonavit _Presupuesto;
        public static PresupuestoInfonavitPointF _PointF;

        private static DrawText _drawText = new DrawText();

        public static void NPageContent(PdfGraphics graphics, int NPage, float width, float height, PresupuestoInfonavit Presupuesto)
        {
            _Presupuesto = Presupuesto;
            DrawinUbication(width, height);

            switch (NPage)
            {
                case 0:
                    #region 1 Datos Presupuesto
                    if (_Presupuesto.MejoramientoVivienda)
                    {
                        _drawText.Default("X");
                        AddDraw(graphics, _drawText, _PointF.MejoramientoVivienda);
                    }
                    if (_Presupuesto.EmprendedorContructor)
                    {
                        _drawText.Default("X");
                        AddDraw(graphics, _drawText, _PointF.EmprendedorContructor);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHPNombre))
                    {
                        _drawText.Default(_Presupuesto.DerechoHPNombre);
                        AddDraw(graphics, _drawText, _PointF.DerechoHPNombre);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHPNSS))
                    {
                        _drawText.Default(_Presupuesto.DerechoHPNSS);
                        AddDraw(graphics, _drawText, _PointF.DerechoHPNSS);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHPRFC))
                    {
                        _drawText.Default(_Presupuesto.DerechoHPRFC);
                        AddDraw(graphics, _drawText, _PointF.DerechoHPRFC);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHDCalle))
                    {
                        _drawText.Default(_Presupuesto.DerechoHDCalle);
                        AddDraw(graphics, _drawText, _PointF.DerechoHDCalle);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHDColonia))
                    {
                        _drawText.Default(_Presupuesto.DerechoHDColonia);
                        AddDraw(graphics, _drawText, _PointF.DerechoHDColonia);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHDCP))
                    {
                        _drawText.Default(_Presupuesto.DerechoHDCP);
                        AddDraw(graphics, _drawText, _PointF.DerechoHDCP);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHOfertaVCiudad))
                    {
                        _drawText.Default(_Presupuesto.DerechoHOfertaVCiudad);
                        AddDraw(graphics, _drawText, _PointF.DerechoHOfertaVCiudad);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHOfertaVEstado))
                    {
                        _drawText.Default(_Presupuesto.DerechoHOfertaVEstado);
                        AddDraw(graphics, _drawText, _PointF.DerechoHOfertaVEstado);
                    }
                    #endregion
                    #region vivienda
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHVCalle))
                    {
                        _drawText.Default(_Presupuesto.DerechoHVCalle);
                        AddDraw(graphics, _drawText, _PointF.DerechoHVCalle);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHVNumE))
                    {
                        _drawText.Default(_Presupuesto.DerechoHVNumE);
                        AddDraw(graphics, _drawText, _PointF.DerechoHVNumE);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHVColonia))
                    {
                        _drawText.Default(_Presupuesto.DerechoHVColonia);
                        AddDraw(graphics, _drawText, _PointF.DerechoHVColonia);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHVCP))
                    {
                        _drawText.Default(_Presupuesto.DerechoHVCP);
                        AddDraw(graphics, _drawText, _PointF.DerechoHVCP);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHVOfertaVCiudad))
                    {
                        _drawText.Default(_Presupuesto.DerechoHVOfertaVCiudad);
                        AddDraw(graphics, _drawText, _PointF.DerechoHVOfertaVCiudad);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.DerechoHVOfertaVEstado))
                    {
                        _drawText.Default(_Presupuesto.DerechoHVOfertaVEstado);
                        AddDraw(graphics, _drawText, _PointF.DerechoHVOfertaVEstado);
                    }
                    #endregion
                    #region Datos Presupuesto Dinero
                    if (!String.IsNullOrEmpty(_Presupuesto.CostoInstalación))
                    {
                        _drawText.Default(_Presupuesto.CostoInstalación);
                        AddDraw(graphics, _drawText, _PointF.CostoInstalación);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.CostoOtros))
                    {
                        _drawText.Default(_Presupuesto.CostoOtros);
                        AddDraw(graphics, _drawText, _PointF.CostoOtros);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.SubTotal))
                    {
                        _drawText.Default(_Presupuesto.SubTotal);
                        AddDraw(graphics, _drawText, _PointF.SubTotal);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.CostoServicio16))
                    {
                        _drawText.Default(_Presupuesto.CostoServicio16);
                        AddDraw(graphics, _drawText, _PointF.CostoServicio16);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.TotalT))
                    {
                        _drawText.Default(_Presupuesto.TotalT);
                        AddDraw(graphics, _drawText, _PointF.Total);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.TotalTexto))
                    {
                        _drawText.Default(_Presupuesto.TotalTexto);
                        AddDraw(graphics, _drawText, _PointF.TotalTexto);
                    }
                    if (!String.IsNullOrEmpty(_Presupuesto.TotalCTexto))
                    {

                        _drawText.SolidBrush = new SolidBrush(Color.FromArgb(23, 0, 0));
                        _drawText.FontText = new Font("Arial", 6, FontStyle.Bold);
                        _drawText.Text = _Presupuesto.TotalCTexto;
                        AddDraw(graphics, _drawText, _PointF.TotalCTexto);
                    }
                    #endregion

                    if (!String.IsNullOrEmpty(_Presupuesto.FechaLugar))
                    {
                        _drawText.Default(_Presupuesto.FechaLugar);
                        AddDraw(graphics, _drawText, _PointF.FechaLugar);
                    }
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


        public static PresupuestoInfonavitPointF DrawinUbication(float width, float height)
        {
            _PointF = new PresupuestoInfonavitPointF();
            //Carta vertical
            if (width == 612 && height == 792)
            {
                _PointF.DerechoHPNombre = new PointF(117, 88);               
                _PointF.DerechoHPNSS = new PointF(370, 88);
                _PointF.DerechoHPRFC = new PointF(465, 88);
                _PointF.DerechoHDCalle = new PointF(148, 111);
                _PointF.DerechoHDColonia = new PointF(148, 120);
                _PointF.DerechoHDCP = new PointF(402, 120);
                _PointF.DerechoHOfertaVCiudad = new PointF(180, 129);
                _PointF.DerechoHOfertaVEstado = new PointF(402, 129);
                _PointF.MejoramientoVivienda = new PointF(223, 178);
                _PointF.EmprendedorContructor = new PointF(382, 223);


                _PointF.DerechoHVCalle = new PointF(117, 358);
                _PointF.DerechoHVNumE = new PointF(465, 358);
                _PointF.DerechoHVColonia = new PointF(117, 369);
                _PointF.DerechoHVCP = new PointF(465, 369);
                _PointF.DerechoHVOfertaVCiudad = new PointF(180, 379);
                _PointF.DerechoHVOfertaVEstado = new PointF(402, 379);



                _PointF.CostoInstalación = new PointF(397, 481);
                _PointF.CostoOtros = new PointF(397, 551);
                _PointF.SubTotal = new PointF(397, 568);
                _PointF.CostoServicio16 = new PointF(397, 580);
                _PointF.Total = new PointF(397, 592);

                _PointF.TotalTexto = new PointF(186, 611);
                _PointF.TotalCTexto = new PointF(458, 615);

                _PointF.FechaLugar = new PointF(186, 629);




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
