using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstProductosFarmacium
    {
        public string FarC1RucEmpresa { get; set; }
        public string FarC2CodigoIpress { get; set; }
        public string FarC3TipoDocpago { get; set; }
        public string FarC4NroDocpago { get; set; }
        public string FarC5CorrelativoPrestac { get; set; }
        public string FarC6CorrelativoProdfarmacAtenc { get; set; }
        public char? FarC7Catalprodfarmacia { get; set; }
        public string FarC8Codproducfarmacia { get; set; }
        public string FarC9CodprodObservmedDigemid { get; set; }
        public string FarC10FechaDispensFarmacia { get; set; }
        public decimal? FarC11CantidadVentaProducto { get; set; }
        public decimal? FarC12MontoUnitarioSinimpuesto { get; set; }
        public decimal? FarC13CopagoProdFarmacia { get; set; }
        public decimal? FarC14MontoPresentProdfarmacia { get; set; }
        public decimal? FarC15MontoNocubiertoProdfarmacia { get; set; }
        public string FarC16DiagnosticoAsociadoProdfarmacia { get; set; }
        public char? FarC17ProductoExentoigv { get; set; }
        public string FarC18GuiaFarmacia { get; set; }
        public string FarSerie { get; set; }
        public string FarNroFactura { get; set; }
        public int FarUsuarioCreacion { get; set; }
        public DateTime FarFechaCreacion { get; set; }
        public string FarNumeroLote { get; set; }
        public int? FarNumeroAtencion { get; set; }
        public string FarCodFina { get; set; }
        public int? FarIdMedicamento { get; set; }
    }
}
