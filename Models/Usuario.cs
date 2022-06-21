using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Usuario
    {
        public decimal Id { get; set; }
        public string? Nombre { get; set; }
        public string Login { get; set; } = null!;
        public string? Pass { get; set; }
        public string Email { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? Perfil { get; set; }
        public string? Roll { get; set; }
        public string Iplocal { get; set; } = null!;
        public int OnLine { get; set; }
        public string Port { get; set; } = null!;
        public string TipoUsuario { get; set; } = null!;
        public bool? BloqueoSevero { get; set; }
        public bool? BloqueoMovimiento { get; set; }
        public bool? BloqueoProgramado { get; set; }
        public DateTime? FechaInicioBloqueo { get; set; }
        public int Spid { get; set; }
        public string HostName { get; set; } = null!;
        public string Codigoidioma { get; set; } = null!;
        public string CuentaCaja { get; set; } = null!;
        public string Bu { get; set; } = null!;
        public string IdDiscoDuro { get; set; } = null!;
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public string? PreguntaSecreta { get; set; }
        public string? RespuestaSecreta { get; set; }
        public bool? UsuarioInactivo { get; set; }
        public string ControldeUsuario { get; set; } = null!;
        public int EstadoUsuario { get; set; }
        public int IdRollZeusVariable { get; set; }
        public string? Direccion { get; set; }
        public string? Cedula { get; set; }
        public int? IdPerfil { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
