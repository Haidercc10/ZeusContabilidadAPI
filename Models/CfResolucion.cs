using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfResolucion
    {
        public CfResolucion()
        {
            CfAutorizacions = new HashSet<CfAutorizacion>();
        }

        public int Iden { get; set; }
        public string NoAutorizacion { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public string NoSolicitud { get; set; } = null!;
        public int RangoInicial { get; set; }
        public int RangoFinal { get; set; }
        public string Prefijo { get; set; } = null!;
        public DateTime FechaAutorizacion { get; set; }
        public DateTime? FechaDeCaducidad { get; set; }
        public int AplicarAuditoriaA { get; set; }
        public string? CodDocFactura { get; set; }
        public string? NomDocFactura { get; set; }
        public string? TipoFact { get; set; }
        public bool Deshabilitada { get; set; }

        public virtual ICollection<CfAutorizacion> CfAutorizacions { get; set; }
    }
}
