using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppSearcherField
    {
        public int Id { get; set; }
        public int IdBuscador { get; set; }
        public string FieldName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int IdDataType { get; set; }
        public int? OrderShow { get; set; }

        public virtual AppSearcher IdBuscadorNavigation { get; set; } = null!;
    }
}
