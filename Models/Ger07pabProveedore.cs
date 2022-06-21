using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Ger07pabProveedore
    {
        public string? CodProveedor { get; set; }
        public string Banco { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string LugarPago { get; set; } = null!;
        public string TipoTransaccion { get; set; } = null!;
        public string FechaAplicacion { get; set; } = null!;
        public int CantidadA { get; set; }
        public string MedidaA { get; set; } = null!;
        public string TipoDocumento { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string NidentificacionA { get; set; } = null!;
        public string? CodigoTercero { get; set; }
        public string? TipoMatricula { get; set; }
        public string CodigoMatricula { get; set; } = null!;
        public int Principal { get; set; }
        public int IdenGer07pabproveedores { get; set; }

        public virtual Proveedore? CodProveedorNavigation { get; set; }
        public virtual Tercero? CodigoTerceroNavigation { get; set; }
    }
}
