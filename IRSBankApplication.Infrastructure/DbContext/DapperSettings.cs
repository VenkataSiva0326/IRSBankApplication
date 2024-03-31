using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSBankApplication.Infrastructure.DbContext
{
    public class DapperSettings
    {
        public const string SectionName = "ConnectionStrings";

        public string SqlServer { get; set; } = null!;
    }
}
