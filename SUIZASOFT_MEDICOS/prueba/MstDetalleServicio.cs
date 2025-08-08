using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstDetalleServicio
    {
        public string DetC1RucEmpresa { get; set; }
        public string DetC2CodigoIpress { get; set; }
        public string DetC3TipoDocumentoPago { get; set; }
        public string DetC4NumeroDocumentoPago { get; set; }
        public string DetC5CorrelativoPrestac { get; set; }
        public string DetC6CorrelativoServprocPrestac { get; set; }
        public string DetC7TipoClasifProcServicio { get; set; }
        public string DetC8CodigoClasifProcServicio { get; set; }
        public string DetC9DescripcionServicio { get; set; }
        public string DetC10FechaProcservComplem { get; set; }
        public string DetC11TipoProfResponPrestac { get; set; }
        public string DetC12NumeroColegiatura { get; set; }
        public char? DetC13TipodocIdentidadProfesional { get; set; }
        public string DetC14NrodocIdentidadProfesional { get; set; }
        public string DetC15NroVecesProcedServcomplem { get; set; }
        public decimal? DetC16MontoUnitarioSinimpuestos { get; set; }
        public decimal? DetC17CopagoVarProcedservComplem { get; set; }
        public decimal? DetC18CopagoFijoProcservComplem { get; set; }
        public decimal? DetC19MontoPresentProcservComplem { get; set; }
        public decimal? DetC20MontoNocubiertoProcservComplem { get; set; }
        public string DetC21DiagnosticoAsociado { get; set; }
        public char? DetC22ServicioExentoImpuesto { get; set; }
        public string DetC23CodigoRubro { get; set; }
        public string DetSerie { get; set; }
        public string DetNroFactura { get; set; }
        public int DetUsuarioCreacion { get; set; }
        public DateTime DetFechaCreacion { get; set; }
        public string DetNumeroLote { get; set; }
        public int? DetNumeroAtencion { get; set; }
        public string DetCodFina { get; set; }
    }
}
