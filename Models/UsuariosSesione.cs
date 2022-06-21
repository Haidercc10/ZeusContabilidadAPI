using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuariosSesione
    {
        public decimal IdenSesion { get; set; }
        public decimal? Idusuario { get; set; }
        public string? Login { get; set; }
        public DateTime? Fechaingreso { get; set; }
        public string? Hostname { get; set; }
        public string? Hostprocess { get; set; }
        public string? Hostnameapp { get; set; }
        public string? Hostprocessapp { get; set; }
        public short? Spid1 { get; set; }
        public short? Spid2 { get; set; }
        public int? IdenLibro { get; set; }
        public int? IdenMoneda { get; set; }
        public bool? Salidaexitosa { get; set; }
        public string TipoMenu { get; set; } = null!;
        public bool Zim { get; set; }
    }
}
