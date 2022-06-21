using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturacionAutomaticaDetalle
    {
        public decimal Iden { get; set; }
        public decimal IdFacturacionAutomatica { get; set; }
        public string Idtipodoc { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Estado { get; set; } = null!;

        public virtual FacturacionAutomatica IdFacturacionAutomaticaNavigation { get; set; } = null!;
    }
}
