using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerCitiBankSucursale
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Departamento { get; set; }
        public int EsCitiBank { get; set; }
        public string? Direccion { get; set; }
    }
}
