using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDbFirst.Data.ModelsDB
{
    public partial class ThingsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
