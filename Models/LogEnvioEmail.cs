using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class LogEnvioEmail
    {
        public int Id { get; set; }
        public string CliPrv { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Email { get; set; }
        public string Asunto { get; set; } = null!;
        public string Texto { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Bu { get; set; } = null!;
    }
}
