using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContSistemasAperturaLibro
    {
        public decimal Iden { get; set; }
        public decimal IdenLibroOrigen { get; set; }
        public decimal IdenLibroDestino { get; set; }
        public string? Periodo { get; set; }
        public decimal Consecutivo { get; set; }
        public string? Estado { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? CtaingresoGanancia { get; set; }
        public string? CentrocostoGanancia { get; set; }
        public string? AuxiliarGanancia { get; set; }
        public string? Propiedad1Ganancia { get; set; }
        public string? Propiedad2Ganancia { get; set; }
        public string? Propiedad3Ganancia { get; set; }
        public string? Propiedad4Ganancia { get; set; }
        public string? Propiedad5Ganancia { get; set; }
        public string? ItemGanancia { get; set; }
        public string? CtaingresoPerdida { get; set; }
        public string? CentrocostoPerdida { get; set; }
        public string? AuxiliarPerdida { get; set; }
        public string? Propiedad1Perdida { get; set; }
        public string? Propiedad2Perdida { get; set; }
        public string? Propiedad3Perdida { get; set; }
        public string? Propiedad4Perdida { get; set; }
        public string? Propiedad5Perdida { get; set; }
        public string? ItemPerdida { get; set; }
    }
}
