using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmUsuario
    {
        public string Usuario { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Cedula { get; set; }
        public string? Grupo { get; set; }
        public string? Perfil { get; set; }
        public string? Impresora { get; set; }
        public string Email { get; set; } = null!;
        public string Usolibre { get; set; } = null!;
        public string Serie { get; set; } = null!;
        public string Rol { get; set; } = null!;
        public string AnularDcto { get; set; } = null!;
        public string ModificarMora { get; set; } = null!;
        public decimal PorcentajeMora { get; set; }
        public string? Autenticacion { get; set; }
        public string? CodigoIdioma { get; set; }
        public string Consolidado { get; set; } = null!;
        public string UnidadDeNegocio { get; set; } = null!;
        public string TipoUsuarioBu { get; set; } = null!;
        public string ContabilizaPreparacionDocumento { get; set; } = null!;
        public string Login { get; set; } = null!;
        public string ModificarDiasVencimiento { get; set; } = null!;
    }
}
