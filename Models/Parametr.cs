using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Parametr
    {
        public string Parametro { get; set; } = null!;
        public string Descpar { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte Longitud { get; set; }
        public byte? Decimales { get; set; }
        public string? Pictpar { get; set; }
        public string? Valipar { get; set; }
        public string? Valopar { get; set; }
        public DateTime Ultupd { get; set; }
        public string? Whoupd { get; set; }
        public byte? Onlyread { get; set; }
        public string? Pariente { get; set; }
        public int Orden { get; set; }
        public bool? ManejarAyuda { get; set; }
        public string? SeccionAyuda { get; set; }
        public string? ListaPosibilidades { get; set; }
        public string? OpcionalAyuda { get; set; }
        public string? Descripcion { get; set; }
        public bool? UserFrom { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenParametr { get; set; }
        public string? PathParentCode { get; set; }
        public bool? IsParent { get; set; }
        public int? IdDataType { get; set; }
        public string? Placeholder { get; set; }
        public bool? IsRequired { get; set; }
        public bool? IsPassword { get; set; }
        public string? ValueDefault { get; set; }
        public string? ValueSelect { get; set; }
        public string? CodeHelp { get; set; }
        public string? ConditionActive { get; set; }
        public string? ConditionSave { get; set; }
        public bool? IsActive { get; set; }
    }
}
