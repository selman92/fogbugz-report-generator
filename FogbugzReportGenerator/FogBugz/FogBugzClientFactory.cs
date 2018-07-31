using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogbugzReportGenerator.FogBugz
{
    public static class FogBugzClientFactory
    {
        public static Func<IFogBugzClient> Create { get; set; } = () => new FogBugzClient();
    }
}
