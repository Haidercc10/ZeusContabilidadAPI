using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class RptConfigDetalleAtributo
    {
        public string CodigoCombinacion { get; set; } = null!;
        public string Detallar { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Descripcion1 { get; set; } = null!;
        public string Descripcion2 { get; set; } = null!;
        public int IdenRptconfigDetalleatributos { get; set; }

        public virtual Usuario1 UsuarioNavigation { get; set; } = null!;
    }
}
