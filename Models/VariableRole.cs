using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableRole
    {
        public VariableRole()
        {
            VariableRollOperacions = new HashSet<VariableRollOperacion>();
            VariableUsuarioAccesos = new HashSet<VariableUsuarioAcceso>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Deshabilitado { get; set; }

        public virtual ICollection<VariableRollOperacion> VariableRollOperacions { get; set; }
        public virtual ICollection<VariableUsuarioAcceso> VariableUsuarioAccesos { get; set; }
    }
}
