using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusContabilidadVersione
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public byte[]? Archivo { get; set; }
        public string? Usuario { get; set; }
        public DateTime? FechaGrabacion { get; set; }
        public DateTime? FechaVersion { get; set; }
    }
}
