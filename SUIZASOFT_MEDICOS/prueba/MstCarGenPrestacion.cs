using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstCarGenPrestacion
    {
        public string GenC1RucEmpresa { get; set; }
        public string GenC2CodigoIpress { get; set; }
        public string GenC3TipoDocumentoPago { get; set; }
        public string GenC4NumeroDocumentoPago { get; set; }
        public string GenC5CorrelativoPrestacion { get; set; }
        public string GenC6CodigoPrestacionInternoIpress { get; set; }
        public char? GenC7TipoAfiliacion { get; set; }
        public string GenC8CodigoAseguradoPaciente { get; set; }
        public char? GenC9TipoDocumentoIdentidad { get; set; }
        public string GenC10NumeroDocumentoIdentidad { get; set; }
        public string GenC11NumeroHistoriaClinica { get; set; }
        public string GenC12DocAutorizacionPrestacion { get; set; }
        public string GenC13NroDocAutorizacion { get; set; }
        public string GenC14SegundoDocAutorizPrestacion { get; set; }
        public string GenC15NumeroSegundoDocautorizacion { get; set; }
        public char? GenC16TipoCoberturaPrestacion { get; set; }
        public string GenC17SubtipoCoberturaPrestacion { get; set; }
        public string GenC18PrimerDiagnostico { get; set; }
        public string GenC19SegundoDiagnostico { get; set; }
        public string GenC20TercerDiagnostico { get; set; }
        public string GenC21FechaPrestacion { get; set; }
        public string GenC22HoraInicioPrestacion { get; set; }
        public string GenC23TipoProfResponsPrestac { get; set; }
        public string GenC24NumeroColegiatura { get; set; }
        public char? GenC25TipodocIdentidProfesional { get; set; }
        public string GenC26NrodocIdentidProfesional { get; set; }
        public string GenC27RucEntidadReferencia { get; set; }
        public string GenC28FechaTransferencia { get; set; }
        public string GenC29HoraTransferencia { get; set; }
        public char? GenC30TipoHospitalizacion { get; set; }
        public string GenC31FechaIngresoHospitalario { get; set; }
        public string GenC32FechaEgresoHospitalario { get; set; }
        public string GenC33TipoEgresoHospitalario { get; set; }
        public string GenC34DiasEstanciaFacturable { get; set; }
        public decimal? GenC35GastoHonorarioProcSinigv { get; set; }
        public decimal? GenC36GastoProcOdontologSinigv { get; set; }
        public decimal? GenC37GastoPresHotServClintopSinigv { get; set; }
        public decimal? GenC38GastoExamAuxlabSinigv { get; set; }
        public decimal? GenC39GastoExamAuximagSinigv { get; set; }
        public decimal? GenC40GastoFarmacInsumSinigv { get; set; }
        public decimal? GenC41GastoProteSinigv { get; set; }
        public decimal? GenC42GastoProdservmedExonigv { get; set; }
        public decimal? GenC43OtrosGastprestsaludSinigv { get; set; }
        public decimal? GenC44CopagoFijoAfectigvSinigv { get; set; }
        public decimal? GenC45CopagoFijoExonigv { get; set; }
        public decimal? GenC46CopagoVarAfectigvSinigv { get; set; }
        public decimal? GenC47CopagoVarExonigv { get; set; }
        public decimal? GenC48TotalGastoscubSinigv { get; set; }
        public string GenSerie { get; set; }
        public string GenNumeroFactura { get; set; }
        public int GenUsuarioCreacion { get; set; }
        public DateTime GenFechaCreacion { get; set; }
        public string GenNumeroLote { get; set; }
        public int? GenNumeroAtencion { get; set; }
        public string GenCodFina { get; set; }
    }
}
