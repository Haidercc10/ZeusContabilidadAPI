using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AplicacionesFuncionesVariable
    {
        public string Variable { get; set; } = null!;
        public string? Campo { get; set; }
        public int IdenAplicacionesfuncionesvariables { get; set; }
    }
}
