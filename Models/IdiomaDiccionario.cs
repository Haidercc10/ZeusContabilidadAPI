using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IdiomaDiccionario
    {
        public IdiomaDiccionario()
        {
            IdiomaControles = new HashSet<IdiomaControle>();
            IdiomaTraduccions = new HashSet<IdiomaTraduccion>();
        }

        public decimal Iden { get; set; }
        public string Frace { get; set; } = null!;

        public virtual ICollection<IdiomaControle> IdiomaControles { get; set; }
        public virtual ICollection<IdiomaTraduccion> IdiomaTraduccions { get; set; }
    }
}
