using System;
using System.Collections.Generic;

#nullable disable

namespace LogEFCoreDbFirst.Data
{
    public partial class EfmigrationsHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}
