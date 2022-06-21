using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Auxiliar
    {
        public Auxiliar()
        {
            ClientesAnticipos = new HashSet<ClientesAnticipo>();
            SaldoauxBus = new HashSet<SaldoauxBu>();
        }

        public string Codicta { get; set; } = null!;
        public string Auxiaux { get; set; } = null!;
        public string Descrip { get; set; } = null!;
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenAuxiliar { get; set; }

        public virtual Maecont CodictaNavigation { get; set; } = null!;
        public virtual ICollection<ClientesAnticipo> ClientesAnticipos { get; set; }
        public virtual ICollection<SaldoauxBu> SaldoauxBus { get; set; }
    }
}
