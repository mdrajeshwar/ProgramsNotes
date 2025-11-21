using RestSharp;
using SeleniumFramework.Utils;

namespace SeleniumFramework.Api
{
    public class SampleApiService
    {
        private readonly RestClient _client;
        public SampleApiService()
        {
            _client = new RestClient(Config.ApiBaseUrl);
        }

        public RestResponse GetSampleData()
        {
            var request = new RestRequest("/sample-endpoint", Method.Get);
            return _client.Execute(request);
        }
    }
}