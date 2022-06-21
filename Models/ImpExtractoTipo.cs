using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractoTipo
    {
        public ImpExtractoTipo()
        {
            ImpExtractosDefinicions = new HashSet<ImpExtractosDefinicion>();
        }

        public long Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Sp { get; set; } = null!;
        public bool TipoDelSistema { get; set; }
        public string? ConcilMoneda { get; set; }

        public virtual ICollection<ImpExtractosDefinicion> ImpExtractosDefinicions { get; set; }
    }
}
