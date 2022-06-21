using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CfAreaImpresion
    {
        public CfAreaImpresion()
        {
            CfAutorizacions = new HashSet<CfAutorizacion>();
        }

        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Direccion { get; set; }
        public bool EsSucursal { get; set; }
        public string? RutFirmante { get; set; }
        public string? Ccfirmante { get; set; }
        public decimal? ImpuestoIsd { get; set; }

        public virtual ICollection<CfAutorizacion> CfAutorizacions { get; set; }
    }
}
