using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesBody
    {
        public int IdenTabla { get; set; }
        public string Codigo { get; set; } = null!;
        public string CodigoAdicional { get; set; } = null!;
        public int PorDefecto { get; set; }
        public int IdenRolesBody { get; set; }

        public virtual RolesTabla IdenTablaNavigation { get; set; } = null!;
    }
}
