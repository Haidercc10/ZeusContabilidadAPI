using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MfProdvender
    {
        public MfProdvender()
        {
            MfProdvendusuarios = new HashSet<MfProdvendusuario>();
        }

        public int IdProdvender { get; set; }
        public string Codprodvender { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<MfProdvendusuario> MfProdvendusuarios { get; set; }
    }
}
