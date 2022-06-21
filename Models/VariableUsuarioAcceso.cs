using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableUsuarioAcceso
    {
        public short SpId { get; set; }
        public int IdenRoll { get; set; }
        public string Login { get; set; } = null!;
        public string? HostName { get; set; }
        public string? IpLocal { get; set; }
        public string? PortLocal { get; set; }
        public string? Aplicacion { get; set; }
        public int IdenVariableusuarioaccesos { get; set; }

        public virtual VariableRole IdenRollNavigation { get; set; } = null!;
    }
}
