using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoAvVilla
    {
        public string CodTercero { get; set; } = null!;
        public string TipoProducto { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string CodPlaza { get; set; } = null!;
        public int IdenGerbancoavvillas { get; set; }

        public virtual GerBancoAvVillasPlaza CodPlazaNavigation { get; set; } = null!;
        public virtual Tercero CodTerceroNavigation { get; set; } = null!;
    }
}
