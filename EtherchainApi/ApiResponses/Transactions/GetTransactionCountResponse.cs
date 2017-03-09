using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Transactions
{
    /// <summary>
    /// Response to GetTransactionCount request
    ///  (See https://etherchain.org/documentation/api/#api-Transactions-GetTxsCount)
    /// </summary>
    public class GetTransactionCountResponse : EtherchainApiResponse<List<GetTransactionCountResponseData>>
    {
    }

    public class GetTransactionCountResponseData
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
