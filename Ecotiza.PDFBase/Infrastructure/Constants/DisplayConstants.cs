namespace Ecotiza.PDFBase.Infrastructure.Constants
{
    public class DisplayConstants
    {
        //Gender
        public const string GenderMale = "Hombre";
        public const string GenderFemale = "Mujer";

        //Status
        public const string StatusActive = "Activo";
        public const string StatusInactive = "Inactivo";

        //Question
        public const string Afirmative = "Si";
        public const string Negative = "No";

        //Validator
        public const string InvalidDayOfWeek = "No es día laboral";
        public const string InvalidHour = "Fuera de horario laboral";
        public const string InvalidPatentNumberDuplicated = "Número de patente existente en el sistema, favor de probar con otro";
        public const string InvalidNameDuplicated = "Nombre existente en el sistema, favor de probar con otro";
        public const string InvalidEmailDuplicated = "Email existente en el sistema, favor de probar con otro";
        public const string InvalidRequest = "La solicitud a la página que intento acceder es inválida";
        public const string InvalidMaxNumberOfPartnersReached = "Máximo número de colaboradores activos permitidos alcanzado.";
        public const string InvalidMaxNumberOfCounselorsReached = "Actualmente existe un consejero activo.";
        public const string InvalidSolicitudeSuplenceNotaryActive = "El notario ya tiene una suplencia aprobada.";
        public const string InvalidSolicitudeSuplenceNotaryInSuplence = "El notario suplente ya se encuentra supliendo a otra notaría en este momento.";
        public const string InvalidRecordNotFound = "No se encontró el acta o no se encuentra en el estado correcto para poder realizar esta operación.";
        public const string InvalidSolicitudeNotaryNotFound = "No se encontró una solicitud en vigencia y activa para el acta.";

        //Success
        public const string SuccessAccountLostPassword = "Contraseña generada y enviada por correo electrónico";
        public const string SuccessAccountChangePassword = "Contraseña actualizada correctamente";
        public const string SuccessSolicitudeInscription = "Solicitud exitosa";
        public const string SuccessSolicitudeReinscription = "Solicitud de reinscripción exitosa";
        public const string SuccessSolicitudeInscriptionCorrection = "Envío de corrección exitosa";
        public const string SuccessSolicitudeChangePersonalData = "Envío de solicitud de corrección de datos personales exitosa";
        public const string SuccessBiometricValidation = "Validación exitosa";
        public const string SuccessHash = "Firma aplicada con éxito";
        public const string SuccessSendToNextSignHash = "Correo enviado con éxito al siguiente compareciente por firmar";
        public const string SuccessReSendToNextSignHash = "Correo enviado con éxito de nuevo al compareciente por firmar";
        public const string SuccessRemoveSignHashCustomer = "Se ha removido satisfactoriamente la firma del compareciente";
        public const string SuccessCorrection = "Corrección exitosa";
        public const string SuccessFolioRequest = "Solicitud creada con éxito";
        public const string SuccessFolioDelivery = "Cancelación de folio creada con éxito";
        public const string SuccessFolioDeliveryDate = "Fecha de entrega actualizada con éxito";
        public const string SuccessEditPersonalData = "La información personal fue actualizada con éxito";
        public const string SuccessActivationRequest = "Solicitud del protocolo electrónico realizada exitosamente";
        public const string SuccessActRequest = "Acto creado con éxito";
        public const string SuccessChangeStatus = "Estado actualizado correctamente";
        public const string SuccessChangeRolNotary = "Rol actualizado correctamente";
        public const string SuccessCandidateNewRequest = "La información fue creada con éxito";
        public const string SuccessCandidateEditRequest = "La información fue actualizada con éxito";
        public const string SuccessPartnerCreateRequest = "El colaborador fue registrado con éxito";
        public const string SuccessCounselorCreateRequest = "El consejero fue registrado con éxito";
        public const string SuccessEditRequest = "La información fue actualizada con éxito";
        public const string SuccessSolicitudeLicence = "Solicitud creada con éxito";
        public const string SuccessCloseNotaryOffice = "Cierre de notaría aplicada con éxito";
        public const string SuccessReplySolicitudeNotary = "Solicitud respondida con éxito";
        public const string SuccessAgreementNotary = "Convenio de colaboración guardado con éxito";
        public const string SuccessRemoveBiometricConfiguration = "Dispositivo biométrico removido con éxito";
        public const string SuccessUpdateBiometricConfiguration = "Dispositivo biométrico actualizado con éxito";
        public const string SuccessInsertBiometricConfiguration = "Dispositivo biométrico registrado con éxito";
        public const string DeclineHash = "Acta Rechazada";

        //Information
        public const string InformationNotFound = "No se encontro el elemento para actualizar";

        public const string InvalidNotaryType = "Antes de asignar el rol Archivo Notarial o Presidente, el notario debe tener el rol de Base.";

        public const string FailureSolicitudeInscription = "No se pudo realizar la conexión con el servicio web de lNSEJUPY";
        public const string FailureHash = "Firma invalida";
        public const string FailureSolicitudeDaysPerYear = "Solo se permite realizar solicitudes a partir de un día hasta un año";
        public const string FailureSolicitudeByAccepts = "Ya existe una solicitud en proceso o aceptada, no puede registrar una nueva";
        public const string FailureByElectionPeriod = "No se puede realizar por periodo electoral";

    }
}