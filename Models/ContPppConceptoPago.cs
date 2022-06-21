using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppConceptoPago
    {
        public ContPppConceptoPago()
        {
            ContPppProgramacionesPagos = new HashSet<ContPppProgramacionesPago>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public bool? Habilitado { get; set; }
        public string? Cuenta { get; set; }
        public string? Idcenco { get; set; }
        public string? Auxiliar { get; set; }
        public string? Item { get; set; }
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public string? Bu { get; set; }
        public decimal? TasaCambio { get; set; }
        public string Moneda { get; set; } = null!;
        public int DetalleTercero { get; set; }

        public virtual ICollection<ContPppProgramacionesPago> ContPppProgramacionesPagos { get; set; }
    }
}
