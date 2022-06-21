using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturaElectronicaExtensionesDinamica
    {
        public FacturaElectronicaExtensionesDinamica()
        {
            FacturaElectronicaExtensionesDinamicasRelaciones = new HashSet<FacturaElectronicaExtensionesDinamicasRelacione>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Nodo { get; set; } = null!;
        public string Tipo1 { get; set; } = null!;
        public string Tipo2 { get; set; } = null!;
        public string Tipo3 { get; set; } = null!;
        public string Tipo4 { get; set; } = null!;
        public string Tipo5 { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string Query { get; set; } = null!;
        public string CampoSelect { get; set; } = null!;
        public string Funcion { get; set; } = null!;
        public string Sql { get; set; } = null!;

        public virtual ICollection<FacturaElectronicaExtensionesDinamicasRelacione> FacturaElectronicaExtensionesDinamicasRelaciones { get; set; }
    }
}
