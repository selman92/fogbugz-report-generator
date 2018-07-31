using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogbugzReportGenerator.FogBugz
{
    public interface IFogBugzClient
    {
        string UserToken { get; set; }

        bool VerifyUserToken(string userToken);

        IEnumerable<FogBugzCase> GetCases(string searchFilter);

        IEnumerable<TimeInterval> GetIntervals(DateTime startDate, DateTime endDate);
    }
}