using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Tipofact
    {
        public Tipofact()
        {
            FacturasVsCobroLogs = new HashSet<FacturasVsCobroLog>();
            FacturasVsCobros = new HashSet<FacturasVsCobro>();
            PagosAcarteras = new HashSet<PagosAcartera>();
            TipoFacturaRestricciones = new HashSet<TipoFacturaRestriccione>();
        }

        public string Tipofact1 { get; set; } = null!;
        public string Descrip { get; set; } = null!;
        public int Prioridad { get; set; }
        public int Deshabilitado { get; set; }
        public byte[] VersionDeLaFila { get; set; } = null!;
        public int NumefacMax { get; set; }
        public int AlfaCom { get; set; }
        public int SerieCom { get; set; }
        public string SeparadorCom { get; set; } = null!;
        public int NumefacMinCom { get; set; }
        public int AlfaVen { get; set; }
        public int SerieVen { get; set; }
        public string SeparadorVen { get; set; } = null!;
        public int NumefacMinVen { get; set; }
        public int NumefacMaxVen { get; set; }
        public int IdenTipofact { get; set; }
        public int NumSerieCompraMin { get; set; }
        public int NumSerieCompraMax { get; set; }
        public bool BlSerieAlfCompra { get; set; }
        public string ContenidoCompra { get; set; } = null!;
        public string IniciaSerieCompra { get; set; } = null!;
        public string SerieDefectoCompra { get; set; } = null!;
        public int NumSerieVentaMin { get; set; }
        public int NumSerieVentaMax { get; set; }
        public bool BlSerieAlfVenta { get; set; }
        public string ContenidoVenta { get; set; } = null!;
        public string IniciaSerieVenta { get; set; } = null!;
        public string SerieDefectoVenta { get; set; } = null!;
        public string CodigoAlterno { get; set; } = null!;
        public string DescripcionAlterna { get; set; } = null!;

        public virtual ICollection<FacturasVsCobroLog> FacturasVsCobroLogs { get; set; }
        public virtual ICollection<FacturasVsCobro> FacturasVsCobros { get; set; }
        public virtual ICollection<PagosAcartera> PagosAcarteras { get; set; }
        public virtual ICollection<TipoFacturaRestriccione> TipoFacturaRestricciones { get; set; }
    }
}
