using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ContPppProgramacionesDocumento
    {
        public decimal Iden { get; set; }
        public decimal IdenProgramacion { get; set; }
        public decimal Consecutivo { get; set; }
        public string TipoProTer { get; set; } = null!;
        public string ProTer { get; set; } = null!;
        public string Fuente { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? Cheque { get; set; }
        public string? CodigoMatriculaGerencia { get; set; }
        public string? IdMoneda { get; set; }
        public int? EstadoConciliacion { get; set; }
        public decimal? ConsecutivoConciliacion { get; set; }
        public string? FuenteConciliacion { get; set; }
        public string? DocumentoConciliacion { get; set; }
        public decimal IdenMetodoPago { get; set; }
        public decimal? IdenEstado { get; set; }
        public decimal? IdenOpp { get; set; }
        public bool BlGenChequesPosfechados { get; set; }
        public int Extornado { get; set; }
        public string? FuenteExtorno { get; set; }
        public string? DocumentoExtorno { get; set; }
        public string Respuesta { get; set; } = null!;
        public string SecuenciaPago { get; set; } = null!;

        public virtual ContPppProgramacione IdenProgramacionNavigation { get; set; } = null!;
    }
}
