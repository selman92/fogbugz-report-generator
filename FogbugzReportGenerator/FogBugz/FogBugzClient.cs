using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FogbugzReportGenerator.FogBugz
{
    public class FogBugzClient : IFogBugzClient
    {
        private const string ApiBaseUrl = "https://msltd.manuscript.com/api/";

        public string UserToken { get; set; }

        public bool VerifyUserToken(string userToken)
        {
            var arguments = new Dictionary<string, object> {{"token", userToken}};

            var url = $"{ApiBaseUrl}logon";

            var request = CreateApiRequest(url, arguments);

            var response = SendApiRequest(request);

            try
            {
                var deserialized = JObject.Parse(response);

                var token = deserialized["data"]["token"].ToString();

                return token == userToken;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<FogBugzCase> GetCases(string searchFilter)
        {
            var arguments = new Dictionary<string, object>
            {
                {"token", UserToken},
                {"q", searchFilter},
                {"cols", new[] {"ixProject", "ixPersonAssignedTo", "sTitle"}}
            };

            var url = $"{ApiBaseUrl}search";

            var request = CreateApiRequest(url, arguments);

            var response = SendApiRequest(request);

            var deserialized = JObject.Parse(response);

            if (int.Parse(deserialized["data"]["count"].ToString()) == 0)
            {
                return Enumerable.Empty<FogBugzCase>();
            }

            var casesRaw = deserialized["data"]["cases"].ToString();

            return JsonConvert.DeserializeObject<FogBugzCase[]>(casesRaw);
        }

        public IEnumerable<TimeInterval> GetIntervals(DateTime startDate, DateTime endDate)
        {
            var arguments = new Dictionary<string, object>
            {
                {"token", UserToken},
                {"dtStart", startDate},
                {"dtEnd", endDate}
            };

            var url = $"{ApiBaseUrl}listIntervals";

            var request = CreateApiRequest(url, arguments);

            var response = SendApiRequest(request);

            var deserialized = JObject.Parse(response);

            var intervalsRaw = deserialized["data"]["intervals"].ToString();

            return JsonConvert.DeserializeObject<TimeInterval[]>(intervalsRaw);
        }

        private HttpWebRequest CreateApiRequest(string url, IDictionary<string, object> arguments)
        {
            var request = WebRequest.CreateHttp(url);

            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            var serializedJson = JsonConvert.SerializeObject(arguments);

            using (var requestStream = request.GetRequestStream())
            {
                var bodyBytes = Encoding.UTF8.GetBytes(serializedJson);

                requestStream.Write(bodyBytes, 0, bodyBytes.Length);
            }

            return request;
        }

        private string SendApiRequest(HttpWebRequest request)
        {
            try
            {
                using (var response = request.GetResponse() as HttpWebResponse)
                using (var responseReader = new StreamReader(response.GetResponseStream()))
                {
                    var responseBody = responseReader.ReadToEnd();

                    return responseBody;
                }
            }
            catch (WebException ex)
            {
                // TODO: add logging
                return null;
            }
        }
    }
}
