using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuarioAcceso
    {
        public decimal? IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public short? SpId { get; set; }
        public string? HostName { get; set; }
        public string? IpLocal { get; set; }
        public string? PortLocal { get; set; }
        public int IdenUsuarioAccesos { get; set; }
    }
}
