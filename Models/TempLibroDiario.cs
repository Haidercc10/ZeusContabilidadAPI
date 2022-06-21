using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TempLibroDiario
    {
        public int Id { get; set; }
        public short SpId { get; set; }
        public string? NitCompañia { get; set; }
        public string? NombreCompañia { get; set; }
        public string? Iden3ro { get; set; }
        public string? AnoMesDcto { get; set; }
        public string? FuenteDcto { get; set; }
        public string? DocumentoDcto { get; set; }
        public string? FechaDcto { get; set; }
        public int? NregDcto { get; set; }
        public decimal? Dbdcto { get; set; }
        public decimal? Crdcto { get; set; }
        public string? DescDcto { get; set; }
        public string? CencoDcto { get; set; }
        public string? TerceroDcto { get; set; }
        public string? CliProvDcto { get; set; }
        public string? CtaBancoDcto { get; set; }
        public string? CtaBasicaDcto { get; set; }
        public string? NoChequeDcto { get; set; }
        public string? EntregadoDcto { get; set; }
        public string? TipoDocEntregadoDcto { get; set; }
        public string? NoTipoDocEntregadoDcto { get; set; }
        public DateTime? FechaEntregadoDcto { get; set; }
        public string? AuxiliarDcto { get; set; }
        public string? ItemDcto { get; set; }
        public string? BeneficiarioDcto { get; set; }
        public string? IpriChequeDcto { get; set; }
        public decimal? NrevDcto { get; set; }
        public string? AjusteInfDcto { get; set; }
        public decimal? PaagMdcto { get; set; }
        public decimal? PaagAdcto { get; set; }
        public string? IndContabPrestamoDcto { get; set; }
        public decimal? NumValesDcto { get; set; }
        public decimal? NumValesConcilDcto { get; set; }
        public string? MonedaDcto { get; set; }
        public string? VencChequeDcto { get; set; }
        public decimal? VrChequeLocalDcto { get; set; }
        public decimal? VrChequeMonedaDcto { get; set; }
        public string? MontoLetrasLocalDcto { get; set; }
        public string? MontoLetrasMonedaDcto { get; set; }
        public string? AnomesTra { get; set; }
        public string? FuenteTra { get; set; }
        public string? DocumentoTra { get; set; }
        public int? ConsecutivoTra { get; set; }
        public string? FechaTra { get; set; }
        public string? CuentaTra { get; set; }
        public string? TerceroTra { get; set; }
        public string? AuxiliarTra { get; set; }
        public string? CencoTra { get; set; }
        public string? ItemTra { get; set; }
        public string? DescripcionTra { get; set; }
        public decimal? ValorTra { get; set; }
        public string? IndCuentaTra { get; set; }
        public string? ConcilTra { get; set; }
        public string? IdBancoTra { get; set; }
        public string? VendedorTra { get; set; }
        public string? PlazaTra { get; set; }
        public string? TipoFacTra { get; set; }
        public string? NfacturaTra { get; set; }
        public string? VencimientoTra { get; set; }
        public string? ReferenciaTra { get; set; }
        public string? UsuarioTra { get; set; }
        public string? ZonaTra { get; set; }
        public string? CliPrvTra { get; set; }
        public decimal? PorcentajeTra { get; set; }
        public decimal? BaseTra { get; set; }
        public string? CodPresuTra { get; set; }
        public string? CodReservaTra { get; set; }
        public decimal? ValorMonedaTra { get; set; }
        public string? EstadoTra { get; set; }
        public string? SerieTra { get; set; }
        public string? AutorizacionTra { get; set; }
        public string? FechaFactTra { get; set; }
        public string? Adicional1Tra { get; set; }
        public string? Adicional2Tra { get; set; }
        public string? VoucherTra { get; set; }
        public decimal? TasaTra { get; set; }
        public string? DescFuente { get; set; }
        public string? DescCuenta { get; set; }
        public string? TipoDocFuente { get; set; }
        public string? TerceroCartera { get; set; }
        public decimal? SaldoAnterior { get; set; }
        public decimal? SaldoActual { get; set; }
    }
}
