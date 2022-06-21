using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Propiedad2
    {
        public Propiedad2()
        {
            SaldoPropiedad2s = new HashSet<SaldoPropiedad2>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte Nivel { get; set; }
        public string Dependencia { get; set; } = null!;
        public int? NumeroCamposDependientes { get; set; }
        public string? Tipo { get; set; }
        public int Deshabilitado { get; set; }
        public string? Cuenta { get; set; }
        public string? AuxiAux { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;

        public virtual ICollection<SaldoPropiedad2> SaldoPropiedad2s { get; set; }
    }
}
