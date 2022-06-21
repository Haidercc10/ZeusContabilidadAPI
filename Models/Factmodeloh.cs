using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factmodeloh
    {
        public Factmodeloh()
        {
            Factmodelobs = new HashSet<Factmodelob>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public int DocAgenerar { get; set; }
        public string Referencia { get; set; } = null!;
        public int? GenerarNcuotas { get; set; }
        public int? NumeroCuotas { get; set; }
        public int? TipoVencimiento { get; set; }
        public int? DiasVencimiento { get; set; }
        public int? DiaFechaVencimientoFijo { get; set; }
        public int? DiaFechaVencimientoProg { get; set; }
        public string? DiaFechaVencimientoProgNom { get; set; }
        public string? VencimientoDiaHabil { get; set; }
        public int? UsarEnZeusOnLine { get; set; }
        public int IdenFactmodeloh { get; set; }
        public string TipoOperacion { get; set; } = null!;

        public virtual ICollection<Factmodelob> Factmodelobs { get; set; }
    }
}
