using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpresoraFiscalFactura
    {
        public decimal Iden { get; set; }
        public int SpId { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Iva { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorU { get; set; }
        public decimal Descuento { get; set; }
        public string Tipoconsumo { get; set; } = null!;
        public string Formapgo { get; set; } = null!;
        public decimal Total { get; set; }
        public string Identificacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Servicio { get; set; }
        public decimal Pagosdep { get; set; }
        public string Xfpago { get; set; } = null!;
        public decimal Porcentajeiva { get; set; }
        public string Nomfactu { get; set; } = null!;
        public decimal Pagosfis { get; set; }
        public decimal Valorimpuesto { get; set; }
        public string? FacturaNumero { get; set; }
        public DateTime? FacturaFechaHora { get; set; }
        public string? Serieimpresorafiscal { get; set; }
    }
}
