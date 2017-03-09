using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Accounts
{
    /// <summary>
    /// Response to GetMinedBlocksHistory request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountIdMininghistory)
    /// </summary>
    public class GetMinedBlocksHistoryResponse : EtherchainApiResponse<List<GetMinedBlocksHistoryResponseData>>
    {
    }

    public class GetMinedBlocksHistoryResponseData
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        public DateTime DayAsDateTime => DateTime.Parse(Day);

        [JsonProperty("minedBlocks")]
        public int MinedBlocks { get; set; }

    }
}
