using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MpgCrpOcItem
    {
        public decimal Iden { get; set; }
        public decimal IdenRelacionado { get; set; }
        public string Rubro { get; set; } = null!;
        public string Recurso { get; set; } = null!;
        public string CentroCosto { get; set; } = null!;
        public decimal Valor { get; set; }
        public decimal Satisfecho { get; set; }
        public decimal Adiciones { get; set; }
        public decimal Disminuciones { get; set; }
        public decimal Saldo { get; set; }
        public string TipoRegistro { get; set; } = null!;
        public int CreadoAdicion { get; set; }
        public decimal Enero { get; set; }
        public decimal Febrero { get; set; }
        public decimal Marzo { get; set; }
        public decimal Abril { get; set; }
        public decimal Mayo { get; set; }
        public decimal Junio { get; set; }
        public decimal Julio { get; set; }
        public decimal Agosto { get; set; }
        public decimal Septiembre { get; set; }
        public decimal Octubre { get; set; }
        public decimal Noviembre { get; set; }
        public decimal Diciembre { get; set; }
        public decimal EneroP { get; set; }
        public decimal FebreroP { get; set; }
        public decimal MarzoP { get; set; }
        public decimal AbrilP { get; set; }
        public decimal MayoP { get; set; }
        public decimal JunioP { get; set; }
        public decimal JulioP { get; set; }
        public decimal AgostoP { get; set; }
        public decimal SeptiembreP { get; set; }
        public decimal OctubreP { get; set; }
        public decimal NoviembreP { get; set; }
        public decimal DiciembreP { get; set; }
        public decimal DevolucionCompra { get; set; }
    }
}
