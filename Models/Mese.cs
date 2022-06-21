using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Mese
    {
        public string Anomes { get; set; } = null!;
        public string OpenMes { get; set; } = null!;
        public string DiskMes { get; set; } = null!;
        public string? DisktMes { get; set; }
        public string AjusMes { get; set; } = null!;
        public string DifeMes { get; set; } = null!;
        public decimal? PagMes { get; set; }
        public decimal? PagAcu { get; set; }
        public string Indrotpresp { get; set; } = null!;
        public string? IndDesctopp { get; set; }
        public string? Apecierre { get; set; }
        public string? IndCtacxc { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenMeses { get; set; }
        public decimal Valventas { get; set; }
        public decimal Porcentope { get; set; }

        public virtual RevelacionesMese RevelacionesMese { get; set; } = null!;
    }
}
