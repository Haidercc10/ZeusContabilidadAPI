using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class TransacConciliacionCabecera
    {
        public decimal Iden { get; set; }
        public decimal Consecutivo { get; set; }
        public string NomArchivo { get; set; } = null!;
        public string Anotra { get; set; } = null!;
        public decimal ImpExtractosDefinicionIden { get; set; }
        public string CtaBanco { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Archivo { get; set; } = null!;
        public DateTime FechaGrabacion { get; set; }
        public string Usuario { get; set; } = null!;
        public string? FechaInicial { get; set; }
        public string? FechaFinal { get; set; }
        public string? NotaAjusteFte { get; set; }
        public string? NotaAjusteDcto { get; set; }
        public string? NotaAjusteCta { get; set; }
        public string? NotaAjusteFecha { get; set; }
        public string? NotaAjusteItem { get; set; }
        public string? NotaAjusteCenco { get; set; }
        public string? NotaAjustePropiedad1 { get; set; }
        public string? NotaAjustePropiedad2 { get; set; }
        public string? NotaAjustePropiedad3 { get; set; }
        public string? NotaAjustePropiedad4 { get; set; }
        public string? NotaAjustePropiedad5 { get; set; }
        public string? NotaAjusteTipofac { get; set; }
        public string? NotaAjusteNumefac { get; set; }
        public string? NotaAjusteVencefac { get; set; }
        public string? NotaAjusteRefefac { get; set; }
        public string? NotaAjusteEntidad { get; set; }
        public string? NotaAjustePlaza { get; set; }
        public int? TipoMovCtas { get; set; }

        public virtual ImpExtractosDefinicion ImpExtractosDefinicionIdenNavigation { get; set; } = null!;
    }
}
