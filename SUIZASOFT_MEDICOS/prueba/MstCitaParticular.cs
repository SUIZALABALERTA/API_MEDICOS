using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCitaParticular
    {
        public MstCitaParticular()
        {
            SoCitaComplementos = new HashSet<SoCitaComplemento>();
        }

        public int CpaId { get; set; }
        public int? CpaIdDoctor { get; set; }
        public int? CpaIdEspecialidad { get; set; }
        public string CpaIdSede { get; set; }
        public int CpaIdPaciente { get; set; }
        public DateOnly CpaFechaCita { get; set; }
        public TimeOnly CpaHoraCita { get; set; }
        public int CpaIdTipoAtencion { get; set; }
        public int CpaTipoServicio { get; set; }
        public int? CpaTipoSeguro { get; set; }
        public DateTime? CpaFechaCreacion { get; set; }
        public char CpaEstado { get; set; }
        public string CpaTicket { get; set; }
        public string CpaMotivoAnulacion { get; set; }
        public bool? CpaClienteNotificado { get; set; }
        public int? CpaIdServicio { get; set; }

        public virtual MstMedico CpaIdDoctorNavigation { get; set; }
        public virtual MstServicioAreaNegocio CpaIdEspecialidadNavigation { get; set; }
        public virtual MstPaciente CpaIdPacienteNavigation { get; set; }
        public virtual MstSucursal CpaIdSedeNavigation { get; set; }
        public virtual MstServicio CpaIdServicioNavigation { get; set; }
        public virtual SoTipoSeguro CpaTipoSeguroNavigation { get; set; }
        public virtual SoTipoServicio CpaTipoServicioNavigation { get; set; }
        public virtual ICollection<SoCitaComplemento> SoCitaComplementos { get; set; }
    }
}
