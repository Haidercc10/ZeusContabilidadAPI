using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBogotaTarEfectiva
    {
        public string? CodEmpresa { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string? Cuenta { get; set; }
        public string? TipoCuenta { get; set; }
        public string? NoConvenio { get; set; }
        public int IdenGerbogotaTarefectiva { get; set; }
    }
}
