using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ScCobradorBu
    {
        public decimal IdenCobrador { get; set; }
        public string Bu { get; set; } = null!;
        public int IdenScCobradorBu { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual ScCobrador IdenCobradorNavigation { get; set; } = null!;
    }
}
