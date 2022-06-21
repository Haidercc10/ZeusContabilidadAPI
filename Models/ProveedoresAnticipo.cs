using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProveedoresAnticipo
    {
        public string IdProveedor { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Auxiliar { get; set; } = null!;
        public int PorDefecto { get; set; }
        public decimal Cupo { get; set; }
        public int IdenProveedoresAnticipos { get; set; }

        public virtual Maecont CuentaNavigation { get; set; } = null!;
        public virtual Proveedore IdProveedorNavigation { get; set; } = null!;
    }
}
