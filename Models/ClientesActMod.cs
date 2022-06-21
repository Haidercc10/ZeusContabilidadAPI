using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ClientesActMod
    {
        public int Spid { get; set; }
        public string Cliente { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Idmodelo { get; set; } = null!;
        public string IdDocum { get; set; } = null!;
        public int Status { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenClientesactmod { get; set; }
    }
}
