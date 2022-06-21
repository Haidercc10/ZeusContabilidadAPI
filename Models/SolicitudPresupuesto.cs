using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class SolicitudPresupuesto
    {
        public int Iden { get; set; }
        public decimal? Consecutivo { get; set; }
        public DateTime Fecha { get; set; }
        public string Ano { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string? DocumentoExterno { get; set; }
        public string? Descripcion { get; set; }
        public string Estado { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? UsuarioAutoriza { get; set; }
        public int? Categoria { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Usuario1? UsuarioAutorizaNavigation { get; set; }
        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
