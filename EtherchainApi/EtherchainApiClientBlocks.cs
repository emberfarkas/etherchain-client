using EtherchainApi.ApiResponses;
using EtherchainApi.ApiResponses.Blocks;
using Newtonsoft.Json;
using RestSharp;

namespace EtherchainApi
{
    /// <summary>
    /// Blocks related methods of Etherchain API Client
    /// </summary>
    public partial class EtherchainApiClient
    {
        /// <summary>
        /// Returns the total number of mined blocks.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlocksCount)
        /// </summary>
        /// <returns></returns>
        public GetBlocksCountResponse GetBlocksCount()
        {
            var request = new RestRequest("/blocks/count", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetBlocksCountResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns a block by its number of hash.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlockId)
        /// </summary>
        /// <param name="id">The number or hash of the block</param>
        /// <returns></returns>
        public GetBlocksByNumberOfHashResponse GetBlockByNumberOfHash(string id)
        {
            var request = new RestRequest($"/block/{id}", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetBlocksByNumberOfHashResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns the last :count blocks offset by :offset.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlocksOffsetCount)
        /// </summary>
        /// <param name="offset">The number of blocks to skip</param>
        /// <param name="count">The number of blocks to return (max 100 blocks)</param>
        /// <returns></returns>
        public GetBlocksResponse GetBlocks(int offset = 0, int count = 100)
        {
            var request = new RestRequest($"/blocks/{offset}/{count}", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetBlocksResponse>(content);
            return deserializedContent;
        }

        /// <summary>
        /// Returns all transactions of a given block.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlockIdTx)
        /// </summary>
        /// <param name="id">The number or hash of the block</param>
        /// <returns></returns>
        public GetTxForBlockResponse GetTxForBlock(string id)
        {
            var request = new RestRequest($"/block/{id}/tx", Method.GET);
            var response = _restClient.Execute(request);
            var content = response.Content; // raw content as string
            var deserializedContent = JsonConvert.DeserializeObject<GetTxForBlockResponse>(content);
            return deserializedContent;
        }
    }
}
