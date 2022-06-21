using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TipoMaestroCampo
    {
        public decimal Iden { get; set; }
        public int IdenMaestro { get; set; }
        public string ColNombreFisico { get; set; } = null!;
        public string ColNombreLogico { get; set; } = null!;
        public string ColCaption { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string TipoDato { get; set; } = null!;
        public decimal Tamano { get; set; }
        public int PrecisionCol { get; set; }
        public decimal DefaultNumerico { get; set; }
        public DateTime? DefaultFecha { get; set; }
        public string? DefaultVarchar { get; set; }
        public bool ManejaAyuda { get; set; }
        public string? SeccionAyuda { get; set; }
        public string? ListaPosibilidades { get; set; }
        public string? OpcionalAyuda { get; set; }
        public bool Habilitado { get; set; }
        public bool Requerido { get; set; }
        public bool Bloqueado { get; set; }
        public int? BuscadorGenerico { get; set; }
        public int Orden { get; set; }
        public int CampoDelSistema { get; set; }
        public int CampoLlave { get; set; }
        public string OpcionIni1 { get; set; } = null!;
        public string OpcionIni2 { get; set; } = null!;
        public bool? TieneEnlaceArticulo { get; set; }
        public string? ArticuloForaneo { get; set; }
    }
}
