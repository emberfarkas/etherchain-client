using EtherchainApi.ApiResponses;
using Newtonsoft.Json;
using RestSharp;

namespace EtherchainApi
{
    public class EtherchainApiClient
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

        /// <summary>
        /// Returns an account by its address
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public GetAccountResponse GetAccount(string id)
        {
            var request = new RestRequest("/account/" + id, Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountResponse>(content);
            return deserializedContent;
        }
    }
}
