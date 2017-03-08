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

        /// <summary>
        /// Returns the number of used accounts.
        /// </summary>
        /// <returns></returns>
        public GetAccountCountResponse GetAccountCount()
        {
            var request = new RestRequest("/accounts/count", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountCountResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the number of transactions issued from an account.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public GetAccountNonceResponse GetAccountNonce(string id)
        {
            var request = new RestRequest("/account/" + id + "/nonce", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountNonceResponse>(content);
            return deserializedContent;
        }
    }
}
