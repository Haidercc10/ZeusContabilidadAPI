using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfactAutoNovedade
    {
        public CfactAutoNovedade()
        {
            CfactAutoConceptos = new HashSet<CfactAutoConcepto>();
        }

        public decimal Iden { get; set; }
        public decimal Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public string? Descripcion { get; set; }
        public string Estado { get; set; } = null!;
        public string? Moneda { get; set; }
        public DateTime? FechaTasa { get; set; }
        public decimal TasaCambio { get; set; }
        public string? Usuario { get; set; }

        public virtual ICollection<CfactAutoConcepto> CfactAutoConceptos { get; set; }
    }
}
