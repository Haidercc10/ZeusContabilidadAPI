using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesTempParametrosEntradum
    {
        public short Spid { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Valor { get; set; }
        public int IdenRolestempparametrosentrada { get; set; }
    }
}
