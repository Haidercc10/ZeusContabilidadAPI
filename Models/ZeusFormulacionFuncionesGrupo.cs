using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class ZeusFormulacionFuncionesGrupo
    {
        public string Funcion { get; set; } = null!;
        public string Grupo { get; set; } = null!;
        public int IdenZeusformulacionfuncionesgrupos { get; set; }

        public virtual ZeusFormulacionFuncione FuncionNavigation { get; set; } = null!;
        public virtual ZeusFormulacionGrupo GrupoNavigation { get; set; } = null!;
    }
}
