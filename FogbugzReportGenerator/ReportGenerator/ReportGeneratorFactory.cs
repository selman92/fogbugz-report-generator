using System;

namespace FogbugzReportGenerator.ReportGenerator
{
    public static class ReportGeneratorFactory
    {
        public static Func<IReportGenerator> Create { get; set; } = () => new HtmlReportGenerator();
    }
}