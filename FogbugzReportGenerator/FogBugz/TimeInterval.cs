using Newtonsoft.Json;

namespace FogbugzReportGenerator.FogBugz
{
    public class TimeInterval
    {
        [JsonProperty("ixBug")]
        public int CaseId { get; set; }

        [JsonProperty("sTitle")]
        public string CaseTitle { get; set; }

        [JsonProperty("ixPerson")]
        public int PersonId { get; set; }

        [JsonProperty("fDeleted")]
        public bool IsDeleted { get; set; }
    }
}