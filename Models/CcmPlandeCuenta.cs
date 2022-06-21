using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CcmPlandeCuenta
    {
        public string Cuenta { get; set; } = null!;
        public string DescripcionCuenta { get; set; } = null!;
        public byte NivelCuenta { get; set; }
        public string? TipoCuenta { get; set; }
        public string CuentaPadre { get; set; } = null!;
        public string? CategoriaFinanciera { get; set; }
        public string IndicadorPagosAterceros { get; set; } = null!;
        public string? Atributos { get; set; }
        public string? Banco { get; set; }
        public string ExigeCentroCosto { get; set; } = null!;
        public string? CuentaDeCierre { get; set; }
        public string? Unidad1 { get; set; }
        public string? Unidad2 { get; set; }
        public string? Unidad3 { get; set; }
        public string? CalculoTransaccion { get; set; }
        public string? FormulaCalcularTransaccion { get; set; }
        public string? Moneda { get; set; }
        public string? CuentaAjusteGanancia { get; set; }
        public decimal? PorcentajeImpuesto { get; set; }
        public string? DatosImpuestos { get; set; }
        public string? CuentaCorriente { get; set; }
        public string? Identificador { get; set; }
        public string CierreCuentaTercero { get; set; } = null!;
        public string? CuentaHabilitada { get; set; }
        public string? NaturalezaCuenta { get; set; }
        public string? GrupoDeCuenta { get; set; }
        public string? TasaCambio { get; set; }
        public string? CuentaAjustePerdida { get; set; }
        public string? ExigeItem { get; set; }
        public string? Categoria { get; set; }
        public string ModuloExterno { get; set; } = null!;
        public string ValidaSaldoSegunNaturaleza { get; set; } = null!;
        public string ValidaSaldoTercero { get; set; } = null!;
        public string GeneraDiferido { get; set; } = null!;
        public string CuentaPagosAterceros { get; set; } = null!;
        public string ValorRetenido { get; set; } = null!;
        public string? Seccion { get; set; }
        public string ManejaReservadaZeus { get; set; } = null!;
        public string ManejaUge { get; set; } = null!;
        public string ManejaPropiedad3 { get; set; } = null!;
        public string ManejaPropiedad4 { get; set; } = null!;
        public string ManejaPropiedad5 { get; set; } = null!;
        public string NoManejaAjusteAutomatico { get; set; } = null!;
        public string? CuentaInteresesCorrientes { get; set; }
        public string? CodigoTipoImpuestos { get; set; }
        public string? CuentaDeterioro { get; set; }
        public string? CuentaPpptransitoria { get; set; }
        public string? TipoCuentaBancaria { get; set; }
    }
}
