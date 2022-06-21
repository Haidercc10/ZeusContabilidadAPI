using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturacionAutomatica
    {
        public FacturacionAutomatica()
        {
            FacturacionAutomaticaDetalles = new HashSet<FacturacionAutomaticaDetalle>();
        }

        public decimal Iden { get; set; }
        public string Fecha { get; set; } = null!;
        public string CtaCobrar { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public decimal? RegistroNovedad { get; set; }
        public string DocumentoI { get; set; } = null!;
        public string DocumentoF { get; set; } = null!;
        public string? Ciclos { get; set; }
        public string Usuario { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public int Dias { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Valor { get; set; }
        public int Revertido { get; set; }
        public string FuenteNota { get; set; } = null!;
        public string DocumentoNotaI { get; set; } = null!;
        public string DocumentoNotaF { get; set; } = null!;
        public string? FechaPvencimiento { get; set; }
        public string? TipoFactura { get; set; }
        public string? CxCnc { get; set; }
        public string? MonedaNc { get; set; }
        public string? TipoFacturaNc { get; set; }

        public virtual ICollection<FacturacionAutomaticaDetalle> FacturacionAutomaticaDetalles { get; set; }
    }
}
