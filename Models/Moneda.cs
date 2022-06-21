using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Moneda
    {
        public Moneda()
        {
            Factconcs = new HashSet<Factconc>();
            Maeconts = new HashSet<Maecont>();
            Tcambios = new HashSet<Tcambio>();
        }

        public string Idmoneda { get; set; } = null!;
        public string Descrip { get; set; } = null!;
        public byte? Tipo { get; set; }
        public decimal? Porcomi { get; set; }
        public string? Ctacomi { get; set; }
        public int Simoneda { get; set; }
        public string? Topico0 { get; set; }
        public decimal? Porcomi0 { get; set; }
        public string? Ctacomi0 { get; set; }
        public string? Depende0 { get; set; }
        public string? Topico1 { get; set; }
        public decimal? Porcomi1 { get; set; }
        public string? Ctacomi1 { get; set; }
        public string? Depende1 { get; set; }
        public string? Topico2 { get; set; }
        public decimal? Porcomi2 { get; set; }
        public string? Ctacomi2 { get; set; }
        public string? Depende2 { get; set; }
        public string? Topico3 { get; set; }
        public decimal? Porcomi3 { get; set; }
        public string? Ctacomi3 { get; set; }
        public string? Depende3 { get; set; }
        public string? Topico4 { get; set; }
        public decimal? Porcomi4 { get; set; }
        public string? Ctacomi4 { get; set; }
        public string? Depende4 { get; set; }
        public int Deshabilitado { get; set; }
        public int Decimales { get; set; }
        public int DecimalesImpuestos { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public string? TipoCarta { get; set; }
        public int IdenMonedas { get; set; }

        public virtual Maecont? Ctacomi0Navigation { get; set; }
        public virtual Maecont? Ctacomi1Navigation { get; set; }
        public virtual Maecont? Ctacomi2Navigation { get; set; }
        public virtual Maecont? Ctacomi3Navigation { get; set; }
        public virtual Maecont? Ctacomi4Navigation { get; set; }
        public virtual Maecont? CtacomiNavigation { get; set; }
        public virtual ICollection<Factconc> Factconcs { get; set; }
        public virtual ICollection<Maecont> Maeconts { get; set; }
        public virtual ICollection<Tcambio> Tcambios { get; set; }
    }
}
