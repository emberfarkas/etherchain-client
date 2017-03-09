using System;
using System.Numerics;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Transactions
{
    public class TransactionData
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
        public BigInteger Amount { get; set; }

        [JsonProperty("block_id")]
        public int BlockId { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonIgnore]
        public DateTime TimeAsDateTime => DateTime.Parse(Time);

        [JsonProperty("newContract")]
        public int NewContract { get; set; }

        [JsonProperty("isContractTx")]
        public string IsContractTx { get; set; }

        [JsonProperty("blockHash")]
        public string BlockHash { get; set; }

        [JsonProperty("parentHash")]
        public string ParentHash { get; set; }

        [JsonProperty("txIndex")]
        public string TxIndex { get; set; }

        [JsonProperty("gasUsed")]
        public int GasUsed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
