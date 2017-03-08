using System.Collections.Generic;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses
{
    /// <summary>
    /// Response to GetAccountTransactions request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountIdTxOffset)
    /// </summary>
    public class GetAccountTransactionsResponse : EtherchainApiResponse<List<GetAccountTransactionsResponseData>>
    {
    }

    public class GetAccountTransactionsResponseData
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
        
        [JsonProperty("accountNonce")]
        public string AccountNonce { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("gasLimit")]
        public int GasLimit { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("block_id")]
        public int BlockId { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("newContract")]
        public int NewContract { get; set; }

        [JsonProperty("isContractTx")]
        public string IsContractTx { get; set; }

        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }

        [JsonProperty("parentHash")]
        public string ParentHash { get; set; }

        [JsonProperty("txIndex")]
        public int? TxIndex { get; set; }

        [JsonProperty("gasUsed")]
        public int GasUsed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
