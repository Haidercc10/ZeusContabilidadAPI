using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class Sqlwizard
    {
        public string Descripcion { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string? Camposquery { get; set; }
        public string? Campos { get; set; }
        public string? Sortquery { get; set; }
        public string? Ordenado { get; set; }
        public string? Restricciones { get; set; }
        public string? Publico { get; set; }
        public string? Chperfil { get; set; }
        public string? Chusuario { get; set; }
        public string? Perfiles { get; set; }
        public string? Usuarios { get; set; }
        public string? Chejeperfil { get; set; }
        public string? Chmodiperfil { get; set; }
        public string? Chejeusuario { get; set; }
        public string? Chmodiusuario { get; set; }
        public string? Sql { get; set; }
        public string? Sql1 { get; set; }
        public string? IndSql1 { get; set; }
        public int IdenSqlwizard { get; set; }
    }
}
