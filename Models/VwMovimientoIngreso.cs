using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class VwMovimientoIngreso
    {
        public long? Idregistro { get; set; }
        public string UnidadNegocio { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string NombreCuenta { get; set; } = null!;
        public string Tercero { get; set; } = null!;
        public string NombreTercero { get; set; } = null!;
        public string? CentrodeCosto { get; set; }
        public string Fuente { get; set; } = null!;
        public string NombreFuente { get; set; } = null!;
        public decimal Valor { get; set; }
        public string? DtFecha { get; set; }
        public int? Anno { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public string? AnnoMes { get; set; }
        public string? AnnoMesLetra { get; set; }
        public string? FechaLetras { get; set; }
        public int? DiaDeLaSemana { get; set; }
        public string? DiaDelAnno { get; set; }
        public string? NombreDia { get; set; }
        public string? NombreDiaLargo { get; set; }
        public string? NombreDiaCorto { get; set; }
        public int? SemanaDelMes { get; set; }
        public string? SemanaDelAnno { get; set; }
        public string? NombreMes { get; set; }
        public string? NombreMesCorto { get; set; }
        public string? Trimestre { get; set; }
        public string? NombreTrimestre { get; set; }
        public byte? Semestre { get; set; }
        public string? NombreSemestre { get; set; }
        public int FinSemana { get; set; }
        public string ZolLink { get; set; } = null!;
    }
}
