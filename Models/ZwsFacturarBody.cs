using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZwsFacturarBody
    {
        public int Spid { get; set; }
        public decimal IdenHead { get; set; }
        public string Concepto { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? ValorUnit { get; set; }
        public decimal PorcIva { get; set; }
        public decimal PorcDesc { get; set; }
        public decimal PorcRet { get; set; }
        public string? CentroCostoConc { get; set; }
        public string? AuxiliarConc { get; set; }
        public string? Tercero { get; set; }
        public string? Cliente { get; set; }
        public string? Proveedor { get; set; }
        public string? TipoFac { get; set; }
        public string? NumeFac { get; set; }
        public string? VenceFac { get; set; }
        public string? RefeFac { get; set; }
        public decimal Unidad1 { get; set; }
        public decimal Unidad2 { get; set; }
        public decimal Unidad3 { get; set; }
        public string? Item { get; set; }
        public decimal ValorConcepto { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal BaseImpuesto { get; set; }
        public decimal ValorAntesImpuestos { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Iden { get; set; }
        public string Bu { get; set; } = null!;
        public string PrefijoValera { get; set; } = null!;
        public string? CodigoCxC { get; set; }
        public bool? BConceptoAutomatico { get; set; }
        public string CambioIva { get; set; } = null!;
        public decimal VlrIvaOrig { get; set; }
        public decimal VlrBaseivaNuevo { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
