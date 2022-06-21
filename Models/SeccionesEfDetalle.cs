using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SeccionesEfDetalle
    {
        public int Id { get; set; }
        public int IdSeccionCabecera { get; set; }
        public string? CodCtaIni { get; set; }
        public string? NomCtaIni { get; set; }
        public string? CodCtaFin { get; set; }
        public string? NomCtaFin { get; set; }

        public virtual SeccionesEfCabecera IdSeccionCabeceraNavigation { get; set; } = null!;
    }
}
