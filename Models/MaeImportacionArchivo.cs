using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MaeImportacionArchivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public bool? ValidaExistencia { get; set; }
    }
}
