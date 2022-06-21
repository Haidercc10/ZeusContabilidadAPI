using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempControlDocumentario
    {
        public decimal Iden { get; set; }
        public int SpId { get; set; }
        public decimal Consecutivo { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public decimal Valor { get; set; }
    }
}
