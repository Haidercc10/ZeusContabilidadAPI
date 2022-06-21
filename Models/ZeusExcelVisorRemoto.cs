using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelVisorRemoto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Usuario { get; set; }
        public string? Estado { get; set; }
        public string? XmlPeticion { get; set; }
        public string? Observacion { get; set; }
        public string? Tipo { get; set; }
        public string? Ruta { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifica { get; set; }
        public int? Registros { get; set; }
        public int? ProcessId { get; set; }
    }
}
