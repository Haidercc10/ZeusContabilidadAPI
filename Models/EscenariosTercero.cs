using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosTercero
    {
        public long? Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? EscenariosClaseContribuyenteIden { get; set; }
        public decimal? EscenariosCategoriaTributariaIvaIden { get; set; }
        public decimal? EscenariosTipoContribuyenteIden { get; set; }
        public decimal? EscenariosEsAutorretenedorIden { get; set; }
        public decimal? EscenariosAplicaIcatIden { get; set; }
        public decimal? EscenariosTipoRetencionIvaIden { get; set; }
        public string? EscenariosCategoriaTributaria { get; set; }
        public decimal? EscenariosPaisIden { get; set; }
        public string? CategoriaTributaria { get; set; }
    }
}
