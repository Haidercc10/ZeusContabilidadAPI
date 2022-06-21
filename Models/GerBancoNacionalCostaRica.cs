using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoNacionalCostaRica
    {
        public string Nitcia { get; set; } = null!;
        public string? Numcli { get; set; }
        public string? Moneda { get; set; }
        public string? Oficina { get; set; }
        public string? Producto { get; set; }
        public string? Numcta { get; set; }
        public int? Dvcta { get; set; }
        public int IdenGerbanconacionalcostarica { get; set; }
    }
}
