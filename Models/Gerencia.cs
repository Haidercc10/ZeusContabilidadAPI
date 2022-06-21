using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Gerencia
    {
        public Gerencia()
        {
            GerenciaPagos = new HashSet<GerenciaPago>();
            GerenciasCuenta = new HashSet<GerenciasCuenta>();
        }

        public int Iden { get; set; }
        public string Gerencia1 { get; set; } = null!;
        public string? Pais { get; set; }
        public bool? Habilitada { get; set; }
        public bool Seguridad { get; set; }
        public string Contraseña { get; set; } = null!;
        public int IdenGerencias { get; set; }
        public string? EmailEnvio { get; set; }
        public int IntegracionDirecta { get; set; }
        public int SecuenciaPago { get; set; }
        public int TipoGeneracion { get; set; }
        public string ClavePgp { get; set; } = null!;

        public virtual ICollection<GerenciaPago> GerenciaPagos { get; set; }
        public virtual ICollection<GerenciasCuenta> GerenciasCuenta { get; set; }
    }
}
