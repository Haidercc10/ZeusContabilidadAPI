using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScProgramacion
    {
        public ScProgramacion()
        {
            InverseIdenReprogramacionNavigation = new HashSet<ScProgramacion>();
            ScProgramacionClientes = new HashSet<ScProgramacionCliente>();
            ScProgramacionFacturas = new HashSet<ScProgramacionFactura>();
        }

        public decimal Iden { get; set; }
        public decimal Consecutivo { get; set; }
        public int TipoProgramacion { get; set; }
        public string Estado { get; set; } = null!;
        public decimal? IdenCobrador { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime FechaProgramacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int FCliente { get; set; }
        public string? ClienteI { get; set; }
        public string? ClienteF { get; set; }
        public int FCuenta { get; set; }
        public string? CuentaI { get; set; }
        public string? CuentaF { get; set; }
        public int FTipoFact { get; set; }
        public string? TipoFactI { get; set; }
        public string? TipoFactF { get; set; }
        public int FNumeFac { get; set; }
        public string? NumeFactI { get; set; }
        public string? NumeFactF { get; set; }
        public int FVenceFact { get; set; }
        public int? VenceFactI { get; set; }
        public int? VenceFactF { get; set; }
        public int FRefeFact { get; set; }
        public string? RefeFactI { get; set; }
        public string? RefeFactF { get; set; }
        public int FVendedor { get; set; }
        public string? VendedorI { get; set; }
        public string? VendedorF { get; set; }
        public int FZona { get; set; }
        public string? ZonaI { get; set; }
        public string? ZonaF { get; set; }
        public int FValorDeuda { get; set; }
        public string OpValorDeuda { get; set; } = null!;
        public decimal? ValorDeudaI { get; set; }
        public decimal? ValorDeudaF { get; set; }
        public decimal? IdenReprogramacion { get; set; }
        public decimal TotalProgramado { get; set; }
        public decimal TotalProcesado { get; set; }
        public decimal? TotalRecaudoPrg { get; set; }
        public decimal? TotalRecaudoReal { get; set; }
        public int FCuentaEspecificas { get; set; }
        public string Bu { get; set; } = null!;
        public string? Usuario { get; set; }
        public bool FTipoCliente { get; set; }
        public string TipoClienteI { get; set; } = null!;
        public string TipoClienteF { get; set; } = null!;
        public bool FSegmento { get; set; }
        public string SegmentoI { get; set; } = null!;
        public string SegmentoF { get; set; } = null!;
        public bool FGrupoEmpresarial { get; set; }
        public string GrupoEmpresarialI { get; set; } = null!;
        public string GrupoEmpresarialF { get; set; } = null!;
        public bool FTotalFactura { get; set; }
        public int? FTercero { get; set; }
        public string? TerceroI { get; set; }
        public string? TerceroF { get; set; }

        public virtual ScCobrador? IdenCobradorNavigation { get; set; }
        public virtual ScProgramacion? IdenReprogramacionNavigation { get; set; }
        public virtual ICollection<ScProgramacion> InverseIdenReprogramacionNavigation { get; set; }
        public virtual ICollection<ScProgramacionCliente> ScProgramacionClientes { get; set; }
        public virtual ICollection<ScProgramacionFactura> ScProgramacionFacturas { get; set; }
    }
}
