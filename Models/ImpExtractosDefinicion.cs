using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ImpExtractosDefinicion
    {
        public ImpExtractosDefinicion()
        {
            ImpExtractosCodMovimientos = new HashSet<ImpExtractosCodMovimiento>();
            ImpExtractosDefinicionDets = new HashSet<ImpExtractosDefinicionDet>();
            ImpExtractosLogs = new HashSet<ImpExtractosLog>();
            TransacConciliacionCabeceras = new HashSet<TransacConciliacionCabecera>();
        }

        public decimal Iden { get; set; }
        public string CodigoArchivo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string? IdBanco { get; set; }
        public string? CtaBanco { get; set; }
        public int Separador { get; set; }
        public int LongitudFila { get; set; }
        public int FilaInicial { get; set; }
        public int Columnas { get; set; }
        public string OtroSeparador { get; set; } = null!;
        public int TipoLongitud { get; set; }
        public long IdenTipoArchivo { get; set; }
        public string? UsaConcilMoneda { get; set; }
        public string? IdMoneda { get; set; }

        public virtual Maecont? CtaBancoNavigation { get; set; }
        public virtual Banco? IdBancoNavigation { get; set; }
        public virtual ImpExtractoTipo IdenTipoArchivoNavigation { get; set; } = null!;
        public virtual ICollection<ImpExtractosCodMovimiento> ImpExtractosCodMovimientos { get; set; }
        public virtual ICollection<ImpExtractosDefinicionDet> ImpExtractosDefinicionDets { get; set; }
        public virtual ICollection<ImpExtractosLog> ImpExtractosLogs { get; set; }
        public virtual ICollection<TransacConciliacionCabecera> TransacConciliacionCabeceras { get; set; }
    }
}
