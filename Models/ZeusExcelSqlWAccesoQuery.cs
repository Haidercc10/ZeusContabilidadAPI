using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSqlWAccesoQuery
    {
        public int Id { get; set; }
        public int? SqlWQueryId { get; set; }
        public string? PerfilNombre { get; set; }
        public string? UsuariosUsuario { get; set; }
        public bool Consultar { get; set; }
        public bool Modificar { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }
        public bool? OtorgarPermiso { get; set; }
        public bool? Eliminar { get; set; }

        public virtual ZeusExcelSqlWQuery? SqlWQuery { get; set; }
    }
}
