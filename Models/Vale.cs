using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Vale
    {
        public Vale()
        {
            ValesLogs = new HashSet<ValesLog>();
        }

        public decimal IdVale { get; set; }
        public decimal IdValera { get; set; }
        public decimal Vale1 { get; set; }
        public decimal ValorNeto { get; set; }
        public decimal ValorDesc { get; set; }
        public decimal ValorIva { get; set; }
        public decimal ValorTotal { get; set; }
        public string Estado { get; set; } = null!;
        public string CuentaAnticipo { get; set; } = null!;
        public string CencoAnticipo { get; set; } = null!;
        public string AuxiliarAnticipo { get; set; } = null!;
        public string CuentaIngreso { get; set; } = null!;
        public string CencoIngreso { get; set; } = null!;
        public string AuxiliarIngreso { get; set; } = null!;
        public string FuenteCausacion { get; set; } = null!;
        public string DocumentoCausacion { get; set; } = null!;
        public string FechaCausacion { get; set; } = null!;
        public string Observaciones { get; set; } = null!;
        public string ObservacionesAdicionales { get; set; } = null!;
        public decimal Verificacion { get; set; }
        public decimal ValeAnulado { get; set; }
        public string FuenteCausacionRv { get; set; } = null!;
        public string DocumentoCausacionRv { get; set; } = null!;
        public string FechaCausacionRv { get; set; } = null!;
        public string Impresion { get; set; } = null!;
        public string UsuarioImpresion { get; set; } = null!;
        public DateTime FechaImpresion { get; set; }
        public string PrefijoCausacion { get; set; } = null!;
        public string Conciliado { get; set; } = null!;
        public string FuenteConciliacion { get; set; } = null!;
        public string DocumentoConciliacion { get; set; } = null!;
        public string FechaConciliacion { get; set; } = null!;
        public string FuenteConciliacionRv { get; set; } = null!;
        public string DocumentoConciliacionRv { get; set; } = null!;
        public string FechaConciliacionRv { get; set; } = null!;
        public DateTime FechaValidacion { get; set; }
        public string UsuarioValidacion { get; set; } = null!;
        public string Vencimiento { get; set; } = null!;

        public virtual Maecont CuentaAnticipoNavigation { get; set; } = null!;
        public virtual Maecont CuentaIngresoNavigation { get; set; } = null!;
        public virtual Valera IdValeraNavigation { get; set; } = null!;
        public virtual ICollection<ValesLog> ValesLogs { get; set; }
    }
}
