using Newtonsoft.Json;

namespace FogbugzReportGenerator.FogBugz
{
    public class FogBugzCase
    {
        [JsonProperty("ixBug")]
        public int Id { get; set; }

        [JsonProperty("sTitle")]
        public string Title { get; set; }

        [JsonProperty("ixPersonAssignedTo")]
        public int AssignedToId { get; set; }

        [JsonProperty("ixProject")]
        public int ProjectId { get; set; }
    }
}