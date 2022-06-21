using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ControlDocumentarioRecepcionDocumentoFactura
    {
        public decimal? ConsecutivoRecepcion { get; set; }
        public decimal Iden { get; set; }
        public string? Bu { get; set; }
        public string? Codicta { get; set; }
        public string? IdCliPrv { get; set; }
        public string? Tipofac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public decimal? Estado { get; set; }
        public string? FlujoCaja { get; set; }
        public decimal? ValorOrden { get; set; }
        public decimal? ValorCompra { get; set; }
        public int? IdAplicacionesZeus { get; set; }
        public bool? Revertido { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public string? Ubicacion { get; set; }
        public bool? Enviado { get; set; }

        public virtual ControlDocumentarioRecepcionDocumento? ConsecutivoRecepcionNavigation { get; set; }
    }
}
