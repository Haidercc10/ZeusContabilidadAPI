using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SolicitudPresupuestoTransac
    {
        public int Iden { get; set; }
        public int? IdenSolicitudPresupuesto { get; set; }
        public string? CodCta { get; set; }
        public string? CodCco { get; set; }
        public string? CodCtaDestino { get; set; }
        public string? CodCcoDestino { get; set; }
        public decimal? Mes0 { get; set; }
        public decimal? Mes1 { get; set; }
        public decimal? Mes2 { get; set; }
        public decimal? Mes3 { get; set; }
        public decimal? Mes4 { get; set; }
        public decimal? Mes5 { get; set; }
        public decimal? Mes6 { get; set; }
        public decimal? Mes7 { get; set; }
        public decimal? Mes8 { get; set; }
        public decimal? Mes9 { get; set; }
        public decimal? Mes10 { get; set; }
        public decimal? Mes11 { get; set; }
        public decimal? Mes12 { get; set; }
        public string? Mesorigen { get; set; }
        public int? IdenRelacionado { get; set; }
        public int? Aprobado { get; set; }

        public virtual SolicitudPresupuesto? IdenSolicitudPresupuestoNavigation { get; set; }
    }
}
