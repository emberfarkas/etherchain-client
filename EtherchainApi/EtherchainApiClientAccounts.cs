using EtherchainApi.ApiResponses;
using EtherchainApi.ApiResponses.Accounts;
using Newtonsoft.Json;
using RestSharp;

namespace EtherchainApi
{
    /// <summary>
    /// Account related methods of Etherchain API Client
    /// </summary>
    public partial class EtherchainApiClient
    {
        /// <summary>
        /// Returns an account by its address
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public async Task<GetAccountResponse?> GetAccount(string id)
        {
            var response = await _restClient.GetJsonAsync<GetAccountResponse>("/account/" + id);
            return response;
        }

        /// <summary>
        /// Returns the number of used accounts.
        /// </summary>
        /// <returns></returns>
        public async Task<GetAccountCountResponse?> GetAccountCount()
        {
            var response = await _restClient.GetJsonAsync<GetAccountCountResponse>("/accounts/count");
            return response;
        }

        /// <summary>
        /// Returns the number of transactions issued from an account.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public async Task<GetAccountNonceResponse> GetAccountNonce(string id)
        {
            var response = await _restClient.GetJsonAsync<GetAccountNonceResponse>($"/account/{id}/nonce");
            return response;
        }

        /// <summary>
        /// Returns the source of an account by its address
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public async Task<GetAccountSourceResponse> GetAccountSource(string id)
        {
            var response = await _restClient.GetJsonAsync<GetAccountSourceResponse>($"/account/{id}/source");
            return response;
        }

        /// <summary>
        /// Returns all transactions for a given account (max 50) sorted by time descending, 
        /// use the offset parameter for paging.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <param name="offset">The number of transactions to skip</param>
        /// <returns></returns>
        public async Task<GetAccountTransactionsResponse> GetAccountTransactions(string id, int offset = 0)
        {
            var response = await _restClient.GetJsonAsync<GetAccountTransactionsResponse>($"/account/{id}/tx/{offset}");
            return response;
        }

        /// <summary>
        /// Returns the last 50 accounts, sorted by balance. Use the offset parameter for paging.
        /// </summary>
        /// <param name="offset">The number of accounts to skip.</param>
        /// <returns></returns>
        public async Task<GetAccountsResponse> GetAccounts(int offset = 0)
        {
            var response = await _restClient.GetJsonAsync<GetAccountsResponse>($"/accounts/{offset}");
            return response;
        }

        /// <summary>
        /// Returns the number of blocks mined from an account.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public async Task<GetMinedBlocksResponse> GetMinedBlocks(string id)
        {
            var response = await _restClient.GetJsonAsync<GetMinedBlocksResponse>($"/account/{id}/mined");
            return response;
        }

        /// <summary>
        /// Returns the number of blocks mined per day from an account.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public async Task<GetMinedBlocksHistoryResponse> GetMinedBlocksHistory(string id)
        {
            var response = await _restClient.GetJsonAsync<GetMinedBlocksHistoryResponse>($"/account/{id}/miningHistory");
            return response;
        }

        /// <summary>
        /// Returns the number of uncles mined per day from an account.
        /// </summary>
        /// <param name="id">The address of the account</param>
        /// <returns></returns>
        public async Task<GetMinedUnclesHistoryResponse> GetMinedUnclesHistory(string id)
        {
            var response = await _restClient.GetJsonAsync<GetMinedUnclesHistoryResponse>($"/account/{id}/miningUncleHistory");
            return response;
        }

        /// <summary>
        /// Returns an account by its address
        /// </summary>
        /// <param name="ids">The address of the accounts(separated by comma)</param>
        /// <returns></returns>
        public async Task<GetMultipleAccountsResponse> GetMultipleAccounts(string ids)
        {
            var response = await _restClient.GetJsonAsync<GetMultipleAccountsResponse>($"/account/multiple/{ids}");
            return response;
        }
    }
}
