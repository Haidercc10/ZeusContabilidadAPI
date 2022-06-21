using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfAutorizacion
    {
        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Detalles { get; set; } = null!;
        public int IdenPuntoEmision { get; set; }
        public int IdenAreaImpresion { get; set; }
        public int? IdenTipoComprobante { get; set; }
        public int RangoInicial { get; set; }
        public int RangoFinal { get; set; }
        public string Prefijo { get; set; } = null!;
        public string NoAutorizacion { get; set; } = null!;
        public DateTime FechaAutorizacion { get; set; }
        public string NoSolicitud { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public int Consecutivo { get; set; }
        public bool Deshabilitada { get; set; }
        public DateTime? FechaDeCaducidad { get; set; }
        public string? IdMaquina { get; set; }
        public string? NombreMaquina { get; set; }
        public int? IdenResolucion { get; set; }

        public virtual CfAreaImpresion IdenAreaImpresionNavigation { get; set; } = null!;
        public virtual CfPuntoEmision IdenPuntoEmisionNavigation { get; set; } = null!;
        public virtual CfResolucion? IdenResolucionNavigation { get; set; }
        public virtual CfTipoComprobante? IdenTipoComprobanteNavigation { get; set; }
    }
}
