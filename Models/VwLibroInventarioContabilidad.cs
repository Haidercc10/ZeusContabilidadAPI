using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwLibroInventarioContabilidad
    {
        public DateTime? Fecha { get; set; }
        public string? Fuente { get; set; }
        public string? Documento { get; set; }
        public decimal? Tipodocumento { get; set; }
        public decimal? Consecutivo { get; set; }
        public string? Codigobodega { get; set; }
        public string? Codicta { get; set; }
        public string? Nombretipodocumento { get; set; }
        public string? Codigoarticulo { get; set; }
        public string? Nombrearticulo { get; set; }
        public string? Presentacion { get; set; }
        public string? Grupo { get; set; }
        public string? Nombregrupo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Valor { get; set; }
        public string? Bu { get; set; }
    }
}
