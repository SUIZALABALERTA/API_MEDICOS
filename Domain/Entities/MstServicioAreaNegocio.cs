namespace Domain.Entities
{
    public partial class MstServicioAreaNegocio
    {
        public MstServicioAreaNegocio()
        {
            //DetLineaNegocioServicioAreas = new HashSet<DetLineaNegocioServicioArea>();
            DetMedicoAreaNegocios = new HashSet<DetMedicoAreaNegocio>();
            //MstServicios = new HashSet<MstServicio>();
        }

        public int SeaId { get; set; }
        public string SeaDescripcion { get; set; }
        public bool? SeaEstado { get; set; }
        public int? SeaCentroCostoId { get; set; }
        public string SeaAbreviaturaCodigo { get; set; }


        public string SeaSoNombre { get; set; }
        public bool? SeaSoFlagMostrar { get; set; }


        //public virtual TipCentroCostoNegocio? SeaCentroCosto { get; set; }
        //public virtual ICollection<DetLineaNegocioServicioArea> DetLineaNegocioServicioAreas { get; set; }
        public virtual ICollection<DetMedicoAreaNegocio> DetMedicoAreaNegocios { get; set; }
        //public virtual ICollection<MstServicio> MstServicios { get; set; }
    }
}
