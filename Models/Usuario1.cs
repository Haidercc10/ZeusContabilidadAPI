using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Usuario1
    {
        public Usuario1()
        {
            ExcelInfodesignusuarios = new HashSet<ExcelInfodesignusuario>();
            FacturasVsCobroLogs = new HashSet<FacturasVsCobroLog>();
            HistoriaAutorizacionClientes = new HashSet<HistoriaAutorizacionCliente>();
            RptConfigDetalleAtributos = new HashSet<RptConfigDetalleAtributo>();
            SolicitudPresupuestoUsuarioAutorizaNavigations = new HashSet<SolicitudPresupuesto>();
            SolicitudPresupuestoUsuarioNavigations = new HashSet<SolicitudPresupuesto>();
            UsuariosBus = new HashSet<UsuariosBu>();
            UsuariosModificaFechas = new HashSet<UsuariosModificaFecha>();
            UsuariosPermisoDctos = new HashSet<UsuariosPermisoDcto>();
        }

        public string Usuario { get; set; } = null!;
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Cedula { get; set; }
        public string? Grupo { get; set; }
        public string? Perfil { get; set; }
        public string? Impresora { get; set; }
        public bool? Chkrever { get; set; }
        public bool? Chkmodif { get; set; }
        public string Email { get; set; } = null!;
        public string Usolibre { get; set; } = null!;
        public decimal Id { get; set; }
        public string Serie { get; set; } = null!;
        public string? Rol { get; set; }
        public bool? ChkVerContFact { get; set; }
        public bool ChkVerConcRelFact { get; set; }
        public bool? ChkVerTodosUser { get; set; }
        public bool ChkAnularDcto { get; set; }
        public bool ChkModifIntMora { get; set; }
        public decimal PorcIntMora { get; set; }
        public bool ChInactivar { get; set; }
        public bool ChReimprimirRc { get; set; }
        public bool ChkExigirCambioClave { get; set; }
        public string? Autenticacion { get; set; }
        public string? Pass { get; set; }
        public string? PreguntaSecreta { get; set; }
        public string? RespuestaSecreta { get; set; }
        public string? CodigoIdioma { get; set; }
        public bool ChConsolidado { get; set; }
        public string Bu { get; set; } = null!;
        public string TipoUsuarioBu { get; set; } = null!;
        public bool ChkContabilizaPreparacionDcto { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal? TiempoInactividad { get; set; }
        public int? UnidadTiempoInactividad { get; set; }
        public string Login { get; set; } = null!;
        public bool? ChkModificarDiasVence { get; set; }
        public string? IpLocal { get; set; }
        public bool? OnLine { get; set; }
        public string? Port { get; set; }
        public bool? BloqueoSevero { get; set; }
        public bool? BloqueoMovimiento { get; set; }
        public bool? BloqueoProgramado { get; set; }
        public DateTime? FechaInicioBloqueo { get; set; }
        public int? Spid { get; set; }
        public string? HostName { get; set; }
        public bool ChkNomodificarCuotas { get; set; }
        public int NumeroCuotas { get; set; }
        public string CuentaCaja { get; set; } = null!;
        public int DetalleTercero { get; set; }
        public string UserId { get; set; } = null!;
        public string? NormalizedUserName { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int? AccessFailedCount { get; set; }
        public string? UrlPhoto { get; set; }
        public string? UserIdCreator { get; set; }
        public int ChConsolidadoxDefecto { get; set; }
        public bool BlockLogin { get; set; }
        public bool BlockTemp { get; set; }
        public bool BlockAdmin { get; set; }
        public bool BlockSchedule { get; set; }
        public DateTime? BlockScheduleDate { get; set; }

        public virtual Bu BuNavigation { get; set; } = null!;
        public virtual AmbitosFiscalesUsuario AmbitosFiscalesUsuario { get; set; } = null!;
        public virtual MfConfiguracionUsuario MfConfiguracionUsuario { get; set; } = null!;
        public virtual PersonalAutorizacion PersonalAutorizacion { get; set; } = null!;
        public virtual ICollection<ExcelInfodesignusuario> ExcelInfodesignusuarios { get; set; }
        public virtual ICollection<FacturasVsCobroLog> FacturasVsCobroLogs { get; set; }
        public virtual ICollection<HistoriaAutorizacionCliente> HistoriaAutorizacionClientes { get; set; }
        public virtual ICollection<RptConfigDetalleAtributo> RptConfigDetalleAtributos { get; set; }
        public virtual ICollection<SolicitudPresupuesto> SolicitudPresupuestoUsuarioAutorizaNavigations { get; set; }
        public virtual ICollection<SolicitudPresupuesto> SolicitudPresupuestoUsuarioNavigations { get; set; }
        public virtual ICollection<UsuariosBu> UsuariosBus { get; set; }
        public virtual ICollection<UsuariosModificaFecha> UsuariosModificaFechas { get; set; }
        public virtual ICollection<UsuariosPermisoDcto> UsuariosPermisoDctos { get; set; }
    }
}
