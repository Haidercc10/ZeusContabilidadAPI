using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Difepar
    {
        public string Iddif { get; set; } = null!;
        public string Codigodif { get; set; } = null!;
        public string? Cencosdif { get; set; }
        public string? Auxiliadif { get; set; }
        public string? Itemdif { get; set; }
        public string? Tercerdif { get; set; }
        public string Descdif { get; set; } = null!;
        public string Fuentedif { get; set; } = null!;
        public string Dbcrdif { get; set; } = null!;
        public int? Periodif { get; set; }
        public string? Fecinidif { get; set; }
        public string? Fecfindif { get; set; }
        public decimal? Totaldif { get; set; }
        public decimal? Cuotadif { get; set; }
        public string? Formudif { get; set; }
        public decimal? Vrmesdif { get; set; }
        public decimal? Saldodif { get; set; }
        public int? Peraplidif { get; set; }
        public string Fechaper { get; set; } = null!;
        public string Feultact { get; set; } = null!;
        public string? Estado { get; set; }
        public string? CliPrv { get; set; }
        public string? TipoFac { get; set; }
        public string? Numefac { get; set; }
        public string? Vencefac { get; set; }
        public string? Refefac { get; set; }
        public string RefeDife { get; set; } = null!;
        public string Fuentedoc { get; set; } = null!;
        public string Numdoctradoc { get; set; } = null!;
        public int? Consecutradoc { get; set; }
        public string Bu { get; set; } = null!;
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public string? Revelacion { get; set; }
        public int? IdenSecciones { get; set; }
        public string? IdDifCancelacion { get; set; }
        public int IdenDifepar { get; set; }
        public string CodigoPresupuestal { get; set; } = null!;
        public string ReservaPresupuestal { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual Maecont CodigodifNavigation { get; set; } = null!;
    }
}
