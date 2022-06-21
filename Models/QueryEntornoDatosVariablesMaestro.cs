using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class QueryEntornoDatosVariablesMaestro
    {
        public decimal IdenQueryEntornoDatos { get; set; }
        public string Maestro { get; set; } = null!;
        public string CampoCodigo { get; set; } = null!;
        public string? CampoCodigo2 { get; set; }
        public int IdenQueryentornodatosVariablesMaestros { get; set; }
    }
}
