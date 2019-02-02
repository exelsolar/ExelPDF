using Ecotiza.PDFBase.Infrastructure.Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.Presupuesto
{
    public class PresupuestoDInfonavit
    {
        #region 1. Presupuesto Infonavit Desglosado

        public List<PresupuestoDModel> PresupuestoDModelLst { get; set; }
        private string total { get; set; }
        private string totalTexto { get; set; }
        private string totalCTexto { get; set; }
        public string LugarFecha { get; set; }
        public double Total
        {
            set
            {
                string[] array = value.ToString("n2").Split('.');
                int totalInt = Convert.ToInt32(array[0].ToString().Replace(",", ""));
                totalTexto = worlds.numbertoWords(totalInt);
                totalCTexto = array[1];
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
    public class PresupuestoDModel
    {
        public string Unidad { get; set; }
        public string Cantidad { get; set; }
        public string PrecioUnitario { get; set; }
        public string Importe { get; set; }
        public string SubTotal { get; set; }

    }
}
