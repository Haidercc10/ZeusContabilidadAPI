using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Propiedad1
    {
        public Propiedad1()
        {
            SaldoPropiedad1s = new HashSet<SaldoPropiedad1>();
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

        public virtual ICollection<SaldoPropiedad1> SaldoPropiedad1s { get; set; }
    }
}
