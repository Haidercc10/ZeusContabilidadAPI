using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgDocumentoCesion
    {
        public int Iden { get; set; }
        public int IdenRelacionado { get; set; }
        public string AnoMes { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public DateTime FechaGrabacion { get; set; }
        public string Usuario { get; set; } = null!;
        public string ProveedorOriginal { get; set; } = null!;
        public decimal Saldo { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Descipcion { get; set; } = null!;
        public string UltimaFecha { get; set; } = null!;
        public string UltimoTipoDocumento { get; set; } = null!;
        public string UltimaFuente { get; set; } = null!;
        public string UltimoDocumento { get; set; } = null!;
        public decimal UltimoValor { get; set; }

        public virtual MpgDocumento IdenRelacionadoNavigation { get; set; } = null!;
    }
}
