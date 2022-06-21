using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerCreditoPeru
    {
        public string CodTercero { get; set; } = null!;
        public string TipoProducto { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public string Digito { get; set; } = null!;
        public string Indicador { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public int IdenGercreditoperu { get; set; }
        public string? IdBanco { get; set; }

        public virtual Banco? IdBancoNavigation { get; set; }
    }
}
