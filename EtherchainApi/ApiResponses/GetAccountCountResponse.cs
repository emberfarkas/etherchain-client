using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses
{
    /// <summary>
    /// Response to GetAccountCount request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountsCount)
    /// </summary>
    public class GetAccountCountResponse : EtherchainApiResponse<List<GetAccountCountResponseData>>
    {
    }

    public class GetAccountCountResponseData
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}

