using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPoliza
    {
        public int IdPoliza { get; set; }
        public string CodPoliza { get; set; } = null!;
        public string CodSeguro { get; set; } = null!;
        public string FechaInicio { get; set; } = null!;
        public string FechaFinal { get; set; } = null!;
        public decimal ValorAsegurado { get; set; }
        public string CodUsuario { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Prestamo { get; set; } = null!;
        public int PeriodoP { get; set; }
        public decimal ValorInteres { get; set; }
        public string TipoDescuento { get; set; } = null!;
        public string? FuenteRenovacion { get; set; }
        public string? DocumentoRenovacion { get; set; }

        public virtual MfSeguro CodSeguroNavigation { get; set; } = null!;
        public virtual MfDatosusuario CodUsuarioNavigation { get; set; } = null!;
    }
}
