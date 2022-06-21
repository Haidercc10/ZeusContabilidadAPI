using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ArchivoAsobancariaTransaccione
    {
        public int? SpId { get; set; }
        public string? Xanotra { get; set; }
        public string? Xidfuente { get; set; }
        public string? Xnumdoctra { get; set; }
        public string? Xfechatra { get; set; }
        public string? Xcodicta { get; set; }
        public string? Xnittra { get; set; }
        public string? Xauxiaux { get; set; }
        public string? Xidcenco { get; set; }
        public string? Xiditem { get; set; }
        public string? Xdescritra { get; set; }
        public decimal? Xvalortra { get; set; }
        public string? Xindcpitra { get; set; }
        public string? Xconciltra { get; set; }
        public string? Xidbanco { get; set; }
        public string? Xidvende { get; set; }
        public string? Xidplaza { get; set; }
        public string? Xtipofac { get; set; }
        public string? Xnumefac { get; set; }
        public string? Xvencefac { get; set; }
        public string? Xrefefac { get; set; }
        public string? Xidzona { get; set; }
        public string? Xcliprv { get; set; }
        public string? Xidusuario { get; set; }
        public string? Xidunidad1 { get; set; }
        public string? Xidunidad2 { get; set; }
        public string? Xidunidad3 { get; set; }
        public decimal? Xvrunidad1 { get; set; }
        public decimal? Xvrunidad2 { get; set; }
        public decimal? Xvrunidad3 { get; set; }
        public string? Xstatustra { get; set; }
        public string? Xdescdcto { get; set; }
        public string? Xcbadcto { get; set; }
        public string? Xcenco { get; set; }
        public string? Xauxiliar { get; set; }
        public string? Xitem { get; set; }
        public string? Xidcliprv { get; set; }
        public string? Xidtercero { get; set; }
        public string? Xbanco { get; set; }
        public string? Xnuche { get; set; }
        public decimal? Xvcheq { get; set; }
        public string? Xbenef { get; set; }
        public decimal? Xvalormoneda { get; set; }
        public decimal? Xporcrete { get; set; }
        public decimal? Xbaserete { get; set; }
        public string? Xmontoletras { get; set; }
        public string? Codpresu { get; set; }
        public string? Nreserva { get; set; }
        public string? Fechafact { get; set; }
        public string? Serie { get; set; }
        public string? Autorizacion { get; set; }
        public string? Voucher { get; set; }
        public string? MontoMoneda { get; set; }
        public decimal? TasaCambio { get; set; }
        public decimal? TasaCambioDoc { get; set; }
        public string? Ncf { get; set; }
        public string? NcfModificado { get; set; }
        public int? NcfAutomatico { get; set; }
        public string? MostrarConsecutivo { get; set; }
        public string? Transaccionalidad { get; set; }
        public string? ClienteAnticipo { get; set; }
        public string Bu { get; set; } = null!;
        public string BuDoc { get; set; } = null!;
        public string IdAplicacionesZeus { get; set; } = null!;
        public string IdOrigenMovimiento { get; set; } = null!;
        public int IdenArchivoasobancariaTransacciones { get; set; }
    }
}
