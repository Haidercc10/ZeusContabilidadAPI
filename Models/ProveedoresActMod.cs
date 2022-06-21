using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProveedoresActMod
    {
        public int Spid { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Idmodelo { get; set; } = null!;
        public string IdDocum { get; set; } = null!;
        public int Status { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenProveedoresactmod { get; set; }
    }
}
