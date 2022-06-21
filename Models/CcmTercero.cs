using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmTercero
    {
        public string CodigoTercero { get; set; } = null!;
        public string NombreTercero { get; set; } = null!;
        public string? DigitoVerificacion { get; set; }
        public string? TipoTercero { get; set; }
        public string? Segmento { get; set; }
        public string Tipoempresa { get; set; } = null!;
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? DivisionPolitica { get; set; }
        public string? CodigoCiudad { get; set; }
        public string? Telefono { get; set; }
        public string? TipoIdentificacion { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public string? TipoRazonSocial { get; set; }
        public string? PrefijoNcf { get; set; }
        public string? Sexo { get; set; }
        public string? Profesion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Hobbies { get; set; }
        public string? NombreConyugue { get; set; }
        public DateTime? FechaNacimientoConyugue { get; set; }
        public string? TipoClienteFrecuenciaCompra { get; set; }
        public string? EstratoSocial { get; set; }
        public string? Barrio { get; set; }
        public string? Telefono2 { get; set; }
        public string? Celular { get; set; }
        public string? CodigoPais { get; set; }
        public string? Tipo { get; set; }
        public string? CentroCosto { get; set; }
        public string? Item { get; set; }
        public string Deshabilitado { get; set; } = null!;
        public string CodigoOcupacion { get; set; } = null!;
        public string? Email { get; set; }
        public string ManejaAcuerdo { get; set; } = null!;
        public DateTime? FechaInicialAcuerdo { get; set; }
        public DateTime? FechaFinalAcuerdo { get; set; }
    }
}
