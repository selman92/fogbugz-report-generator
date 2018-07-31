using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FogbugzReportGenerator.FogBugz;
using FogbugzReportGenerator.ReportGenerator;

namespace FogbugzReportGenerator
{
    public partial class MainForm : Form
    {
        private readonly IFogBugzClient _fogBugzClient;

        private readonly IReportGenerator _reportGenerator;

        private const string CurrentWeekFilter = @"assignedto:me milestonedate:""this week""";

        public MainForm()
        {
            InitializeComponent();

            _fogBugzClient = FogBugzClientFactory.Create();
            _reportGenerator = ReportGeneratorFactory.Create();

            LoadUserSettings();
        }

        private void LoadUserSettings()
        {
            TxtUserToken.Text = Properties.Settings.Default.UserToken;

            TxtExcludedWords.Text = Properties.Settings.Default.ExcludedWords;
        }

        private async void BtnVerifyClick(object sender, EventArgs e)
        {
            var trimmedToken = TxtUserToken.Text.Trim();

            var verifyResult = await Task.Run(() => _fogBugzClient.VerifyUserToken(trimmedToken));
            if (verifyResult)
            {
                _fogBugzClient.UserToken = trimmedToken;

                LblStatus.Text = "User token is successfully verified.";
            }
        }

        private async void BtnGenerateReportClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ExcludedWords))
            {
                var words = Properties.Settings.Default.ExcludedWords.Split(new[] {','},
                    StringSplitOptions.RemoveEmptyEntries).Select(_ => _.Trim()).ToArray();

                _reportGenerator.ExcludedWords = words;
            }

            if ((int)RdGroupReportType.EditValue == (int)ReportType.LastWeek)
            {
                var startDate = GetLatestMonday();
                var endDate = startDate.AddDays(7);

                var intervals = await Task.Run(() => _fogBugzClient.GetIntervals(startDate, endDate));
                
                var report = _reportGenerator.Generate(intervals);

                BrwReport.DocumentText = report;

                Clipboard.SetText(report);

                LblStatus.Text = "Report has been generated and copied to clipboard!";
            }

            if ((int)RdGroupReportType.EditValue == (int)ReportType.ThisWeek)
            {
                var cases = await Task.Run(() => _fogBugzClient.GetCases(CurrentWeekFilter));

                var report = _reportGenerator.Generate(cases);

                BrwReport.DocumentText = report;

                Clipboard.SetText(report);

                LblStatus.Text = "Report has been generated and copied to clipboard!";
            }
        }

        private void TxtUserTokenTextChanged(object sender, EventArgs e)
        {
            var trimmed = TxtUserToken.Text.Trim();
            _fogBugzClient.UserToken = trimmed;

            Properties.Settings.Default.UserToken = trimmed;
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

            return new DateTime(date.Year, date.Month, date.Day);
        }

        private void TxtExcludedWordsTextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ExcludedWords = TxtExcludedWords.Text;
        }

        private void Form1FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}