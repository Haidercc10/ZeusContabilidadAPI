using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoBolivariano
    {
        public string CodigoAsignado { get; set; } = null!;
        public string? Nemonico { get; set; }
        public string? BancoBolivariano { get; set; }
        public int IdenGerbancobolivariano { get; set; }
    }
}
