using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgReciboFactura
    {
        public string Proveedor { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string TipoFactura { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public int IdenEntrada { get; set; }
        public int IdenMpgRecibofacturas { get; set; }
    }
}
