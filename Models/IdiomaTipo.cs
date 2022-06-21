using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class IdiomaTipo
    {
        public IdiomaTipo()
        {
            IdiomaTraduccions = new HashSet<IdiomaTraduccion>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual ICollection<IdiomaTraduccion> IdiomaTraduccions { get; set; }
    }
}
