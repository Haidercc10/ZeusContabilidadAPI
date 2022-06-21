using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Tipocliente
    {
        public Tipocliente()
        {
            Clientes = new HashSet<Cliente>();
        }

        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? ComplementoGravado { get; set; }
        public string? ComplementoExcluido { get; set; }
        public string? ComplementoExento { get; set; }
        public string? ComplementoGravadoDevolucion { get; set; }
        public string? ComplementoExcluidoDevolucion { get; set; }
        public string? ComplementoExentoDevolucion { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenTipoclientes { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
