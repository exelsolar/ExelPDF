using Ecotiza.PDFBase.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.SolicitudDCredito
{
    /// <summary>
    /// Clase con campos para asignacion de valores de cada campo del PDF Solicitud De Credito L4
    /// </summary>
    public class SolicitudCreditoL4
    {

        #region 1. CRÉDITO SOLICITADO

        public int? TipoProducto { get; set; }
        //string EntidadFinanciera { get; set; }
        public int? TipoCredito { get; set; }
        public bool CreditoEnPesos { get; set; }
        public int? DestinoCredito { get; set; }
        public int? PlazoCredito { get; set; }
        public bool SegundoCreditoSolicitado { get; set; }

        #endregion
        #region 2. DATOS PARA DETERMINAR EL MONTO DE CRÉDITO

        /// <summary>
        /// Derechohabiente.- Desconto Mensual por pensión alimenticia Sin senctavos.
        /// </summary>
        public int? DescMPPAlimDerechoH { get; set; }
        /// <summary>
        /// Cónyuge.- Desconto Mensual por pensión alimenticia Sin senctavos
        /// </summary>
        public int? DescMPPAlimConyuge { get; set; }
        /// <summary>
        /// Derechohabiente.- Monto de crédito solicitado Sin senctavos.
        /// </summary>
        public string MontoDCredSolicDerechoH { get; set; }
        /// <summary>
        /// Cónyuge.- Monto de crédito solicitado Sin senctavos
        /// </summary>
        public int? MontoDCredSolicConyuge { get; set; }
        /// <summary>
        /// Monto de ahorro voluntario
        /// </summary>
        public string MontoDAhorroVol { get; set; }

        #endregion
        #region 3. DATOS DE LA VIVIENDA DESTINO DEL CRÉDITO

        public string DatoViviendaCredCalle { get; set; }
        public string DatoViviendaCredNoExt { get; set; }
        public string DatoViviendaCredNoInt { get; set; }
        public string DatoViviendaCredLote { get; set; }
        public string DatoViviendaCredMza { get; set; }
        public string DatoViviendaCredColFrac { get; set; }
        public string DatoViviendaCredEntidad { get; set; }
        public string DatoViviendaCredMunicDeleg { get; set; }
        public string DatoViviendaCredCP { get; set; }
        public bool DatoViviendaCredPDiscap { get; set; }
        public string DatoViviendaCredMontoPresup { get; set; }
        public bool DatoViviendaCredMontoAfectacion { get; set; }

        #endregion
        #region 4. DATOS DE LA EMPRESA O PATRÓN

        public string DatosEmprPatrNombre { get; set; }
        public string DatosEmprPatrNRegistroP { get; set; }
        public string DatosEmprPatrLada { get; set; }
        public string DatosEmprPatrNumero { get; set; }
        public string DatosEmprPatrExt { get; set; }

        #endregion
        #region 5. DATOS DE IDENTIFICACIÓN DEL DERECHOHABIENTE

        public string DatosIDDerechoHNSS { get; set; }
        public string DatosIDDerechoHCURP{ get; set; }
        public string DatosIDDerechoHRFC{ get; set; }
        public string DatosIDDerechoHAPellidoP{ get; set; }
        public string DatosIDDerechoHApellidoM { get; set; }
        public string DatosIDDerechoHNombre { get; set; }
        public string DatosIDDerechoHCalle{ get; set; }
        public string DatosIDDerechoHColonia { get; set; }
        public string DatosIDDerechoHEntidad { get; set; }
        public string DatosIDDerechoHMunicipio { get; set; }
        public string DatosIDDerechoHCP { get; set; }
        public string DatosIDDerechoHLada { get; set; }
        public string DatosIDDerechoHNumero { get; set; }
        public string DatosIDDerechoHCelular { get; set; }
        public string DatosIDDerechoHEmail { get; set; }
        public EGenero DatosIDDerechoHGenero { get; set; }
        public EEstadoCivil DatosIDDerechoHEstadoCivil { get; set; }
        public ERegimen DatosIDDerechoHRegimenMatrimonial { get; set; }

        #endregion
        #region 6. DATOS DE IDENTIFICACIÓN DEL CÓNYUGE
        //No son necesarios agregar despues
        #endregion
        #region 7. REFERENCIAS FAMILIARES DEL DERECHOHABIENTE

        public string DatosRef1APellidoP { get; set; }
        public string DatosRef1ApellidoM { get; set; }
        public string DatosRef1Nombre { get; set; }
        public string DatosRef1Lada { get; set; }
        public string DatosRef1Numero { get; set; }
        public string DatosRef1Celular { get; set; }
        public string DatosRef2APellidoP { get; set; }
        public string DatosRef2ApellidoM { get; set; }
        public string DatosRef2Nombre { get; set; }
        public string DatosRef2Lada { get; set; }
        public string DatosRef2Numero { get; set; }
        public string DatosRef2Celular { get; set; }

        #endregion
        #region 8. DATOS PARA ABONO EN CUENTA DEL CRÉDITO

        public EDatosDel DatosAbonoCuentaCDatoDel { get; set; }
        public EAdminContruccion DatosAbonoCuentaCAdminContruccion { get; set; }
        public string DatosAbonoCuentaCNombre { get; set; }
        public string DatosAbonoCuentaCRFC { get; set; }
        public string DatosAbonoCuentaCNombreEstadoCuenta { get; set; }
        public string DatosAbonoCuentaCClabe { get; set; }

        public string DatosAbonoCuentaCNCInfonavit1 { get; set; }
        public string DatosAbonoCuentaCNCInfonavit2{ get; set; }
        public string DatosAbonoCuentaCNInventario { get; set; }
        public string DatosAbonoCuentaCNCFinanciera { get; set; }


        #endregion
        #region 9. DESIGNACIÓN DE REPRESENTANTE

        public string DatosRepresentanteApellidoP { get; set; }
        public string DatosRepresentanteApellidoM { get; set; }
        public string DatosRepresentanteNombre { get; set; }
        public string DatosRepresentanteLada { get; set; }
        public string DatosRepresentanteNumero { get; set; }
        public string DatosRepresentanteCelular { get; set; }
        public string DatosRepresentanteIFEPasaporte { get; set; }

        #endregion
        #region 10. DATOS DE IDENTIFICACIÓN DEL CONTACTO
        #endregion
        #region 11. OFERTA VINCULANTE
        public bool RequiereOfertaVinculante { get; set; }
        public string CiudadD { get; set; }
        public string a { get; set; }
        public string de { get; set; }
        public string del { get; set; }
        #endregion
    }
}
