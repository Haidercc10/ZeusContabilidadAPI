using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioHistorialCambioEstado
    {
        public decimal Iden { get; set; }
        public decimal Consecutivo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? EstadoAnterior { get; set; }
        public decimal? EstadoActual { get; set; }
        public string Usuario { get; set; } = null!;
        public string? FlujoCaja { get; set; }
        public decimal? IdenPpp { get; set; }
        public decimal? IdenFacturasCtrlDoc { get; set; }
        public decimal ConsecutivoHistorial { get; set; }
    }
}
