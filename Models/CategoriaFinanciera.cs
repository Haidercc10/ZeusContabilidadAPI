using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class CategoriaFinanciera
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdenCategoriafinanciera { get; set; }
    }
}
