using System;
using System.Windows.Forms;
using FogbugzReportGenerator.FogBugz;
using FogbugzReportGenerator.ReportGenerator;

namespace FogbugzReportGenerator
{
    public partial class Form1 : Form
    {
        private readonly IFogBugzClient _fogBugzClient;

        private readonly IReportGenerator _reportGenerator;

        private const string CurrentWeekFilter = @"assignedto:me milestonedate:""this week""";

        public Form1()
        {
            InitializeComponent();

            _fogBugzClient = FogBugzClientFactory.Create();
            _reportGenerator = ReportGeneratorFactory.Create();
        }

        private void BtnVerifyClick(object sender, EventArgs e)
        {
            var trimmedToken = TxtUserToken.Text.Trim();

            if (_fogBugzClient.VerifyUserToken(trimmedToken))
            {
                _fogBugzClient.UserToken = trimmedToken;

                LblStatus.Text = "User token is successfully verified.";
            }
        }

        private void BtnGenerateReportClick(object sender, EventArgs e)
        {
            if (RdLastWeek.Checked)
            {
                var startDate = GetLatestMonday();
                var endDate = startDate.AddDays(7);

                var intervals = _fogBugzClient.GetIntervals(startDate, endDate);
                var report = _reportGenerator.Generate(intervals);

                BrwReport.DocumentText = report;

                Clipboard.SetText(report);

                LblStatus.Text = "Report has been generated and copied to clipboard!";
            }
            else if (RdThisWeek.Checked)
            {
                var cases = _fogBugzClient.GetCases(CurrentWeekFilter);

                var report = _reportGenerator.Generate(cases);

                BrwReport.DocumentText = report;

                Clipboard.SetText(report);

                LblStatus.Text = "Report has been generated and copied to clipboard!";
            }
        }

        private void TxtUserTokenTextChanged(object sender, EventArgs e)
        {
            _fogBugzClient.UserToken = TxtUserToken.Text;
        }

        private DateTime GetLatestMonday()
        {
            var date = DateTime.Now;

            if (date.DayOfWeek == DayOfWeek.Monday)
            {
                date = date.Subtract(TimeSpan.FromDays(1));
            }

            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.Subtract(TimeSpan.FromDays(1));
            }

            return date;
        }
    }
}