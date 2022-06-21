using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EscenariosFiscale
    {
        public EscenariosFiscale()
        {
            EscenariosFiscalesImpuestos = new HashSet<EscenariosFiscalesImpuesto>();
        }

        public decimal Iden { get; set; }
        public string EscenariosCategoriaTributariaIden { get; set; } = null!;
        public decimal EscenariosTributarioConsumoIden { get; set; }
        public decimal EscenariosTributarioRentaIden { get; set; }
        public decimal EscenariosSubCategoriaEfecCompraIden { get; set; }
        public decimal EscenariosEscenarioIden { get; set; }
        public decimal EscenariosTributarioIcatIden { get; set; }
        public DateTime FechaEfectiva { get; set; }
        public string Tipo { get; set; } = null!;
        public decimal? PorcentajeResultanteIva { get; set; }
        public decimal? PorcentajeResultanteInc { get; set; }

        public virtual EscenariosCategoriaTributarium EscenariosCategoriaTributariaIdenNavigation { get; set; } = null!;
        public virtual EscenariosEscenario EscenariosEscenarioIdenNavigation { get; set; } = null!;
        public virtual EscenariosSubCategoriaEfecCompra EscenariosSubCategoriaEfecCompraIdenNavigation { get; set; } = null!;
        public virtual EscenariosTributarioConsumo EscenariosTributarioConsumoIdenNavigation { get; set; } = null!;
        public virtual EscenariosTributarioIcat EscenariosTributarioIcatIdenNavigation { get; set; } = null!;
        public virtual EscenariosTributarioRentum EscenariosTributarioRentaIdenNavigation { get; set; } = null!;
        public virtual ICollection<EscenariosFiscalesImpuesto> EscenariosFiscalesImpuestos { get; set; }
    }
}
