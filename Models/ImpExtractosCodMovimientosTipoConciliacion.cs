using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosCodMovimientosTipoConciliacion
    {
        public ImpExtractosCodMovimientosTipoConciliacion()
        {
            ImpExtractosCodMovimientos = new HashSet<ImpExtractosCodMovimiento>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal ImpExtractosTipoMvtoConciliacionIden { get; set; }
        public int? TipoNoDocumento { get; set; }
        public decimal? NoCaracteres { get; set; }
        public decimal? NoDesde { get; set; }
        public decimal? NoHasta { get; set; }

        public virtual ImpExtractosTipoMvtoConciliacion ImpExtractosTipoMvtoConciliacionIdenNavigation { get; set; } = null!;
        public virtual ICollection<ImpExtractosCodMovimiento> ImpExtractosCodMovimientos { get; set; }
    }
}
