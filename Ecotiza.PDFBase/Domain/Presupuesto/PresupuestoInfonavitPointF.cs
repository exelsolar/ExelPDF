using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.Presupuesto
{
    public class PresupuestoInfonavitPointF
    {
        #region 1. Presupuesto Infonavit Datos Informativos

        public PointF MejoramientoVivienda { get; set; }
        public PointF EmprendedorContructor { get; set; }
        public PointF DerechoHPNombre { get; set; }
        public PointF DerechoHPApellidoP { get; set; }
        public PointF DerechoHPApellidoM { get; set; }
        public PointF DerechoHPNSS { get; set; }
        public PointF DerechoHPRFC { get; set; }
        public PointF DerechoHDCalle { get; set; }
        public PointF DerechoHDColonia { get; set; }
        public PointF DerechoHDCP { get; set; }
        public PointF DerechoHDNumE { get; set; }
        public PointF DerechoHOfertaVCiudad { get; set; }
        public PointF DerechoHOfertaVEstado { get; set; }
        public PointF FechaLugar { get; set; }

        #endregion
        #region 1. Presupuesto Infonavit Datos Informativos vivienda

        public PointF DerechoHVCalle { get; set; }
        public PointF DerechoHVColonia { get; set; }
        public PointF DerechoHVCP { get; set; }
        public PointF DerechoHVNumE { get; set; }
        public PointF DerechoHVOfertaVCiudad { get; set; }
        public PointF DerechoHVOfertaVEstado { get; set; }

        #endregion
        #region 3. Presupuesto Infonavit

        public PointF Id { get; set; }
        public PointF CostoInstalación { get; set; }
        public PointF CostoOtros { get; set; }
        public PointF SubTotal { get; set; }
        public PointF CostoServicio16 { get; set; }
        public PointF Total { get; set; }
        public PointF TotalTexto { get; set; }
        public PointF TotalCTexto { get; set; }
        #endregion

    }
}
