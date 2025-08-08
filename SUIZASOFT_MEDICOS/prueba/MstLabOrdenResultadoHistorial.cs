using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenResultadoHistorial
    {
        public string LohYearorden { get; set; }
        public int LohIdServicio { get; set; }
        public int LohIdExaCodigo { get; set; }
        public DateTime LohFechaDesvalidacion { get; set; }
        public string LohExaNombre { get; set; }
        public int? LohLisCodigo { get; set; }
        public string LohResultado { get; set; }
        public int? LohMuestraCodigo { get; set; }
        public string LohUnidadNombre { get; set; }
        public string LohValorReferencial { get; set; }
        public string LohUsuarioValidacion { get; set; }
        public DateTime? LohFechaValidacion { get; set; }
        public string LohUsuarioDesvalidacion { get; set; }
        public int? LohMetodoCodigo { get; set; }
        public string LohMetodoDescriptivo { get; set; }
        public int? LohEquipoCodigo { get; set; }
        public string LohEquipoDescripcion { get; set; }
        public int? LohSeccionCodigo { get; set; }
        public string LohSeccionDescripcion { get; set; }
        public bool? LohFlagFueraRango { get; set; }
        public string LohUsuarioRegistro { get; set; }
        public DateTime? LohChaRegistro { get; set; }
        public string LohUsuarioModificacion { get; set; }
        public DateTime? LohFechaModificacion { get; set; }
        public bool? LohEstado { get; set; }
        public bool? LohIdTexto { get; set; }
        public string LohNombrePerfil { get; set; }
        public bool? LohLagPerfil { get; set; }
        public string LohEsultTipoDato { get; set; }
        public string LohResultComentario { get; set; }
        public bool? LohFlagImpreso { get; set; }
        public bool? LohFlagAntibiograma { get; set; }
        public bool? LohFlagReporte { get; set; }
        public bool? LohFlagConfidencial { get; set; }
        public decimal? LohReferenciaMin { get; set; }
        public decimal? LohReferenciaMax { get; set; }
        public bool? LohFlagCerrado { get; set; }
        public string LohSubtitulo { get; set; }
        public string LohResultadoOrigen { get; set; }
        public string LohCantDecimal { get; set; }
        public string LohFlagDesvalidacion { get; set; }
        public string LohCt1 { get; set; }
        public string LohCt2 { get; set; }
        public string LohRutaAws { get; set; }
        public string LohComentarioFijo { get; set; }
    }
}
