using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GestionAssembly
    {
        public decimal IdAssemblie { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Procedimiento { get; set; } = null!;
        public int IdenGestionassemblies { get; set; }
    }
}
