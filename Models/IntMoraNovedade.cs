using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IntMoraNovedade
    {
        public IntMoraNovedade()
        {
            IntMoraNovedadesDetalles = new HashSet<IntMoraNovedadesDetalle>();
        }

        public string Anomesfac { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencfac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public decimal Sactfac { get; set; }
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string FechaImora { get; set; } = null!;
        public decimal ValorImora { get; set; }
        public decimal Porcentaje { get; set; }
        public string Estado { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int Iden { get; set; }
        public string? IdcliprvAsumeIm { get; set; }
        public decimal MoraContabilizada { get; set; }

        public virtual ICollection<IntMoraNovedadesDetalle> IntMoraNovedadesDetalles { get; set; }
    }
}
