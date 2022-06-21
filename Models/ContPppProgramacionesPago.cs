using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacionesPago
    {
        public decimal Iden { get; set; }
        public decimal IdenProgramacion { get; set; }
        public string? IdProvTer { get; set; }
        public string? Tipo { get; set; }
        public decimal? IdenConcepto { get; set; }
        public string? Idcenco { get; set; }
        public string? Auxiliar { get; set; }
        public string? Item { get; set; }
        public string? Propiedad1 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? Propiedad5 { get; set; }
        public decimal? ValorProgramado { get; set; }
        public string? Bu { get; set; }
        public bool? Estado { get; set; }
        public bool? Conciliado { get; set; }
        public string? Descripcion { get; set; }
        public string? CodigoMatriculaGerencia { get; set; }
        public decimal? ValorPagoConcepto { get; set; }
        public decimal? ValorPagoConceptoMoneda { get; set; }
        public decimal? ValorPagoConceptoMonedaContraPartida { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? IdenMetodoPago { get; set; }
        public int EstadoConciliacion { get; set; }
        public string FuenteConciliacion { get; set; } = null!;
        public string DocumentoConciliacion { get; set; } = null!;
        public decimal EstadoAprobacion { get; set; }
        public decimal IdenFactura { get; set; }
        public string EsRetencionAut { get; set; } = null!;
        public decimal? IdenNuevaProgramacion { get; set; }
        public string? IdMonedaRetencion { get; set; }
        public string Moneda { get; set; } = null!;
        public string NumeroMoneda { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Plaza { get; set; } = null!;
        public string Banco { get; set; } = null!;
        public int Extornado { get; set; }
        public string? FuenteExtorno { get; set; }
        public string? DocumentoExtorno { get; set; }
        public decimal PorBienSer { get; set; }
        public decimal ValorFijo { get; set; }
        public decimal SobreExcedente { get; set; }

        public virtual ContPppConceptoPago? IdenConceptoNavigation { get; set; }
        public virtual ContPppProgramacione IdenProgramacionNavigation { get; set; } = null!;
    }
}
