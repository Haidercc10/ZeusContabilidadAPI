using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Propiedad5
    {
        public Propiedad5()
        {
            SaldoPropiedad5s = new HashSet<SaldoPropiedad5>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte Nivel { get; set; }
        public string Dependencia { get; set; } = null!;
        public int? NumeroCamposDependientes { get; set; }
        public string? Tipo { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual ICollection<SaldoPropiedad5> SaldoPropiedad5s { get; set; }
    }
}
