using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class LogTodosMaestro
    {
        public int? SpId { get; set; }
        public string? Maestro { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Operacion { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int IdenLogtodosmaestros { get; set; }
    }
}
