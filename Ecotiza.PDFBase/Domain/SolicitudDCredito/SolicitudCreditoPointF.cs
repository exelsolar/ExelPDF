using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.SolicitudDCredito
{
    /// <summary>
    /// Clase con campos para asignacion de posion de cada campo del PDF Solicitud De Credito L4
    /// </summary>
    public class SolicitudCreditoPointF
    {


        #region 1. CRÉDITO SOLICITADO
        public PointF TipoProducto { get; set; }
        public PointF EntidadFinanciera { get; set; }
        public PointF TipoCredito { get; set; }
        public PointF CreditoEnPesos { get; set; }
        public PointF DestinoCredito { get; set; }
        public PointF PlazoCredito { get; set; }
        public PointF SegundoCreditoSolicitado { get; set; }
        #endregion
        #region 2. DATOS PARA DETERMINAR EL MONTO DE CRÉDITO
        /// <summary>
        /// Derechohabiente.- Desconto Mensual por pensión alimenticia Sin senctavos.
        /// </summary>
        public PointF DescMPPAlimDerechoH { get; set; }
        /// <summary>
        /// Cónyuge.- Desconto Mensual por pensión alimenticia Sin senctavos
        /// </summary>
        public PointF DescMPPAlimConyuge { get; set; }
        /// <summary>
        /// Derechohabiente.- Monto de crédito solicitado Sin senctavos.
        /// </summary>
        public PointF MontoDCredSolicDerechoH { get; set; }
        /// <summary>
        /// Cónyuge.- Monto de crédito solicitado Sin senctavos
        /// </summary>
        public PointF MontoDCredSolicConyuge { get; set; }
        /// <summary>
        /// Monto de ahorro voluntario
        /// </summary>
        public PointF MontoDAhorroVol { get; set; }

        #endregion
        #region 3. DATOS DE LA VIVIENDA DESTINO DEL CRÉDITO

        public PointF DatoViviendaCredCalle { get; set; }
        public PointF DatoViviendaCredNoExt { get; set; }
        public PointF DatoViviendaCredNoInt { get; set; }
        public PointF DatoViviendaCredLote { get; set; }
        public PointF DatoViviendaCredMza { get; set; }
        public PointF DatoViviendaCredColFrac { get; set; }
        public PointF DatoViviendaCredEntidad { get; set; }
        public PointF DatoViviendaCredMunicDeleg { get; set; }
        public PointF DatoViviendaCredCP { get; set; }
        public PointF DatoViviendaCredPDiscap { get; set; }
        public PointF DatoViviendaCredMontoPresup { get; set; }
        public PointF DatoViviendaCredMontoAfectacion { get; set; }

        #endregion
        #region 4. DATOS DE LA EMPRESA O PATRÓN

        public PointF DatosEmprPatrNombre { get; set; }
        public PointF DatosEmprPatrNRegistroP { get; set; }
        public PointF DatosEmprPatrLada { get; set; }
        public PointF DatosEmprPatrNumero { get; set; }
        public PointF DatosEmprPatrExt { get; set; }

        #endregion
        #region 5. DATOS DE IDENTIFICACIÓN DEL DERECHOHABIENTE

        public PointF DatosIDDerechoHNSS { get; set; }
        public PointF DatosIDDerechoHCURP { get; set; }
        public PointF DatosIDDerechoHRFC { get; set; }
        public PointF DatosIDDerechoHAPellidoP { get; set; }
        public PointF DatosIDDerechoHApellidoM { get; set; }
        public PointF DatosIDDerechoHNombre { get; set; }
        public PointF DatosIDDerechoHCalle { get; set; }
        public PointF DatosIDDerechoHColonia { get; set; }
        public PointF DatosIDDerechoHEntidad { get; set; }
        public PointF DatosIDDerechoHMunicipio { get; set; }
        public PointF DatosIDDerechoHCP { get; set; }
        public PointF DatosIDDerechoHLada { get; set; }
        public PointF DatosIDDerechoHNumero { get; set; }
        public PointF DatosIDDerechoHCelular { get; set; }
        public PointF DatosIDDerechoHEmail { get; set; }
        public PointF DatosIDDerechoHGenero { get; set; }
        public PointF DatosIDDerechoHEstadoCivil { get; set; }
        public PointF DatosIDDerechoHRegimenMatrimonial { get; set; }

        #endregion
        #region 6. DATOS DE IDENTIFICACIÓN DEL CÓNYUGE
        //No son necesarios agregar despues
        #endregion
        #region 7. REFERENCIAS FAMILIARES DEL DERECHOHABIENTE

        public PointF DatosRef1APellidoP { get; set; }
        public PointF DatosRef1ApellidoM { get; set; }
        public PointF DatosRef1Nombre { get; set; }
        public PointF DatosRef1Lada { get; set; }
        public PointF DatosRef1Numero { get; set; }
        public PointF DatosRef1Celular { get; set; }
        public PointF DatosRef2APellidoP { get; set; }
        public PointF DatosRef2ApellidoM { get; set; }
        public PointF DatosRef2Nombre { get; set; }
        public PointF DatosRef2Lada { get; set; }
        public PointF DatosRef2Numero { get; set; }
        public PointF DatosRef2Celular { get; set; }

        #endregion

        #region 8. DATOS PARA ABONO EN CUENTA DEL CRÉDITO

        public PointF DatosAbonoCuentaCDatoDel { get; set; }
        public PointF DatosAbonoCuentaCAdminContruccion { get; set; }
        public PointF DatosAbonoCuentaCNombre { get; set; }
        public PointF DatosAbonoCuentaCRFC { get; set; }
        public PointF DatosAbonoCuentaCNombreEstadoCuenta { get; set; }
        public PointF DatosAbonoCuentaCClabe { get; set; }

        public PointF DatosAbonoCuentaCNCInfonavit1 { get; set; }
        public PointF DatosAbonoCuentaCNCInfonavit2 { get; set; }
        public PointF DatosAbonoCuentaCNInventario { get; set; }
        public PointF DatosAbonoCuentaCNCFinanciera { get; set; }


        #endregion
        #region 9. DESIGNACIÓN DE REPRESENTANTE

        public PointF DatosRepresentanteApellidoP { get; set; }
        public PointF DatosRepresentanteApellidoM { get; set; }
        public PointF DatosRepresentanteNombre { get; set; }
        public PointF DatosRepresentanteLada { get; set; }
        public PointF DatosRepresentanteNumero { get; set; }
        public PointF DatosRepresentanteCelular { get; set; }
        public PointF DatosRepresentanteIFEPasaporte { get; set; }

        #endregion
        #region 10. DATOS DE IDENTIFICACIÓN DEL CONTACTO

        #endregion

        #region 11. OFERTA VINCULANTE

        public PointF RequiereOfertaVinculante { get; set; }
        public PointF CiudadD { get; set; }
        public PointF a { get; set; }
        public PointF de { get; set; }
        public PointF del { get; set; }

        #endregion

    }
}
