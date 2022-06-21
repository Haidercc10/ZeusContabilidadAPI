using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfEstfinanciero
    {
        public int IdEstfinanciero { get; set; }
        public int IdPadre { get; set; }
        public decimal Transporte { get; set; }
        public decimal Salud { get; set; }
        public decimal Educacion { get; set; }
        public decimal Vivienda { get; set; }
        public decimal Alimentacion { get; set; }
        public decimal Servicios { get; set; }
        public decimal Otros { get; set; }
        public decimal TotalEgresos { get; set; }
        public string Estvivienda { get; set; } = null!;
        public string Estparedes { get; set; } = null!;
        public string Estpisos { get; set; } = null!;
        public string Esttechos { get; set; } = null!;
        public string Estservicios { get; set; } = null!;
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
    }
}
