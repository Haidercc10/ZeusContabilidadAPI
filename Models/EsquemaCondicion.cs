using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaCondicion
    {
        public EsquemaCondicion()
        {
            EsquemaCondicionTransacciones = new HashSet<EsquemaCondicionTransaccione>();
        }

        public decimal Iden { get; set; }
        public decimal Esquema { get; set; }
        public string? CodictaInicial { get; set; }
        public string? CodictaFinal { get; set; }
        public bool? CodictaTodos { get; set; }
        public bool? CodictaNot { get; set; }
        public string? IdfuenteInicial { get; set; }
        public string? IdFuenteFinal { get; set; }
        public bool? IdFuenteTodos { get; set; }
        public bool? IdFuenteNot { get; set; }
        public string? IdCencoInicial { get; set; }
        public string? IdCencoFinal { get; set; }
        public bool? IdCencoTodos { get; set; }
        public bool? IdCencoNot { get; set; }
        public string? NittraInicial { get; set; }
        public string? NittraFinal { get; set; }
        public bool? NittraTodos { get; set; }
        public bool? NittraNot { get; set; }
        public string? AuxiAuxInicial { get; set; }
        public string? AuxiAuxFinal { get; set; }
        public bool? AuxiAuxTodos { get; set; }
        public bool? AuxiAuxNot { get; set; }
        public string? BuInicial { get; set; }
        public string? BuFinal { get; set; }
        public bool? BuTodos { get; set; }
        public bool? BuNot { get; set; }
        public string? ItemInicial { get; set; }
        public string? ItemFinal { get; set; }
        public bool? ItemTodos { get; set; }
        public bool? ItemNot { get; set; }
        public string? BancoInicial { get; set; }
        public string? BancoFinal { get; set; }
        public bool? BancoTodos { get; set; }
        public bool? BancoNot { get; set; }
        public string? VendedorInicial { get; set; }
        public string? VendedorFinal { get; set; }
        public bool? VendedorTodos { get; set; }
        public bool? VendedorNot { get; set; }
        public string? PlazaInicial { get; set; }
        public string? PlazaFinal { get; set; }
        public bool? PlazaTodos { get; set; }
        public bool? PlazaNot { get; set; }
        public string? TipoFactInicial { get; set; }
        public string? TipoFactFinal { get; set; }
        public bool? TipoFactTodos { get; set; }
        public bool? TipoFactNot { get; set; }
        public string? ZonaInicial { get; set; }
        public string? ZonaFinal { get; set; }
        public bool? ZonaTodos { get; set; }
        public bool? ZonaNot { get; set; }
        public string? CliPrvInicial { get; set; }
        public string? CliPrvFinal { get; set; }
        public bool? CliprvTodos { get; set; }
        public bool? CliprvNot { get; set; }
        public bool? ValorTodos { get; set; }
        public decimal? Valor { get; set; }
        public string? TipoValor { get; set; }
        public string? MonedaInicial { get; set; }
        public string? MonedaFinal { get; set; }
        public bool? MonedaTodos { get; set; }
        public bool? MonedaNingun { get; set; }
        public string? Formula { get; set; }
        public int TipoCondicion { get; set; }
        public decimal? IdenEsquemaCondicionRel { get; set; }
        public int TipoPlantilla { get; set; }
        public bool? LibroBu { get; set; }
        public decimal? IdenLibroBu { get; set; }
        public decimal OrdenInsert { get; set; }

        public virtual Esquema EsquemaNavigation { get; set; } = null!;
        public virtual ICollection<EsquemaCondicionTransaccione> EsquemaCondicionTransacciones { get; set; }
    }
}
