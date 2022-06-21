using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableTipoTransaccion
    {
        public VariableTipoTransaccion()
        {
            VariableDefinicionMaestros = new HashSet<VariableDefinicionMaestro>();
        }

        public int Iden { get; set; }
        public string Nombre { get; set; } = null!;
        public int MostrarColCod { get; set; }
        public int? Tamano { get; set; }
        public string? SentenciaSql { get; set; }
        public string? GrupoFormulacion { get; set; }
        public int IdenVariabletipotransaccion { get; set; }

        public virtual ICollection<VariableDefinicionMaestro> VariableDefinicionMaestros { get; set; }
    }
}
