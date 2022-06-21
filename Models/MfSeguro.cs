using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfSeguro
    {
        public MfSeguro()
        {
            MfPolizas = new HashSet<MfPoliza>();
        }

        public int IdSeguro { get; set; }
        public string CodSeguro { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MfPoliza> MfPolizas { get; set; }
    }
}
