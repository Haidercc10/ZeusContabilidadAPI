using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Reclasificacion3ro
    {
        public decimal Id { get; set; }
        public string Folio { get; set; } = null!;
        public string TipoFolio { get; set; } = null!;
        public string TerceroActual { get; set; } = null!;
        public string TerceroNuevo { get; set; } = null!;
        public string FechaInicial { get; set; } = null!;
        public string FechaFinal { get; set; } = null!;
        public string FuenteInicial { get; set; } = null!;
        public string FuenteFinal { get; set; } = null!;
        public string DctoInicial { get; set; } = null!;
        public string DctoFinal { get; set; } = null!;
        public string CuentaInicial { get; set; } = null!;
        public string CuentaFinal { get; set; } = null!;
        public bool Procesado { get; set; }

        public virtual Tercero TerceroNuevoNavigation { get; set; } = null!;
    }
}
