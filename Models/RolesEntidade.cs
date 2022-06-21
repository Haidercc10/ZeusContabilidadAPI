using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesEntidade
    {
        public string Codigo { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Tabla { get; set; }
        public bool LlaveCompuesta { get; set; }
        public string? ColumnaIdentificador1 { get; set; }
        public string? ColumnaIdentificador2 { get; set; }
        public string? ParametroParaIdentificador1 { get; set; }
        public string? ParametroParaIdentificador2 { get; set; }
        public string? SeccionF4 { get; set; }
        public string? TipoDatoIdentificador1 { get; set; }
        public string? TipoDatoIdentificador2 { get; set; }
        public string? CampoDescripcion { get; set; }
        public int IdenRolesentidades { get; set; }
        public string? BuscadorWeb { get; set; }
    }
}
