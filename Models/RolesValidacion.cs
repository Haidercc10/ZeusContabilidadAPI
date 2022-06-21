using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesValidacion
    {
        public string Rol { get; set; } = null!;
        public int IdProceso { get; set; }
        public int IdenRolesvalidacion { get; set; }
    }
}
