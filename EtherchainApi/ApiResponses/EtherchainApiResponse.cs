using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses
{
    /// <summary>
    /// Generic format of Etherchain Api Response.
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    public class EtherchainApiResponse<T>
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
