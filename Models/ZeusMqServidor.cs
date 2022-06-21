using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusMqServidor
    {
        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string BrokerHost { get; set; } = null!;
        public string BrokerPort { get; set; } = null!;
        public string BrokerUser { get; set; } = null!;
        public string BrokerPassword { get; set; } = null!;
        public int Deshabilitado { get; set; }
    }
}
