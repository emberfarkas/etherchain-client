using EtherchainApi.ApiResponses;
using Newtonsoft.Json;
using RestSharp;

namespace EtherchainApi
{
    public partial class EtherchainApiClient
    {
        const string ApiBaseUrl = "https://etherchain.org/api";
        private readonly RestClient _restClient;

        public EtherchainApiClient()
        {
            _restClient = new RestClient(ApiBaseUrl);
        }

        public EtherchainApiClient(RestClient restClient)
        {
            _restClient = restClient;
        }
    }
}
