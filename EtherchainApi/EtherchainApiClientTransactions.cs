using EtherchainApi.ApiResponses.Transactions;
using Newtonsoft.Json;
using RestSharp;

namespace EtherchainApi
{
    /// <summary>
    /// Transactions related methods of Etherchain API Client
    /// </summary>
    public partial class EtherchainApiClient
    {
        /// <summary>
        /// Returns a transaction by its hash.
        /// (See https://etherchain.org/documentation/api/#api-Transactions-GetTxId)
        /// </summary>
        /// <param name="id">The hash of the transaction.</param>
        /// <returns></returns>
        public async Task<GetTransactionResponse> GetTransaction(string id)
        {
            var response = await _restClient.GetJsonAsync<GetTransactionResponse>($"/tx/{id}");
            return response;
        }

        /// <summary>
        /// Returns the number of sent transactions.
        /// (See https://etherchain.org/documentation/api/#api-Transactions-GetTxsCount)
        /// </summary>
        /// <returns></returns>
        public async Task<GetTransactionCountResponse> GetTransactionCount()
        {
            var response = await _restClient.GetJsonAsync<GetTransactionCountResponse>($"/txs/count");
            return response;
        }

        /// <summary>
        /// Returns the last :count transactions offset by :offset
        /// (See https://etherchain.org/documentation/api/#api-Transactions-GetTxsOffsetCount)
        /// </summary>
        /// <param name="offset">The number of txs to skip</param>
        /// <param name="count">The number of txs to return (max 100)</param>
        /// <returns></returns>
        public async Task<GetTransactionsResponse> GetTransactions(int offset = 0, int count = 100)
        {
            var response = await _restClient.GetJsonAsync<GetTransactionsResponse>($"/txs/{offset}/{count}");
            return response;
        }
    }
}
