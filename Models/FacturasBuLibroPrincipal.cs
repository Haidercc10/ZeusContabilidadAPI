using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class FacturasBuLibroPrincipal
    {
        public string Bu { get; set; } = null!;
        public string Codicta { get; set; } = null!;
        public string Idcliprv { get; set; } = null!;
        public string Tipofact { get; set; } = null!;
        public string Numefac { get; set; } = null!;
        public string Vencfac { get; set; } = null!;
        public string Refefac { get; set; } = null!;
        public string Idunidad { get; set; } = null!;
        public string Anomesfac { get; set; } = null!;
        public decimal Santfac { get; set; }
        public decimal Mvdbfac { get; set; }
        public decimal Mvcrfac { get; set; }
        public decimal Sactfac { get; set; }
        public decimal Santmfac { get; set; }
        public decimal Mvdbmfac { get; set; }
        public decimal Mvcrmfac { get; set; }
        public decimal Sactmfac { get; set; }
        public string? Clasecp { get; set; }
        public string Idzona { get; set; } = null!;
        public string Idvende { get; set; } = null!;
        public DateTime Feumfac { get; set; }
        public string? Fechfac { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public string? Fechacaducidad { get; set; }
        public string? Fecharadicado { get; set; }
        public string? Vencradicado { get; set; }
    }
}
