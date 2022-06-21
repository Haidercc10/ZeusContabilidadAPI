using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ValerasPrefijo
    {
        public ValerasPrefijo()
        {
            Valeras = new HashSet<Valera>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string IndPrefijo { get; set; } = null!;
        public string Auxiliar { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string CxP { get; set; } = null!;
        public int Tvigencia { get; set; }
        public int IdenValerasPrefijos { get; set; }

        public virtual ICollection<Valera> Valeras { get; set; }
    }
}
