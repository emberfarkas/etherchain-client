using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Blocks
{
    /// <summary>
    /// Response to GetBlocksCount request
    ///  (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountMultipleIds)
    /// </summary>
    public class GetBlocksCountResponse : EtherchainApiResponse<List<GetBlocksCountResponseData>>
    {
    }

    public class GetBlocksCountResponseData
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
