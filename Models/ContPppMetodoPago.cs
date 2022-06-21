using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppMetodoPago
    {
        public ContPppMetodoPago()
        {
            ContPppProgramaciones = new HashSet<ContPppProgramacione>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Habilitado { get; set; }
        public string? Cuenta { get; set; }
        public string? Moneda { get; set; }
        public string? Banco { get; set; }
        public string? Plaza { get; set; }
        public bool? Gerencia { get; set; }
        public int? IdenGerencia { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public string? Chequera { get; set; }
        public string? RptFormato { get; set; }
        public string? GastoInterBanc { get; set; }
        public bool IndPresupuestoPublico { get; set; }
        public string Aplica { get; set; } = null!;
        public string? FuenteDefault { get; set; }
        public string? SerieDefault { get; set; }
        public string TipoCuentaGerencia { get; set; } = null!;
        public string NumeroCuentaGerencia { get; set; } = null!;

        public virtual Maecont? CuentaNavigation { get; set; }
        public virtual ICollection<ContPppProgramacione> ContPppProgramaciones { get; set; }
    }
}
