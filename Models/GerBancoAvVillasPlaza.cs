using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class GerBancoAvVillasPlaza
    {
        public GerBancoAvVillasPlaza()
        {
            GerBancoAvVillas = new HashSet<GerBancoAvVilla>();
        }

        public string CodPlaza { get; set; } = null!;
        public string NombrePlaza { get; set; } = null!;
        public int IdenGerbancoavvillasPlazas { get; set; }

        public virtual ICollection<GerBancoAvVilla> GerBancoAvVillas { get; set; }
    }
}
