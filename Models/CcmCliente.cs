using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmCliente
    {
        public string CodigoCliente { get; set; } = null!;
        public string CodigoTercero { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? DireccionCorrespondencia { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string Zona { get; set; } = null!;
        public string Vendedor { get; set; } = null!;
        public short? DiasDePlazo { get; set; }
        public decimal? CupoDeCredito { get; set; }
        public string CuentaDeCartera { get; set; } = null!;
        public string? NombreContacto { get; set; }
        public string? DireccionContacto { get; set; }
        public string? EmailContacto { get; set; }
        public string? TelefonoContacto { get; set; }
        public string? NombreContactoAlterno { get; set; }
        public string? DireccionContactoAlterno { get; set; }
        public string? EmailContactoAlterno { get; set; }
        public string? TelefonoContactoAlterno { get; set; }
        public string? NombreGerente { get; set; }
        public string? EmailGerente { get; set; }
        public string? DireccionGerente { get; set; }
        public string? TelefonoGerente { get; set; }
        public string TipoCliente { get; set; } = null!;
        public short? DiasDeGracia { get; set; }
        public string BloqueoPorNit { get; set; } = null!;
        public string? Segmento { get; set; }
        public string? UsoLibre { get; set; }
        public string? CodigoUbicacionGeografica { get; set; }
        public string? FormatoDeFactura { get; set; }
        public string? FormatoDePedido { get; set; }
        public string? FormatoDeRemision { get; set; }
        public string? FormatoDeFacturaRemision { get; set; }
        public string? DivisionPolitica { get; set; }
        public string? CodigoCiudad { get; set; }
        public string? CodigoAlterno { get; set; }
        public byte? GeneracionNumeroComprobanteFiscal { get; set; }
        public string? GrupoEmpresarial { get; set; }
        public string? CodigoPais { get; set; }
        public string? Tipo { get; set; }
        public string? CentroCosto { get; set; }
        public string? Item { get; set; }
        public string GenerarMora { get; set; } = null!;
        public decimal PorcentajeMora { get; set; }
        public string Deshabilitado { get; set; } = null!;
        public string PagoContado { get; set; } = null!;
        public string PagoCredito { get; set; } = null!;
    }
}
