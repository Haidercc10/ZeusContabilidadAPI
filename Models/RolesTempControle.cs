using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesTempControle
    {
        public short SpId { get; set; }
        public string Formulario { get; set; } = null!;
        public string Control { get; set; } = null!;
        public string? Value { get; set; }
        public string Tabla { get; set; } = null!;
        public int IdenRolestempcontroles { get; set; }
    }
}
