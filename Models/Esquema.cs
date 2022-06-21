using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Esquema
    {
        public Esquema()
        {
            EsquemaAplicacionesZeus = new HashSet<EsquemaAplicacionesZeu>();
            EsquemaCondicionLogs = new HashSet<EsquemaCondicionLog>();
            EsquemaCondicions = new HashSet<EsquemaCondicion>();
            EsquemaDatosPlantillas = new HashSet<EsquemaDatosPlantilla>();
            EsquemaPlantillas = new HashSet<EsquemaPlantilla>();
        }

        public decimal Iden { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Deshabilitado { get; set; }
        public int Nivel { get; set; }
        public int TipoPlantilla { get; set; }
        public int? IdenPlantilla { get; set; }
        public int ValidaAplicaciones { get; set; }
        public int AplicaLibros { get; set; }

        public virtual EsquemaPlantilla? IdenPlantillaNavigation { get; set; }
        public virtual ICollection<EsquemaAplicacionesZeu> EsquemaAplicacionesZeus { get; set; }
        public virtual ICollection<EsquemaCondicionLog> EsquemaCondicionLogs { get; set; }
        public virtual ICollection<EsquemaCondicion> EsquemaCondicions { get; set; }
        public virtual ICollection<EsquemaDatosPlantilla> EsquemaDatosPlantillas { get; set; }
        public virtual ICollection<EsquemaPlantilla> EsquemaPlantillas { get; set; }
    }
}
