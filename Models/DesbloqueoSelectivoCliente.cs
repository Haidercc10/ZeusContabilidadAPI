using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class DesbloqueoSelectivoCliente
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = null!;
        public string? Codicta { get; set; }
        public string? Idcliente { get; set; }
    }
}
