using System.Collections.Generic;
using FogbugzReportGenerator.FogBugz;

namespace FogbugzReportGenerator.ReportGenerator
{
    public interface IReportGenerator
    {
        string[] ExcludedWords { get; set; }

        string Generate(IEnumerable<FogBugzCase> cases);

        string Generate(IEnumerable<TimeInterval> intervals);
    }
}