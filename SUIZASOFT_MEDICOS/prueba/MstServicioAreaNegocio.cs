using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstServicioAreaNegocio
    {
        public MstServicioAreaNegocio()
        {
            DetLineaNegocioServicioAreas = new HashSet<DetLineaNegocioServicioArea>();
            DetMedicoAreaNegocios = new HashSet<DetMedicoAreaNegocio>();
            DetMedicoHorarios = new HashSet<DetMedicoHorario>();
            MstCitaParticulars = new HashSet<MstCitaParticular>();
            MstLabPerfils = new HashSet<MstLabPerfil>();
            MstServicios = new HashSet<MstServicio>();
        }

        public int SeaId { get; set; }
        public string SeaDescripcion { get; set; }
        public bool? SeaEstado { get; set; }
        public int? SeaCentroCostoId { get; set; }
        public string SeaAbreviaturaCodigo { get; set; }
        public string SeaSoNombre { get; set; }
        public bool? SeaSoFlagMostrar { get; set; }
        public string SeaSoImageUrl { get; set; }

        public virtual TipCentroCostoNegocio SeaCentroCosto { get; set; }
        public virtual ICollection<DetLineaNegocioServicioArea> DetLineaNegocioServicioAreas { get; set; }
        public virtual ICollection<DetMedicoAreaNegocio> DetMedicoAreaNegocios { get; set; }
        public virtual ICollection<DetMedicoHorario> DetMedicoHorarios { get; set; }
        public virtual ICollection<MstCitaParticular> MstCitaParticulars { get; set; }
        public virtual ICollection<MstLabPerfil> MstLabPerfils { get; set; }
        public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
