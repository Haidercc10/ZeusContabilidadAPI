using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScCriteriosDeCobro
    {
        public ScCriteriosDeCobro()
        {
            ScProgramacionClienteCrts = new HashSet<ScProgramacionClienteCrt>();
            ScProgramacionFactCriterios = new HashSet<ScProgramacionFactCriterio>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Alias { get; set; }
        public int ExigeFecha { get; set; }
        public int? ExigeValor { get; set; }
        public int Deshabilitado { get; set; }
        public int DelUsuario { get; set; }
        public int UsarEnProgramaciones { get; set; }
        public int UsarEnPromesaPago { get; set; }

        public virtual ICollection<ScProgramacionClienteCrt> ScProgramacionClienteCrts { get; set; }
        public virtual ICollection<ScProgramacionFactCriterio> ScProgramacionFactCriterios { get; set; }
    }
}
