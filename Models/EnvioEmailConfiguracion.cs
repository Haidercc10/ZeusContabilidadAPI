using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EnvioEmailConfiguracion
    {
        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string Plantilla { get; set; } = null!;
        public int IndCliente { get; set; }
        public string ClienteI { get; set; } = null!;
        public string ClienteF { get; set; } = null!;
        public int IndTercero { get; set; }
        public string TerceroI { get; set; } = null!;
        public string TerceroF { get; set; } = null!;
        public int IndCuenta { get; set; }
        public string CuentaI { get; set; } = null!;
        public string CuentaF { get; set; } = null!;
        public int IndSegmento { get; set; }
        public string SegmentoI { get; set; } = null!;
        public string SegmentoF { get; set; } = null!;
        public int IndDivPolitica { get; set; }
        public string DivPoliticaI { get; set; } = null!;
        public string DivPoliticaF { get; set; } = null!;
        public int IndPais { get; set; }
        public string PaisI { get; set; } = null!;
        public string PaisF { get; set; } = null!;
        public int IndUbiGeografica { get; set; }
        public string UbiGeograficaI { get; set; } = null!;
        public string UbiGeograficaF { get; set; } = null!;
        public int IndGrEmpresarial { get; set; }
        public string GrEmpresarialI { get; set; } = null!;
        public string GrEmpresarialF { get; set; } = null!;
        public string IndZona { get; set; } = null!;
        public string ZonaI { get; set; } = null!;
        public string ZonaF { get; set; } = null!;
        public string IndVendedor { get; set; } = null!;
        public string VendedorI { get; set; } = null!;
        public string VendedorF { get; set; } = null!;
        public string FechaAnalisis { get; set; } = null!;
        public string IndDiasVenc { get; set; } = null!;
        public decimal DiasVencI { get; set; }
        public decimal DiasVencF { get; set; }
        public string IndVencimiento { get; set; } = null!;
        public string VencimientoI { get; set; } = null!;
        public string VencimientoF { get; set; } = null!;
        public string IndVrMonLocal { get; set; } = null!;
        public decimal VrMonLocalI { get; set; }
        public decimal VrMonLocalF { get; set; }
        public string IndVrMonExtranjera { get; set; } = null!;
        public decimal VrMonExtranjeraI { get; set; }
        public decimal VrMonExtranjeraF { get; set; }
        public int IndTipoFactura { get; set; }
        public string TipoFacturaI { get; set; } = null!;
        public string TipoFacturaF { get; set; } = null!;
        public int IndTipoCliente { get; set; }
        public string TipoClienteI { get; set; } = null!;
        public string TipoClienteF { get; set; } = null!;
        public int IndCodAlterno { get; set; }
        public string CodAlternoI { get; set; } = null!;
        public string CodAlternoF { get; set; } = null!;
        public int TodosLosClientes { get; set; }
        public int IndMostrarDetale { get; set; }
        public int ConsCodAlterno { get; set; }
        public decimal? TipoEmail { get; set; }
        public string? Orden1 { get; set; }
        public string? Orden2 { get; set; }
        public string? Orden3 { get; set; }
        public string? Orden4 { get; set; }
        public string? Orden5 { get; set; }
    }
}
