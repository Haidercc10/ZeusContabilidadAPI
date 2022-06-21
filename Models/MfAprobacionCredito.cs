using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfAprobacionCredito
    {
        public int IdComite { get; set; }
        public string Fecha { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public int IdEstudio { get; set; }
        public string TipoEstudio { get; set; } = null!;
        public string CodUsuario { get; set; } = null!;
        public string TipoCredito { get; set; } = null!;
        public string CodGrupo { get; set; } = null!;
        public string TipoPrestamo { get; set; } = null!;
        public decimal SolicitudCredito { get; set; }
        public decimal VrAprobado { get; set; }
        public int Plazo { get; set; }
        public string FechaInicio { get; set; } = null!;
        public string FechaFin { get; set; } = null!;
        public string CodPoliza { get; set; } = null!;
        public decimal VrSeguro { get; set; }
        public string Estado { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public int Periodo { get; set; }
        public int IdenMfAprobacioncreditos { get; set; }
    }
}
