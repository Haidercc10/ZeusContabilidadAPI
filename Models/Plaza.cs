using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Plaza
    {
        public string Idplaza { get; set; } = null!;
        public string Descrip { get; set; } = null!;
        public byte? Nivplazas { get; set; }
        public string? Depplazas { get; set; }
        public DateTime? Fecplazas { get; set; }
        public int? Ncdplazas { get; set; }
        public string? Tipoplazas { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenPlazas { get; set; }
    }
}
