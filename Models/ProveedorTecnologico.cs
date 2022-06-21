using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ProveedorTecnologico
    {
        public ProveedorTecnologico()
        {
            Clientes = new HashSet<Cliente>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Deshabilitado { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
