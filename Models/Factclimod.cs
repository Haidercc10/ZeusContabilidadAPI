using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Factclimod
    {
        public string Idcliente { get; set; } = null!;
        public string Iddocum { get; set; } = null!;
        public string Idmodelo { get; set; } = null!;
        public string Fechaini { get; set; } = null!;
        public int Periodicidad { get; set; }
        public int? Numeroperiodos { get; set; }
        public int? Periodocontrol { get; set; }
        public int? Status { get; set; }
        public string? Fechfact { get; set; }
        public string? Idfuente { get; set; }
        public string? Iddocumento { get; set; }
        public decimal? Ultimovalorfac { get; set; }
        public string? Centrocosto { get; set; }
        public string? Ciclo { get; set; }
        public string Fechafacturacion { get; set; } = null!;
        public int GenerarNcuotas { get; set; }
        public int NumeroCuotas { get; set; }
        public int DiasVencimiento { get; set; }
        public string Bu { get; set; } = null!;
        public string? CxC { get; set; }
        public string? Item { get; set; }
        public string? CodigoPropiedad1 { get; set; }
        public string? CodigoPropiedad2 { get; set; }
        public string? CodigoPropiedad3 { get; set; }
        public string? CodigoPropiedad4 { get; set; }
        public string? CodigoPropiedad5 { get; set; }
        public string? VencimientoModelo { get; set; }
        public string? VencimientoDiaHabil { get; set; }
        public string? Idzona { get; set; }
        public string? Idvende { get; set; }
        public string Auxiliar { get; set; } = null!;
        public int IdenFactclimod { get; set; }
        public int ConfAuxiliar { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
    }
}
