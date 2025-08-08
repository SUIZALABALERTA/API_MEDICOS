using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstDocumentoFacturador
    {
        public string DofC1FechaEnvio { get; set; }
        public string DofC2HoraEnvio { get; set; }
        public string DofC3NumeroLote { get; set; }
        public string DofC4CodFina { get; set; }
        public string DofC5RucEmpresa { get; set; }
        public string DofC6CodigoIpress { get; set; }
        public string DofC7TipoDocumentoPago { get; set; }
        public string DofC8NumeroDocumentoPago { get; set; }
        public string DofC9FechaEmision { get; set; }
        public string DofC10CodigoProducto { get; set; }
        public string DofC11CantidadPrestacionesSalud { get; set; }
        public string DofC12MecanismoPago { get; set; }
        public string DofC13SubtipoMecanismoPago { get; set; }
        public decimal? DofC14MontoPrepactado { get; set; }
        public string DofC15FechaInicioPeriodoPrepactado { get; set; }
        public char? DofC16TipoMoneda { get; set; }
        public decimal? DofC17MontoExoneradoIgv { get; set; }
        public decimal? DofC18TotalCopagoAfectoIgvSinigv { get; set; }
        public decimal? DofC19TotalCopagoFijoExoneradoIgv { get; set; }
        public decimal? DofC20TotalCopagoVariableAfectoIgvSinigv { get; set; }
        public decimal? DofC21TotalCopagoVariableExoneradoIgv { get; set; }
        public decimal? DofC22BaseImponible { get; set; }
        public decimal? DofC23IgvMontoFacturado { get; set; }
        public decimal? DofC24MontoTotalFacturado { get; set; }
        public char? DofC25TipoIdentificacionNota { get; set; }
        public string DofC26NumeroNota { get; set; }
        public string DofC27MontoNota { get; set; }
        public string DofC28FechaNota { get; set; }
        public char? DofC29MotivoNota { get; set; }
        public string DofC30FechaPrimerEnvioDocfac { get; set; }
        public char? DofC31IndicadorFacturaGlobal { get; set; }
        public string DofSerie { get; set; }
        public string DofCorrelativo { get; set; }
        public int DofUsuarioCreacion { get; set; }
        public DateTime DofFechaCreacion { get; set; }
        public string DofNumeroLote { get; set; }
        public int? DofNumeroAtencion { get; set; }
        public string DofCodFina { get; set; }
    }
}
