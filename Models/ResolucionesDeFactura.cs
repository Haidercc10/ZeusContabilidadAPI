using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ResolucionesDeFactura
    {
        public ResolucionesDeFactura()
        {
            ResolucionVsMaquinas = new HashSet<ResolucionVsMaquina>();
        }

        public decimal Iden { get; set; }
        public string NoResolucion { get; set; } = null!;
        public DateTime FechaResolucion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Prefijo { get; set; } = null!;
        public string RangoInicialLegal { get; set; } = null!;
        public string RangoFinalLegal { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string RangoInicialInterno { get; set; } = null!;
        public string RangoFinalInterno { get; set; } = null!;
        public string Resolucion { get; set; } = null!;
        public bool ValidDiasAlertVigenc { get; set; }
        public int? DiasAlertVigenc { get; set; }
        public bool ValidDiasAlertDcto { get; set; }
        public int? DiasAlertDcto { get; set; }
        public string? ClaveDosificacion { get; set; }
        public bool ValVigencia { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual ICollection<ResolucionVsMaquina> ResolucionVsMaquinas { get; set; }
    }
}
