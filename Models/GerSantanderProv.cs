using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerSantanderProv
    {
        public string? Idprove { get; set; }
        public string? Identificacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string CodigoIdentificacion { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string CodigoBancoDestino { get; set; } = null!;
        public string Validar { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGersantanderProv { get; set; }

        public virtual Tercero? CodigoTerceroNavigation { get; set; }
        public virtual Proveedore? IdproveNavigation { get; set; }
    }
}
