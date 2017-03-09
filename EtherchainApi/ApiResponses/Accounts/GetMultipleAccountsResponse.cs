using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Accounts
{
    /// <summary>
    /// Response to GetMultipleAccounts request
    ///  (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountMultipleIds)
    /// </summary>
    public class GetMultipleAccountsResponse : EtherchainApiResponse<List<GetMultipleAccountsResponseData>>
    {
    }

    public class GetMultipleAccountsResponseData
    {
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("balance")]
        public decimal Balance { get; set; }
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
