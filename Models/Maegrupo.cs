using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maegrupo
    {
        public Maegrupo()
        {
            Maeconts = new HashSet<Maecont>();
        }

        public string Codigrupo { get; set; } = null!;
        public string Descgrupo { get; set; } = null!;
        public byte Nivegrupo { get; set; }
        public string Depegrupo { get; set; } = null!;
        public DateTime? Fecgrupo { get; set; }
        public int? Ncdcgrupo { get; set; }
        public string? Tipogrupo { get; set; }
        public int Deshabilitado { get; set; }
        public int IdenMaegrupo { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual ICollection<Maecont> Maeconts { get; set; }
    }
}
