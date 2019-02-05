using Ecotiza.PDFBase.Infrastructure.Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.Presupuesto
{
    public class PresupuestoInfonavit
    {
        #region 1. Presupuesto Infonavit Datos Informativos

        public bool MejoramientoVivienda { get; set; }
        public bool EmprendedorContructor { get; set; }
        public string DerechoHPNombre { get; set; }
        public string DerechoHPApellidoP { get; set; }
        public string DerechoHPApellidoM { get; set; }
        public string DerechoHPNSS { get; set; }
        public string DerechoHPRFC { get; set; }
        public string DerechoHDCalle { get; set; }
        public string DerechoHDColonia { get; set; }
        public string DerechoHDCP { get; set; }
        public string DerechoHDNumE { get; set; }
        public string DerechoHOfertaVCiudad { get; set; }
        public string DerechoHOfertaVEstado { get; set; }

        public string FechaLugar { get; set; }

        #endregion
        #region 1. Presupuesto Infonavit Datos Informativos vivienda

        public string DerechoHVCalle { get; set; }
        public string DerechoHVColonia { get; set; }
        public string DerechoHVCP { get; set; }
        public string DerechoHVNumE { get; set; }
        public string DerechoHVOfertaVCiudad { get; set; }
        public string DerechoHVOfertaVEstado { get; set; }

        #endregion
        #region 3. Presupuesto Infonavit

        public string Id { get; set; }
        public string CostoInstalación { get; set; }
        public string CostoOtros { get; set; }
        public string SubTotal { get; set; }
        public string CostoServicio16 { get; set; }
        private string total { get; set; }
        private string totalTexto { get; set; }
        private string totalCTexto { get; set; }
        public double Total
        {
            set
            {
                string[] array = value.ToString("n2").Split('.');
                int totalInt = Convert.ToInt32(array[0].ToString().Replace(",", ""));
                total = value.ToString("n2");
                totalTexto = worlds.numbertoWords(totalInt);
                totalCTexto = array[1];
            }
        }
        public string TotalT
        {
            get
            {
                return this.total;
            }
        }

        public string TotalTexto
        {
            get
            {
                return this.totalTexto;
            }
        }
        public string TotalCTexto
        {
            get
            {
                return this.totalCTexto;
            }
        }
        #endregion


    }
}
