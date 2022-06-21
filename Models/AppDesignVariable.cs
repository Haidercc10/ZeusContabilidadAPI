using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppDesignVariable
    {
        public int Id { get; set; }
        public int IdEntityType { get; set; }
        public decimal? IdEntity { get; set; }
        public decimal? IdVariable { get; set; }
        public string? Title { get; set; }
        public string? ContainerName { get; set; }
        public string? GroupName { get; set; }
        public int? OrderNumber { get; set; }
        public int? DisplaceRight { get; set; }
        public int? SizeBox { get; set; }
        public bool? IsFieldMultiline { get; set; }
        public int? NumRowsMultiline { get; set; }
        public int? SizeBoxMobile { get; set; }
    }
}
