using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosCodMovimiento
    {
        public long Iden { get; set; }
        public decimal IdenExtractoDefinicion { get; set; }
        public string CodigoMovimiento { get; set; } = null!;
        public string DescMovimiento { get; set; } = null!;
        public int DescAusar { get; set; }
        public string? CtaCodMov { get; set; }
        public string? IdCenco { get; set; }
        public string? IdAuxiliar { get; set; }
        public string? IdTercero { get; set; }
        public int Naturaleza { get; set; }
        public int? TipoMovimiento { get; set; }
        public decimal? ImpExtractosCodMovimientosTipoConciliacionIden { get; set; }

        public virtual Maecont? CtaCodMovNavigation { get; set; }
        public virtual Maecco? IdCencoNavigation { get; set; }
        public virtual Tercero? IdTerceroNavigation { get; set; }
        public virtual ImpExtractosDefinicion IdenExtractoDefinicionNavigation { get; set; } = null!;
        public virtual ImpExtractosCodMovimientosTipoConciliacion? ImpExtractosCodMovimientosTipoConciliacionIdenNavigation { get; set; }
    }
}
