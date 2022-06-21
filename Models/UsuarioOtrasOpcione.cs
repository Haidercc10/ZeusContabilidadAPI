using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class UsuarioOtrasOpcione
    {
        public decimal Iden { get; set; }
        public decimal? Id { get; set; }
        public string? Tipo { get; set; }
        public int? IdPerfil { get; set; }
        public decimal? IdRol { get; set; }
        public bool? ExpiraLaCuenta { get; set; }
        public DateTime? ExpiraFecha { get; set; }
        public bool? CaducaPassword { get; set; }
        public DateTime? CaducaFechaInicial { get; set; }
        public string? CaducaPeriodoEn { get; set; }
        public int? CaducaPeriodoValor { get; set; }
        public int? CaducaRecordatorio { get; set; }
        public int? LongitudPassword { get; set; }
        public bool? PasswordConRequisitos { get; set; }
        public decimal? LongitudHistorialPassword { get; set; }
        public string? HistorialPassword { get; set; }
        public int? IntentosFallidos { get; set; }
        public int? NumeroIntentos { get; set; }
        public bool? Bloqueado { get; set; }
        public bool? CambiaPassEnInicio { get; set; }
        public bool? ControlaAdyacencia { get; set; }
    }
}
