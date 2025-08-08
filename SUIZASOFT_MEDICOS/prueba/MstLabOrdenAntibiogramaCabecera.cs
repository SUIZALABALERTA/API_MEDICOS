using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class MstLabOrdenAntibiogramaCabecera
    {
        public string LoaYearorden { get; set; }
        public string LoaIdServicio { get; set; }
        public string LoaIdExaCodigo { get; set; }
        public int LoaPanelCodigo { get; set; }
        public string LoaPanelDescripcion { get; set; }
        public int? LoaLisCodigo { get; set; }
        public string LoaCultivoNivel1 { get; set; }
        public string LoaCultivoNivel2 { get; set; }
        public string LoaCultivoNivel3 { get; set; }
        public string LoaCultivoNivel1Descripcion { get; set; }
        public string LoaCultivoNivel2Descripcion { get; set; }
        public string LoaCultivoNivel3Descripcion { get; set; }
        public string LoaCultivoNivel2Bacteria { get; set; }
        public string LoaCultivoNivel2Resultado { get; set; }
        public string LoaUsuarioRegistro { get; set; }
        public DateTime? LoaFechaRegistro { get; set; }
        public string LoaUsuarioModificacion { get; set; }
        public DateTime? LoaFechaModificacion { get; set; }
        public bool? LoaEstado { get; set; }
    }
}
