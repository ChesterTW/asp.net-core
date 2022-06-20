using System;
using System.Collections.Generic;

#nullable disable

namespace LogEFCoreDbFirst.Data
{
    public partial class ThingsModel : BaseModel
    {
        public override int Id { get; set; }
        public override string Title { get; set; }
        public override DateTime CreateTime { get; set; }
        public override DateTime EndTime { get; set; }
    }
}
