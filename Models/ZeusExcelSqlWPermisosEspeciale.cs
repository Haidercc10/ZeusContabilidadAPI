using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelSqlWPermisosEspeciale
    {
        public int Id { get; set; }
        public string? PerfilNombre { get; set; }
        public string? UsuariosUsuario { get; set; }
        public bool Crear { get; set; }
        public bool Consultar { get; set; }
        public bool OtorgarPermiso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? UsuarioModifico { get; set; }
    }
}
