using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FactCliModHistorico
    {
        public int Id { get; set; }
        public string? IdCliente { get; set; }
        public string? IdDocumento { get; set; }
        public string? IdModelo { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Operacion { get; set; }
        public int? Estado { get; set; }
        public string? IdUsuario { get; set; }
        public string Bu { get; set; } = null!;
    }
}
