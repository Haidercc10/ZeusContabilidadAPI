using System;
using System.Collections.Generic;

namespace DBInventarioZeusAPI.Models
{
    public partial class AppChat
    {
        public int Id { get; set; }
        public string IdUserEmiter { get; set; } = null!;
        public string IdUserReceiver { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime DateMsg { get; set; }
        public bool IsReaded { get; set; }
        public DateTime? DateReaded { get; set; }
        public string TypeChat { get; set; } = null!;
        public string? IdTypeChat { get; set; }
        public string? IdProfileTypeChat { get; set; }
        public int? IdGroupTypeChat { get; set; }
        public bool IsVisible { get; set; }
    }
}
