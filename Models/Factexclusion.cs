using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factexclusion
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string IdCliente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string FechaIni { get; set; } = null!;
        public string FechaFin { get; set; } = null!;
        public string MotivoExclusion { get; set; } = null!;
        public string MotivoAnulacion { get; set; } = null!;
        public string UsuarioExclusion { get; set; } = null!;
        public string? UsuarioAnulacion { get; set; }
        public DateTime FechaExclusion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public bool? Estado { get; set; }
        public string Bu { get; set; } = null!;
    }
}
