using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class HistoriaAutorizacionCliente
    {
        public decimal Iden { get; set; }
        public string Idcliente { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public decimal ExtraCupo { get; set; }
        public string Factura { get; set; } = null!;
        public bool Actualizado { get; set; }
        public string TipoAut { get; set; } = null!;
        public string? Auxiliar { get; set; }
        public string? Cuenta { get; set; }

        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
