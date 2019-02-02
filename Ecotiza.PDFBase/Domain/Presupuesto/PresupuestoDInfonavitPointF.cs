using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.Presupuesto
{
    public class PresupuestoDInfonavitPointF
    {
        #region 1. Presupuesto Infonavit Datos Informativos

        public PointF Nombre { get; set; }
        public PointF Unidad { get; set; }
        public PointF Cantidad { get; set; }
        public PointF PrecioUnitario { get; set; }
        public PointF Importe { get; set; }
        public PointF SubTotal { get; set; }
        public PointF Total { get; set; }
        public PointF TotalTexto { get; set; }
        public PointF TotalCTexto { get; set; }
        public PointF LugarFecha { get; set; }
        #endregion

    }
}
