using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosTipoMvtoConciliacion
    {
        public ImpExtractosTipoMvtoConciliacion()
        {
            ImpExtractosCodMovimientosTipoConciliacions = new HashSet<ImpExtractosCodMovimientosTipoConciliacion>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int IdenImpextractostipomvtoconciliacion { get; set; }

        public virtual ICollection<ImpExtractosCodMovimientosTipoConciliacion> ImpExtractosCodMovimientosTipoConciliacions { get; set; }
    }
}
