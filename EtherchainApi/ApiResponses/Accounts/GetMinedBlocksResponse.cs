using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Accounts
{
    /// <summary>
    /// Response to GetMinedBlocks request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountIdMined)
    /// </summary>

    public class GetMinedBlocksResponse : EtherchainApiResponse<List<GetMinedBlocksResponseData>>
    {
    }

    public class GetMinedBlocksResponseData
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonIgnore]
        public DateTime TimeAsDateTime => DateTime.Parse(Time);
    }
}
