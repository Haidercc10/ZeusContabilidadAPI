using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Maezona
    {
        public Maezona()
        {
            Clientes = new HashSet<Cliente>();
            Maevendes = new HashSet<Maevende>();
            MfEscTablapadres = new HashSet<MfEscTablapadre>();
            MfRenovacionCreditos = new HashSet<MfRenovacionCredito>();
            MfTablapadres = new HashSet<MfTablapadre>();
            Proveedores = new HashSet<Proveedore>();
        }

        public string Idzona { get; set; } = null!;
        public string Nombzona { get; set; } = null!;
        public byte? Nivzonas { get; set; }
        public string? Depzonas { get; set; }
        public DateTime? Feczonas { get; set; }
        public int? Ncdzonas { get; set; }
        public string? Tipozonas { get; set; }
        public string? Ubicacion { get; set; }
        public string? ComplementoGravado { get; set; }
        public string? ComplementoExcluido { get; set; }
        public string? ComplementoExento { get; set; }
        public string? ComplementoGravadoDevolucion { get; set; }
        public string? ComplementoExcluidoDevolucion { get; set; }
        public string? ComplementoExentoDevolucion { get; set; }
        public int AplicaIva { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenMaezonas { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Maevende> Maevendes { get; set; }
        public virtual ICollection<MfEscTablapadre> MfEscTablapadres { get; set; }
        public virtual ICollection<MfRenovacionCredito> MfRenovacionCreditos { get; set; }
        public virtual ICollection<MfTablapadre> MfTablapadres { get; set; }
        public virtual ICollection<Proveedore> Proveedores { get; set; }
    }
}
