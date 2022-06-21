using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VariableBuscadorGenerico
    {
        public VariableBuscadorGenerico()
        {
            VariableBuscadorGenericoDatos = new HashSet<VariableBuscadorGenericoDato>();
        }

        public decimal Iden { get; set; }
        public decimal Codigo { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Opcional0 { get; set; }
        public string? Opcional1 { get; set; }
        public string? Opcional2 { get; set; }
        public string? Opcional3 { get; set; }
        public string? Opcional4 { get; set; }
        public string? Opcional5 { get; set; }
        public string? Opcional6 { get; set; }
        public string? Opcional7 { get; set; }
        public string? Opcional8 { get; set; }
        public string? Opcional9 { get; set; }

        public virtual ICollection<VariableBuscadorGenericoDato> VariableBuscadorGenericoDatos { get; set; }
    }
}
