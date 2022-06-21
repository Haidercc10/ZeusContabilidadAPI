using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IntMoraNovedadesDetalle
    {
        public int Iden { get; set; }
        public int IdMoraNovedades { get; set; }
        public string FechaUltimaMora { get; set; } = null!;
        public decimal SactfacCorte { get; set; }
        public string FuenteCorte { get; set; } = null!;
        public string DocumentoCorte { get; set; } = null!;
        public string FechaCorte { get; set; } = null!;
        public decimal Dias { get; set; }
        public decimal ValorImoraCorte { get; set; }
        public decimal ValorImoraIvaCorte { get; set; }
        public DateTime FechaGrabacion { get; set; }
        public string? Bu { get; set; }
        public decimal VrMoraContabilizada { get; set; }
        public decimal VrMoraIvaContabilizada { get; set; }

        public virtual IntMoraNovedade IdMoraNovedadesNavigation { get; set; } = null!;
    }
}
