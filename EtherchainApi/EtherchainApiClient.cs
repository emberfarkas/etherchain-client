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

#region Account APIs
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
            var request = new RestRequest($"/account/{id}/nonce", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountNonceResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the source of an account by its address
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public GetAccountSourceResponse GetAccountSource(string id)
        {
            var request = new RestRequest($"/account/{id}/source", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountSourceResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns all transactions for a given account (max 50) sorted by time descending, 
        /// use the offset parameter for paging.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <param name="offset">The number of transactions to skip</param>
        /// <returns></returns>
        public GetAccountTransactionsResponse GetAccountTransactions(string id, int offset = 0)
        {
            var request = new RestRequest($"/account/{id}/tx/{offset}", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountTransactionsResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the last 50 accounts, sorted by balance. Use the offset parameter for paging.
        /// </summary>
        /// <param name="offset">The number of accounts to skip.</param>
        /// <returns></returns>
        public GetAccountsResponse GetAccounts(int offset = 0)
        {
            var request = new RestRequest($"/accounts/{offset}", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetAccountsResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the number of blocks mined from an account.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public GetMinedBlocksResponse GetMinedBlocks(string id)
        {
            var request = new RestRequest($"/account/{id}/mined", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetMinedBlocksResponse>(content);
            return deserializedContent;
        }
#endregion
    }
}
