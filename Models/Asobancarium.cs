using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Asobancarium
    {
        public decimal Iden { get; set; }
        public decimal? Consecutivo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Usuario { get; set; }
        public decimal? IdenAsobancariaTipos { get; set; }
        public string? Fecha { get; set; }
        public string? Idfuente { get; set; }
        public string? Numdoctra { get; set; }
        public string? Codicta { get; set; }
        public string? Idmoneda { get; set; }
        public string? Bu { get; set; }
        public string? BuUsuario { get; set; }
        public string? IdItem { get; set; }
        public string? GeneraDocumentoPor { get; set; }
        public string? ContraPartidaPorTercero { get; set; }
    }
}
