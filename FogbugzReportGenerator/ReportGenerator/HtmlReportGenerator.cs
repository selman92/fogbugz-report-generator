using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FogbugzReportGenerator.FogBugz;

namespace FogbugzReportGenerator.ReportGenerator
{
    public class HtmlReportGenerator : IReportGenerator
    {
        private const string CasesBaseUri = "https://msltd.fogbugz.com/f/cases/";

        public string Generate(IEnumerable<FogBugzCase> cases)
        {
            var builder = new StringBuilder();

            foreach (var fbCase in cases)
            {
                builder.Append($"<a href=\"{CasesBaseUri}{fbCase.Id}\">#{fbCase.Id}</a> - ");
                builder.Append(fbCase.Title);
                builder.Append("<br />");
            }

            return builder.ToString();
        }

        public string Generate(IEnumerable<TimeInterval> intervals)
        {
            var builder = new StringBuilder();

            foreach (var interval in intervals.GroupBy(_ => _.CaseId).Select(_ => _.First()))
            {
                builder.Append($"<a href=\"{CasesBaseUri}{interval.CaseId}\">#{interval.CaseId}</a> - ");
                builder.Append(interval.CaseTitle);
                builder.Append("<br />");
            }

            return builder.ToString();
        }
    }
}
