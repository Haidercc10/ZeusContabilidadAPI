using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusExcelConfUsuario
    {
        public int Id { get; set; }
        public string? Usuario { get; set; }
        public bool? NomColumn { get; set; }
        public bool? FormAutColumn { get; set; }
        public bool? AnchoColumn { get; set; }
        public bool? AjustTamHoja { get; set; }
        public bool? AjustFiltHoja { get; set; }
        public bool? ConsulReemplValor { get; set; }
        public bool? TablaPivot { get; set; }
        public bool? FunRelacion { get; set; }
        public bool? CamposTabl { get; set; }
        public bool? OrdPrimerCampo { get; set; }
        public string? MaxNumerReg { get; set; }
        public int? Fila { get; set; }
        public int? Columna { get; set; }
        public bool? Libro { get; set; }
        public bool? ExplFuncion { get; set; }
        public int? CantExplFuncion { get; set; }
        public int? ChkSeleccionBu { get; set; }
        public string? SeleccionBu { get; set; }
    }
}
