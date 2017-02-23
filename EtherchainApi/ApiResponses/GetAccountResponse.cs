using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses
{
    /// <summary>
    /// Response to GetAccount request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountId)
    /// </summary>
    public class GetAccountResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("data")]
        public List<GetAccountResponseData> data { get; set; }
    }

    public class GetAccountResponseData
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("balance")]
        public long Balance { get; set; }
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("storage")]
        public string Storage { get; set; }
        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }
    }
}
