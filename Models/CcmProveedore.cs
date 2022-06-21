using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmProveedore
    {
        public string CodigoProveedor { get; set; } = null!;
        public string CodigoTercero { get; set; } = null!;
        public string NombreTercero { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Zona { get; set; }
        public short? DiasDePlazo { get; set; }
        public decimal? CupoDeCredito { get; set; }
        public string Cuenta { get; set; } = null!;
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
        public string? DireccionCorrespondencia { get; set; }
        public string? Segmento { get; set; }
        public string? CodigoUbicacionGeografica { get; set; }
        public string? DivisionPolitica { get; set; }
        public string? CodigoCiudad { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public string CodigoAlterno { get; set; } = null!;
        public string EnviarEmailAlRealizarPago { get; set; } = null!;
        public string UsoLibre { get; set; } = null!;
        public string? PrefijoNcf { get; set; }
        public string? GrupoEmpresarial { get; set; }
        public string? CentroCosto { get; set; }
        public string? CodigoPais { get; set; }
        public string? Tipo { get; set; }
        public string? Item { get; set; }
        public string Deshabilitado { get; set; } = null!;
        public string CodigoClaseProveedor { get; set; } = null!;
    }
}
