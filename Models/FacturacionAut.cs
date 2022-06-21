using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturacionAut
    {
        public string? Idcliente { get; set; }
        public string? Nomcliente { get; set; }
        public string? Iddocumento { get; set; }
        public string? Concepto { get; set; }
        public string? Nomconcepto { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Vrunitario { get; set; }
        public decimal? Totalconcepto { get; set; }
        public decimal? Porcdes { get; set; }
        public decimal? Porciva { get; set; }
        public decimal? Porcrete { get; set; }
        public decimal? Vrdescuento { get; set; }
        public decimal? Vriva { get; set; }
        public decimal? Vrrete { get; set; }
        public decimal? Baserete { get; set; }
        public string? Desclarga { get; set; }
        public string? Codcenco { get; set; }
        public string? Auxabto { get; set; }
        public string? Codcliente1 { get; set; }
        public string? Td { get; set; }
        public string? Numdoc { get; set; }
        public string? Vcto { get; set; }
        public string? Refe { get; set; }
        public string? Codvendedor { get; set; }
        public string? CodiFco { get; set; }
        public string? DbcrFco { get; set; }
        public string? DetalleFco { get; set; }
        public string? MoneFco { get; set; }
        public string? CodigodescFco { get; set; }
        public string? CodigoivaFco { get; set; }
        public string? CodigoreteFco { get; set; }
        public string? Idtercero { get; set; }
        public string? Idzona { get; set; }
        public string? Item { get; set; }
        public bool BlNovedad { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public int? Spid { get; set; }
        public string Bu { get; set; } = null!;
        public decimal Novedad { get; set; }
        public int IdenFacturacionAut { get; set; }
        public string? CambioIva { get; set; }
        public decimal? VlrIvaOrig { get; set; }
        public decimal? VlrBaseivaMod { get; set; }
        public decimal? VlrBaseivaOrig { get; set; }
    }
}
