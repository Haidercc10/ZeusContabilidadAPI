using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TsunatVentasLog
    {
        public string Nit { get; set; } = null!;
        public string Compania { get; set; } = null!;
        public string Cuo { get; set; } = null!;
        public string Correlativo { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string Ruc { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public decimal VrExportacion { get; set; }
        public decimal VrVenta { get; set; }
        public decimal InafectoIgv { get; set; }
        public decimal ExoneradaIgv { get; set; }
        public decimal AfectoIgv { get; set; }
        public decimal VrIgv { get; set; }
        public decimal VrServicios { get; set; }
        public decimal VrPropinas { get; set; }
        public decimal Total { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal TasaCambio { get; set; }
        public string FechaDev { get; set; } = null!;
        public string TipoFacturaDev { get; set; } = null!;
        public string SerieFacturaDev { get; set; } = null!;
        public string FacturaDev { get; set; } = null!;
        public int IdAplicacion { get; set; }
        public string ConsecutivoInterno { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public decimal VentaMoneda { get; set; }
        public decimal InafectoIgvMoneda { get; set; }
        public decimal AfectoIgvMoneda { get; set; }
        public decimal IgvMoneda { get; set; }
        public decimal VrServiciosMoneda { get; set; }
        public decimal VrPropinasMoneda { get; set; }
        public decimal TotalMoneda { get; set; }
        public string FormaDePago { get; set; } = null!;
        public string CuentaContrapartida { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string TipoVenta { get; set; } = null!;
        public string TipoPersona { get; set; } = null!;
        public string Apellido1 { get; set; } = null!;
        public string Apellido2 { get; set; } = null!;
        public string Nombre1 { get; set; } = null!;
        public string Nombre2 { get; set; } = null!;
        public decimal Isc { get; set; }
        public string TipoMoneda { get; set; } = null!;
        public string CodigoDestino { get; set; } = null!;
        public string NumeroDestino { get; set; } = null!;
        public string IndicadorPrecepcion { get; set; } = null!;
        public string CodigoPrecepcion { get; set; } = null!;
        public string SeriePrecepcion { get; set; } = null!;
        public string ComprobantePrecepcion { get; set; } = null!;
        public string BaseReferencia { get; set; } = null!;
        public string Igvreferencia { get; set; } = null!;
        public decimal OtrosMontos { get; set; }
        public string FacturaEnDolar { get; set; } = null!;
        public string FechaReporte { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Host { get; set; } = null!;
        public DateTime FechaEvento { get; set; }
        public string Observaciones { get; set; } = null!;
        public decimal Idregistro { get; set; }
        public int EstadoRegistro { get; set; }
        public string Operacion { get; set; } = null!;
    }
}
