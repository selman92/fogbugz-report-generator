using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FogbugzReportGenerator.FogBugz;

namespace FogbugzReportGenerator.ReportGenerator
{
    public interface IReportGenerator
    {
        string Generate(IEnumerable<FogBugzCase> cases);

        string Generate(IEnumerable<TimeInterval> intervals);
    }
}