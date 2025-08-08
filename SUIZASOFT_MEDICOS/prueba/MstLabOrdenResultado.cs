using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenResultado
    {
        public string LorYearorden { get; set; }
        public string LorOrdenNumero { get; set; }
        public int LorIdExaCodigo { get; set; }
        public int LorIdServicioPerfil { get; set; }
        public int? LorItem { get; set; }
        public string LorExaNombre { get; set; }
        public int? LorLisCodigo { get; set; }
        public string LorResultado { get; set; }
        public int? LorMuestraCodigo { get; set; }
        public string LorUnidadNombre { get; set; }
        public string LorValorReferencial { get; set; }
        public DateTime? LorFechaValidacion { get; set; }
        public string LorUsuarioValidacion { get; set; }
        public int? LorMetodoCodigo { get; set; }
        public string LorMetodoDescriptivo { get; set; }
        public int? LorEquipoCodigo { get; set; }
        public string LorEquipoDescripcion { get; set; }
        public int? LorSeccionCodigo { get; set; }
        public string LorSeccionDescripcion { get; set; }
        public bool? LorFlagFueraRango { get; set; }
        public string LorUsuarioRegistro { get; set; }
        public DateTime? LorFechaRegistro { get; set; }
        public string LorUsuarioModificacion { get; set; }
        public DateTime? LorFechaModificacion { get; set; }
        public bool? LorEstado { get; set; }
        public bool? LorIdTexto { get; set; }
        public string LorNombrePerfil { get; set; }
        public bool? LorFlagPerfil { get; set; }
        public string LorResultTipoDato { get; set; }
        public string LorResultComentario { get; set; }
        public bool? LorFlagImpreso { get; set; }
        public bool? LorFlagAntibiograma { get; set; }
        public bool? LorFlagReporte { get; set; }
        public bool? LorFlagConfidencial { get; set; }
        public decimal? LorReferenciaMin { get; set; }
        public decimal? LorReferenciaMax { get; set; }
        public bool? LorFlagCerrado { get; set; }
        public string LorSubtitulo { get; set; }
        public string LorResultadoOrigen { get; set; }
        public string LorCantDecimal { get; set; }
        public bool? LorFlagDesvalidacion { get; set; }
        public string LorCt1 { get; set; }
        public string LorCt2 { get; set; }
        public string LorRutaAws { get; set; }
        public string LorComentarioFijo { get; set; }
        public string LorExaNombreIngles { get; set; }
        public string LorComentarioFijoIngles { get; set; }
        public bool? LorAntibiograma { get; set; }
        public string LorSubTituloLaboratorio { get; set; }
    }
}
