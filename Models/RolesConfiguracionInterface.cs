using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RolesConfiguracionInterface
    {
        public string Formulario { get; set; } = null!;
        public string Control { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string ParametroEntrada { get; set; } = null!;
        public int IdenRolesconfiguracioninterfaces { get; set; }
    }
}
