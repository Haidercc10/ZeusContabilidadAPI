using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppLogZeu
    {
        public int Id { get; set; }
        public string CodeEvent { get; set; } = null!;
        public string IdUser { get; set; } = null!;
        public string? Login { get; set; }
        public string? Host { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string? DescriptionRtf { get; set; }
        public string? DescriptionHtml { get; set; }
    }
}
