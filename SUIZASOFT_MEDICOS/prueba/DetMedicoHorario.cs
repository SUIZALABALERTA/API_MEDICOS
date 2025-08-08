using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetMedicoHorario
    {
        public int DmhId { get; set; }
        public int? DmhIdMedico { get; set; }
        public DateOnly? DmhFecha { get; set; }
        public TimeOnly? DmhHoraInicio { get; set; }
        public TimeOnly? DmhHoraFin { get; set; }
        public int? DmhTiempoAtencion { get; set; }
        public string DmhUsuarioCreacion { get; set; }
        public DateTime? DmhFechaCreacion { get; set; }
        public string DmhUsuarioModificacion { get; set; }
        public DateTime? DmhFechaModificacion { get; set; }
        public bool? DmhEstado { get; set; }
        public string DmhDia { get; set; }
        public string DmhIdSucursal { get; set; }
        public int? DmhIdEspecialidad { get; set; }

        public virtual MstServicioAreaNegocio DmhIdEspecialidadNavigation { get; set; }
        public virtual MstMedico DmhIdMedicoNavigation { get; set; }
        public virtual MstSucursal DmhIdSucursalNavigation { get; set; }
    }
}
