using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfPresupuesto
    {
        public int IdPresup { get; set; }
        public int IdPadre { get; set; }
        public string Periodo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Costounid { get; set; }
        public decimal Costototal { get; set; }
        public decimal Preciounid { get; set; }
        public decimal Preciototal { get; set; }
        public decimal Utilidad { get; set; }
        public decimal Porcmargen { get; set; }
        public string TipoEstudio { get; set; } = null!;

        public virtual MfTablapadre MfTablapadre { get; set; } = null!;
        public virtual Maeunid UnidadNavigation { get; set; } = null!;
    }
}
