using System;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Blocks
{
    public class BlockData
    {
        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("parentHash")]
        public string ParentHash { get; set; }

        [JsonProperty("uncleHash")]
        public string UncleHash { get; set; }

        [JsonProperty("coinbase")]
        public string CoinBase { get; set; }

        [JsonProperty("root")]
        public string Root { get; set; }
        
        [JsonProperty("txHash")]
        public string TxHash { get; set; }

        [JsonProperty("difficulty")]
        public long Difficulty { get; set; }


        [JsonProperty("gasLimit")]
        public int GasLimit { get; set; }
        
        [JsonProperty("gasUsed")]
        public int GasUsed { get; set; }
        
        [JsonProperty("time")]
        public string Time { get; set; }
        
        [JsonIgnore]
        public DateTime TimeAsDateTime => DateTime.Parse(Time);

        [JsonProperty("extra")]
        public string Extra { get; set; }


        [JsonProperty("mixDigest")]
        public string MixDigest { get; set; }


        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("tx_count")]
        public int TxCount { get; set; }

        [JsonProperty("uncle_count")]
        public int UncleCount { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("blockTime")]
        public int BlockTime { get; set; }

        [JsonProperty("reward")]
        public long Reward { get; set; }

        [JsonProperty("totalFee")]
        public long TotalFee { get; set; }

    }
}
