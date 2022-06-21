using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Valera
    {
        public Valera()
        {
            Vales = new HashSet<Vale>();
        }

        public decimal IdValera { get; set; }
        public string CodCliente { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string Fecha { get; set; } = null!;
        public string Prefijo { get; set; } = null!;
        public string CodValera { get; set; } = null!;
        public decimal ValeInicial { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorNeto { get; set; }
        public decimal ValorDesc { get; set; }
        public decimal PorcDesc { get; set; }
        public decimal ValorIva { get; set; }
        public decimal PorcIva { get; set; }
        public decimal ValorTotal { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public DateTime FechaGrabacion { get; set; }
        public string LeyendaValera { get; set; } = null!;

        public virtual Cliente CodClienteNavigation { get; set; } = null!;
        public virtual Document Document { get; set; } = null!;
        public virtual ValerasPrefijo PrefijoNavigation { get; set; } = null!;
        public virtual ICollection<Vale> Vales { get; set; }
    }
}
