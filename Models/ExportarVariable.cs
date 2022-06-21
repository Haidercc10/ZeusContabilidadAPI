using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ExportarVariable
    {
        public decimal IdVariable { get; set; }
        public string? Descripcion { get; set; }
        public string? Formulacion { get; set; }
        public int IdenExportarVariables { get; set; }
    }
}
