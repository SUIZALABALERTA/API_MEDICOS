using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetPaqueteDetalle
    {
        public int PadIdPaqueteCab { get; set; }
        public int PadIdservicio { get; set; }
        public string PadNumpqc { get; set; }
        public string PadNumano { get; set; }
        public string PadNumfox { get; set; }
        public decimal? PadCostoMinimoServicio { get; set; }
        public string PadNumtfp { get; set; }
        public string PadNumfpers { get; set; }
        public decimal? PadValorUnitarioSinIgv { get; set; }
        public string PadUsuarioCreacion { get; set; }
        public DateTime? PadFechaCreacion { get; set; }
        public string PadUsuarioModificacion { get; set; }
        public DateTime? PadFechaModificacion { get; set; }
        public decimal? PadValorUnitarioConIgv { get; set; }

        public virtual MstPaqueteCabecera PadIdPaqueteCabNavigation { get; set; }
        public virtual MstServicio PadIdservicioNavigation { get; set; }
    }
}
