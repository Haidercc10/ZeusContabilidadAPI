using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeCategoria
    {
        public MaeCategoria()
        {
            Factconcs = new HashSet<Factconc>();
            Maeconts = new HashSet<Maecont>();
        }

        public string Idcategoria { get; set; } = null!;
        public string Descategoria { get; set; } = null!;
        public byte Nivcategoria { get; set; }
        public string Depcategoria { get; set; } = null!;
        public DateTime? Feccategoria { get; set; }
        public int? Ncdcategoria { get; set; }
        public string? Tipocategoria { get; set; }
        public int Deshabilitado { get; set; }
        public int IdenMaecategorias { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string CodigoAlterno { get; set; } = null!;

        public virtual ICollection<Factconc> Factconcs { get; set; }
        public virtual ICollection<Maecont> Maeconts { get; set; }
    }
}
