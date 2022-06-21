using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfPuntoEmision
    {
        public CfPuntoEmision()
        {
            CfAutorizacions = new HashSet<CfAutorizacion>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? NombreMaquina { get; set; }
        public string? IdMaquina { get; set; }

        public virtual ICollection<CfAutorizacion> CfAutorizacions { get; set; }
    }
}
