using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesBodyLogT
    {
        public int? SpId { get; set; }
        public int? IdenTabla { get; set; }
        public string? Codigo { get; set; }
        public string? CodigoAdicional { get; set; }
        public int? PorDefecto { get; set; }
        public int? IdenRolesBody { get; set; }
    }
}
