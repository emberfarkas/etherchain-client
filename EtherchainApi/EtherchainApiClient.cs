using EtherchainApi.ApiResponses;
using Newtonsoft.Json;
using RestSharp;

namespace EtherchainApi
{
    public partial class EtherchainApiClient
    {
        const string ApiBaseUrl = "https://etherchain.org/api";
        private readonly IRestClient _restClient;

        public EtherchainApiClient()
        {
            _restClient = new RestClient(ApiBaseUrl);
        }

        public EtherchainApiClient(IRestClient restClient)
        {
            _restClient = restClient;
        }
    }
}
