using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfTipoComprobante
    {
        public CfTipoComprobante()
        {
            CfAutorizacions = new HashSet<CfAutorizacion>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<CfAutorizacion> CfAutorizacions { get; set; }
    }
}
