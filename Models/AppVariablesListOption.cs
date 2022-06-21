using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppVariablesListOption
    {
        public int Id { get; set; }
        public int IdVariable { get; set; }
        public string Code { get; set; } = null!;
        public string DescText { get; set; } = null!;
    }
}
