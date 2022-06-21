using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ConsultaMovimiento
    {
        public string Nombre { get; set; } = null!;
        public string FiltrarFecha { get; set; } = null!;
        public DateTime? FechaI { get; set; }
        public DateTime? FechaF { get; set; }
        public string FiltrarCuenta { get; set; } = null!;
        public string? CuentaI { get; set; }
        public string? CuentaF { get; set; }
        public string FiltrarFuente { get; set; } = null!;
        public string? FuenteI { get; set; }
        public string? FuenteF { get; set; }
        public string FiltrarDocumento { get; set; } = null!;
        public string? DocumentoI { get; set; }
        public string? DocumentoF { get; set; }
        public string FiltrarTercero { get; set; } = null!;
        public string? TerceroI { get; set; }
        public string? TerceroF { get; set; }
        public string FiltrarProveedor { get; set; } = null!;
        public string? ProveedorI { get; set; }
        public string? ProveedorF { get; set; }
        public string FiltrarCliente { get; set; } = null!;
        public string? ClienteI { get; set; }
        public string? ClienteF { get; set; }
        public string FiltrarVendedor { get; set; } = null!;
        public string? VendedorI { get; set; }
        public string? VendedorF { get; set; }
        public string FiltrarAuxiliar { get; set; } = null!;
        public string? AuxiliarI { get; set; }
        public string? AuxiliarF { get; set; }
        public string FiltrarCentroCosto { get; set; } = null!;
        public string? CentroCostoI { get; set; }
        public string? CentroCostoF { get; set; }
        public string FiltrarTipoFactura { get; set; } = null!;
        public string? TipoFacturaI { get; set; }
        public string? TipoFacturaF { get; set; }
        public string FiltrarFactura { get; set; } = null!;
        public string? FacturaI { get; set; }
        public string? FacturaF { get; set; }
        public string FiltrarDc { get; set; } = null!;
        public string? TipoDc { get; set; }
        public string FiltrarBanco { get; set; } = null!;
        public string? BancoI { get; set; }
        public string? BancoF { get; set; }
        public string FiltrarZona { get; set; } = null!;
        public string? ZonaI { get; set; }
        public string? ZonaF { get; set; }
        public string FiltrarPlaza { get; set; } = null!;
        public string? PlazaI { get; set; }
        public string? PlazaF { get; set; }
        public string FiltrarItem { get; set; } = null!;
        public string? ItemI { get; set; }
        public string? ItemF { get; set; }
        public string FiltrarValorTra { get; set; } = null!;
        public string CondicionValorTra { get; set; } = null!;
        public decimal ValorTraI { get; set; }
        public decimal ValorTraF { get; set; }
        public string FiltrarRubroPresupuesto { get; set; } = null!;
        public string? RubroPresupuestoI { get; set; }
        public string? RubroPresupuestoF { get; set; }
        public string FiltrarReservaPre { get; set; } = null!;
        public string? ReservaI { get; set; }
        public string? ReservaF { get; set; }
        public string FiltrarUsuario { get; set; } = null!;
        public string? UsuarioI { get; set; }
        public string? UsuarioF { get; set; }
        public string FiltrarDocDescuadrados { get; set; } = null!;
        public string FiltrarPorTopRegistros { get; set; } = null!;
        public int TopRegistro { get; set; }
        public string Orden1 { get; set; } = null!;
        public string Orden2 { get; set; } = null!;
        public string Orden3 { get; set; } = null!;
        public string Orden4 { get; set; } = null!;
        public string Orden5 { get; set; } = null!;
        public string FiltrarCodigoOcupacion { get; set; } = null!;
        public string? CodigoOcupacionI { get; set; }
        public string? CodigoOcupacionF { get; set; }
        public string Bu { get; set; } = null!;
        public string FiltrarPropiedad1 { get; set; } = null!;
        public string Propiedad1I { get; set; } = null!;
        public string Propiedad1F { get; set; } = null!;
        public string FiltrarPropiedad2 { get; set; } = null!;
        public string Propiedad2I { get; set; } = null!;
        public string Propiedad2F { get; set; } = null!;
        public string FiltrarPropiedad3 { get; set; } = null!;
        public string Propiedad3I { get; set; } = null!;
        public string Propiedad3F { get; set; } = null!;
        public string FiltrarPropiedad4 { get; set; } = null!;
        public string Propiedad4I { get; set; } = null!;
        public string Propiedad4F { get; set; } = null!;
        public string FiltrarPropiedad5 { get; set; } = null!;
        public string Propiedad5I { get; set; } = null!;
        public string Propiedad5F { get; set; } = null!;
        public int IdenConsultamovimientos { get; set; }
        public string Ncf { get; set; } = null!;
        public string Adicional1 { get; set; } = null!;
        public string Adicional2 { get; set; } = null!;
    }
}
