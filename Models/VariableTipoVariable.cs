using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableTipoVariable
    {
        public VariableTipoVariable()
        {
            VariableDefinicions = new HashSet<VariableDefinicion>();
        }

        public int Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public int MostrarColCod { get; set; }
        public int Tanano { get; set; }
        public string? SentenciaSql { get; set; }
        public string? Tabla { get; set; }
        public string? CampoLlave { get; set; }
        public string? CampoConsecutivo { get; set; }
        public int IdenVariabletipovariable { get; set; }

        public virtual ICollection<VariableDefinicion> VariableDefinicions { get; set; }
    }
}
