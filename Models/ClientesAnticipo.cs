using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClientesAnticipo
    {
        public string IdCliente { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Auxiliar { get; set; } = null!;
        public int PorDefecto { get; set; }
        public int IdenClientesAnticipos { get; set; }

        public virtual Auxiliar AuxiliarNavigation { get; set; } = null!;
        public virtual Maecont CuentaNavigation { get; set; } = null!;
        public virtual Cliente IdClienteNavigation { get; set; } = null!;
    }
}
