using System;
using System.Collections.Generic;

namespace SUIZASOFT_MEDICOS.prueba
{
    public partial class DetTopicoMuestra
    {
        public int DtmIdTopico { get; set; }
        public int DtmIdMuestra { get; set; }
        public bool? DtmEstado { get; set; }
        public string DtmUsuarioCreacion { get; set; }
        public DateTime? DtmFechaCreacion { get; set; }
        public string DtmUsuarioEscaneo { get; set; }
        public DateTime? DtmFechaEscaneo { get; set; }
        public string DtmEnvioPara { get; set; }
        public string DtmEnvioDesde { get; set; }
        public string DtmLote { get; set; }
        public string DtmIdentificadorEnvioPara { get; set; }
        public string DtmIdentificadorEnvioDesde { get; set; }

        public virtual TipMuestraLaboratorio DtmIdMuestraNavigation { get; set; }
        public virtual MstTopicoEscaneo DtmIdTopicoNavigation { get; set; }
    }
}
