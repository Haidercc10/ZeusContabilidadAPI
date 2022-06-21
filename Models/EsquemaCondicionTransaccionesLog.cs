using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class EsquemaCondicionTransaccionesLog
    {
        public EsquemaCondicionTransaccionesLog()
        {
            Transacs = new HashSet<Transac>();
        }

        public decimal Iden { get; set; }
        public decimal? EsquemaCondicion { get; set; }
        public string? Anotra { get; set; }
        public string? TipoAnotra { get; set; }
        public string? Idfuente { get; set; }
        public string? TipoIdFuente { get; set; }
        public string? Numdoctra { get; set; }
        public string? TipoNumdoctra { get; set; }
        public string? Fechatra { get; set; }
        public string? TipoFechatra { get; set; }
        public string? Codicta { get; set; }
        public string? TipoCodicta { get; set; }
        public string? Nittra { get; set; }
        public string? TipoNittra { get; set; }
        public string? Auxiaux { get; set; }
        public string? TipoAuxiAux { get; set; }
        public string? Idcenco { get; set; }
        public string? TipoIdCenco { get; set; }
        public string? Iditem { get; set; }
        public string? TipoIdItem { get; set; }
        public string? Descritra { get; set; }
        public string? TipoDescritra { get; set; }
        public decimal? Valortra { get; set; }
        public string? TipoValortra { get; set; }
        public string? Conciltra { get; set; }
        public string? TipoConciltra { get; set; }
        public string? Idbanco { get; set; }
        public string? TipoIdBanco { get; set; }
        public string? Idvende { get; set; }
        public string? TipoIdvende { get; set; }
        public string? Idplaza { get; set; }
        public string? TipoIdplaza { get; set; }
        public string? Tipofac { get; set; }
        public string? TipoTipofac { get; set; }
        public string? Numefac { get; set; }
        public string? TipoNumefac { get; set; }
        public string? Vencefac { get; set; }
        public string? TipoVencefac { get; set; }
        public string? Refefac { get; set; }
        public string? TipoRefefac { get; set; }
        public string? Idzona { get; set; }
        public string? TipoIdzona { get; set; }
        public string? Cliprv { get; set; }
        public string? TipoCliprv { get; set; }
        public decimal? Porretetra { get; set; }
        public string? TipoPorretetra { get; set; }
        public decimal? Baseretetra { get; set; }
        public string? TipoBaseretetra { get; set; }
        public string? Codpresu { get; set; }
        public string? TipoCodpresu { get; set; }
        public string? Nreserva { get; set; }
        public string? TipoNreserva { get; set; }
        public decimal? Valormoneda { get; set; }
        public string? TipoValormoneda { get; set; }
        public string? Idunidad1 { get; set; }
        public string? TipoIdunidad1 { get; set; }
        public string? Idunidad2 { get; set; }
        public string? TipoIdunidad2 { get; set; }
        public string? Idunidad3 { get; set; }
        public string? TipoIdunidad3 { get; set; }
        public decimal? Valorutra1 { get; set; }
        public string? TipoValorutra1 { get; set; }
        public decimal? Valorutra2 { get; set; }
        public string? TipoValorutra2 { get; set; }
        public decimal? Valorutra3 { get; set; }
        public string? TipoValorutra3 { get; set; }
        public string? Serie { get; set; }
        public string? TipoSerie { get; set; }
        public string? Autorizacion { get; set; }
        public string? TipoAutorizacion { get; set; }
        public string? Fechafact { get; set; }
        public string? TipoFechafact { get; set; }
        public string? Adicional1 { get; set; }
        public string? TipoAdicional1 { get; set; }
        public string? Adicional2 { get; set; }
        public string? TipoAdicional2 { get; set; }
        public string? Voucher { get; set; }
        public string? TipoVoucher { get; set; }
        public decimal? Tasacambio { get; set; }
        public string? TipoTasacambio { get; set; }
        public string? Bu { get; set; }
        public string? TipoBu { get; set; }
        public string? Ncf { get; set; }
        public string? TipoNcf { get; set; }
        public string? NcfModificado { get; set; }
        public string? TipoNcfModificado { get; set; }
        public string? TipoPropiedad1 { get; set; }
        public string? Propiedad1 { get; set; }
        public string? TipoPropiedad2 { get; set; }
        public string? Propiedad2 { get; set; }
        public string? TipoPropiedad3 { get; set; }
        public string? Propiedad3 { get; set; }
        public string? TipoPropiedad4 { get; set; }
        public string? Propiedad4 { get; set; }
        public string? TipoPropiedad5 { get; set; }
        public string? Propiedad5 { get; set; }
        public string? FormulaCodicta { get; set; }
        public string? FormulaNittra { get; set; }
        public string? FormulaAuxiaux { get; set; }
        public string? FormulaIdcenco { get; set; }
        public string? FormulaIditem { get; set; }
        public string? FormulaDescritra { get; set; }
        public string? FormulaValortra { get; set; }
        public string? FormulaConciltra { get; set; }
        public string? FormulaIdbanco { get; set; }
        public string? FormulaIdvende { get; set; }
        public string? FormulaIdplaza { get; set; }
        public string? FormulaTipofac { get; set; }
        public string? FormulaNumefac { get; set; }
        public string? FormulaVencefac { get; set; }
        public string? FormulaRefefac { get; set; }
        public string? FormulaIdzona { get; set; }
        public string? FormulaCliprv { get; set; }
        public string? FormulaPorretetra { get; set; }
        public string? FormulaBaseretetra { get; set; }
        public string? FormulaCodpresu { get; set; }
        public string? FormulaNreserva { get; set; }
        public string? FormulaValormoneda { get; set; }
        public string? FormulaIdunidad1 { get; set; }
        public string? FormulaIdunidad2 { get; set; }
        public string? FormulaIdunidad3 { get; set; }
        public string? FormulaValorutra1 { get; set; }
        public string? FormulaValorutra2 { get; set; }
        public string? FormulaValorutra3 { get; set; }
        public string? FormulaSerie { get; set; }
        public string? FormulaAutorizacion { get; set; }
        public string? FormulaFechafact { get; set; }
        public string? FormulaAdicional1 { get; set; }
        public string? FormulaAdicional2 { get; set; }
        public string? FormulaVoucher { get; set; }
        public string? FormulaTasacambio { get; set; }
        public string? FormulaBu { get; set; }
        public string? FormulaNcf { get; set; }
        public string? FormulaNcfModificado { get; set; }
        public string? FormulaPropiedad1 { get; set; }
        public string? FormulaPropiedad2 { get; set; }
        public string? FormulaPropiedad3 { get; set; }
        public string? FormulaPropiedad4 { get; set; }
        public string? FormulaPropiedad5 { get; set; }
        public decimal? IdenLibroBu { get; set; }
        public int IdenEsquemaCondicionTransaccionesLog { get; set; }

        public virtual EsquemaCondicionLog? EsquemaCondicionNavigation { get; set; }
        public virtual ICollection<Transac> Transacs { get; set; }
    }
}
