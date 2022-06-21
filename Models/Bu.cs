using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Bu
    {
        public Bu()
        {
            CfactAsignaModelos = new HashSet<CfactAsignaModelo>();
            DctocajaBus = new HashSet<DctocajaBu>();
            DiasxBus = new HashSet<DiasxBu>();
            Difepars = new HashSet<Difepar>();
            DocumentRevs = new HashSet<DocumentRev>();
            Documents = new HashSet<Document>();
            Factbodies = new HashSet<Factbody>();
            FactbodyRevs = new HashSet<FactbodyRev>();
            Factclimods = new HashSet<Factclimod>();
            FactdocBodies = new HashSet<FactdocBody>();
            FactdocHeads = new HashSet<FactdocHead>();
            FactheadRevs = new HashSet<FactheadRev>();
            Factheads = new HashSet<Facthead>();
            FacturasBus = new HashSet<FacturasBu>();
            ImpuestosBus = new HashSet<ImpuestosBu>();
            Pago3rosBus = new HashSet<Pago3rosBu>();
            SaldoPropiedad1s = new HashSet<SaldoPropiedad1>();
            SaldoPropiedad2s = new HashSet<SaldoPropiedad2>();
            SaldoPropiedad3s = new HashSet<SaldoPropiedad3>();
            SaldoPropiedad4s = new HashSet<SaldoPropiedad4>();
            SaldoPropiedad5s = new HashSet<SaldoPropiedad5>();
            SaldoauxBus = new HashSet<SaldoauxBu>();
            SaldoccoBus = new HashSet<SaldoccoBu>();
            SaldoclieBus = new HashSet<SaldoclieBu>();
            SaldocontBus = new HashSet<SaldocontBu>();
            SaldoitemsBus = new HashSet<SaldoitemsBu>();
            SaldoprovBus = new HashSet<SaldoprovBu>();
            ScCobradorBus = new HashSet<ScCobradorBu>();
            SolicitudPresupuestos = new HashSet<SolicitudPresupuesto>();
            Transacs = new HashSet<Transac>();
            Usuario1s = new HashSet<Usuario1>();
            UsuariosBus = new HashSet<UsuariosBu>();
            ZwsFacturarHeads = new HashSet<ZwsFacturarHead>();
        }

        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte Habilitar { get; set; }
        public string? CuentaCompensacion { get; set; }
        public byte? NivelBu { get; set; }
        public string? DepenBu { get; set; }
        public DateTime? FecBu { get; set; }
        public int? Ncdcbu { get; set; }
        public string? TipoBu { get; set; }
        public string? CodigoReferencia { get; set; }
        public decimal? Libro { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int IdenBu { get; set; }

        public virtual Maecont? CuentaCompensacionNavigation { get; set; }
        public virtual ICollection<CfactAsignaModelo> CfactAsignaModelos { get; set; }
        public virtual ICollection<DctocajaBu> DctocajaBus { get; set; }
        public virtual ICollection<DiasxBu> DiasxBus { get; set; }
        public virtual ICollection<Difepar> Difepars { get; set; }
        public virtual ICollection<DocumentRev> DocumentRevs { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Factbody> Factbodies { get; set; }
        public virtual ICollection<FactbodyRev> FactbodyRevs { get; set; }
        public virtual ICollection<Factclimod> Factclimods { get; set; }
        public virtual ICollection<FactdocBody> FactdocBodies { get; set; }
        public virtual ICollection<FactdocHead> FactdocHeads { get; set; }
        public virtual ICollection<FactheadRev> FactheadRevs { get; set; }
        public virtual ICollection<Facthead> Factheads { get; set; }
        public virtual ICollection<FacturasBu> FacturasBus { get; set; }
        public virtual ICollection<ImpuestosBu> ImpuestosBus { get; set; }
        public virtual ICollection<Pago3rosBu> Pago3rosBus { get; set; }
        public virtual ICollection<SaldoPropiedad1> SaldoPropiedad1s { get; set; }
        public virtual ICollection<SaldoPropiedad2> SaldoPropiedad2s { get; set; }
        public virtual ICollection<SaldoPropiedad3> SaldoPropiedad3s { get; set; }
        public virtual ICollection<SaldoPropiedad4> SaldoPropiedad4s { get; set; }
        public virtual ICollection<SaldoPropiedad5> SaldoPropiedad5s { get; set; }
        public virtual ICollection<SaldoauxBu> SaldoauxBus { get; set; }
        public virtual ICollection<SaldoccoBu> SaldoccoBus { get; set; }
        public virtual ICollection<SaldoclieBu> SaldoclieBus { get; set; }
        public virtual ICollection<SaldocontBu> SaldocontBus { get; set; }
        public virtual ICollection<SaldoitemsBu> SaldoitemsBus { get; set; }
        public virtual ICollection<SaldoprovBu> SaldoprovBus { get; set; }
        public virtual ICollection<ScCobradorBu> ScCobradorBus { get; set; }
        public virtual ICollection<SolicitudPresupuesto> SolicitudPresupuestos { get; set; }
        public virtual ICollection<Transac> Transacs { get; set; }
        public virtual ICollection<Usuario1> Usuario1s { get; set; }
        public virtual ICollection<UsuariosBu> UsuariosBus { get; set; }
        public virtual ICollection<ZwsFacturarHead> ZwsFacturarHeads { get; set; }
    }
}
