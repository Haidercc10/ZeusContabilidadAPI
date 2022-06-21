using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Perfil
    {
        public int IdPerfil { get; set; }
        public string? Nombre { get; set; }
        public string IdAspNetRoles { get; set; } = null!;
        public string? NormalizedName { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public bool? IdBit { get; set; }
        public string? DescName { get; set; }
        public string? Description { get; set; }
    }
}
