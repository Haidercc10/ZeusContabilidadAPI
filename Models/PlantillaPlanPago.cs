using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class PlantillaPlanPago
    {
        public int Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? Monto { get; set; }
        public string? NumeroCuotas { get; set; }
        public string? TasaInteres { get; set; }
        public string? CuotasGracia { get; set; }
        public string? TasaMercado { get; set; }
        public string? CostosAsociados { get; set; }
        public string CeldaInicialLetra { get; set; } = null!;
        public int CeldaInicialNumero { get; set; }
        public string? CeldaFinalLetra { get; set; }
        public string? RutaArchivo { get; set; }
        public int SeleccionNombreHoja { get; set; }
        public string? NombreHoja { get; set; }
        public int SeleccionNumeroHoja { get; set; }
        public int? NumeroHoja { get; set; }
        public string? Macro { get; set; }
        public int? ManejaOrdenPersonalizado { get; set; }
        public int? OrdenCuota { get; set; }
        public int? OrdenFechaCuota { get; set; }
        public int? OrdenValorcuota { get; set; }
        public int? OrdenCapital { get; set; }
        public int? OrdenInteres { get; set; }
        public int? OrdenSaldocapital { get; set; }
        public int? OrdenTotalcxc { get; set; }
        public int Deshabilitado { get; set; }
        public string? CeldaSpread { get; set; }
    }
}
