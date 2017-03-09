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
        public GetTransactionResponse GetTransaction(string id)
        {
            var request = new RestRequest($"/tx/{id}", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetTransactionResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the number of sent transactions.
        /// (See https://etherchain.org/documentation/api/#api-Transactions-GetTxsCount)
        /// </summary>
        /// <returns></returns>
        public GetTransactionCountResponse GetTransactionCount()
        {
            var request = new RestRequest($"/txs/count", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetTransactionCountResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the last :count transactions offset by :offset
        /// (See https://etherchain.org/documentation/api/#api-Transactions-GetTxsOffsetCount)
        /// </summary>
        /// <param name="offset">The number of txs to skip</param>
        /// <param name="count">The number of txs to return (max 100)</param>
        /// <returns></returns>
        public GetTransactionsResponse GetTransactions(int offset = 0, int count = 100)
        {
            var request = new RestRequest($"/txs/{offset}/{count}", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetTransactionsResponse>(content);
            return deserializedContent;
        }
    }
}
