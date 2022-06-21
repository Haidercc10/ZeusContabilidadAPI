using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClientesEmail
    {
        public string Idcliente { get; set; } = null!;
        public string EmailDefecto { get; set; } = null!;
        public string EmailComprobantes { get; set; } = null!;
        public string EmailFacturaElectronica { get; set; } = null!;
        public string EmailExtracto { get; set; } = null!;
    }
}
