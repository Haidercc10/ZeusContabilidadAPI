using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Terceros = new HashSet<Tercero>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? IdDian { get; set; }
        public int IndNit { get; set; }
        public string CodigoCompra { get; set; } = null!;
        public string CodigoVenta { get; set; } = null!;
        public int LongitudMax { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenTipoidentificacion { get; set; }
        public string? CodigoAlterno { get; set; }
        public int LongitudMin { get; set; }

        public virtual ICollection<Tercero> Terceros { get; set; }
    }
}
