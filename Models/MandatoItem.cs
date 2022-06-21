using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class MandatoItem
    {
        public MandatoItem()
        {
            Factbodies = new HashSet<Factbody>();
            FactdocBodies = new HashSet<FactdocBody>();
        }

        public decimal Iden { get; set; }
        public string Codigo { get; set; } = null!;
        public string Contrato { get; set; } = null!;
        public string MatriculaMercantil { get; set; } = null!;
        public string DigitoVerificacion { get; set; } = null!;
        public string Leyenda { get; set; } = null!;
        public string NombreComercial { get; set; } = null!;
        public string TipoIdentificacion { get; set; } = null!;
        public string NumeroIdentificacion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public int TipoPersona { get; set; }
        public int TipoRegimen { get; set; }
        public bool Deshabilitado { get; set; }

        public virtual ICollection<Factbody> Factbodies { get; set; }
        public virtual ICollection<FactdocBody> FactdocBodies { get; set; }
    }
}
