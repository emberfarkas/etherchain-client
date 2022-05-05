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
        public async Task<GetBlocksCountResponse?> GetBlocksCount()
        {
            var response = await _restClient.GetJsonAsync<GetBlocksCountResponse>("/blocks/count");
            return response;
        }

        /// <summary>
        /// Returns a block by its number of hash.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlockId)
        /// </summary>
        /// <param name="id">The number or hash of the block</param>
        /// <returns></returns>
        public async Task<GetBlocksByNumberOfHashResponse> GetBlockByNumberOfHash(string id)
        {
            var response = await _restClient.GetJsonAsync<GetBlocksByNumberOfHashResponse>($"/block/{id}");
            return response;
        }

        /// <summary>
        /// Returns the last :count blocks offset by :offset.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlocksOffsetCount)
        /// </summary>
        /// <param name="offset">The number of blocks to skip</param>
        /// <param name="count">The number of blocks to return (max 100 blocks)</param>
        /// <returns></returns>
        public async Task<GetBlocksResponse> GetBlocks(int offset = 0, int count = 100)
        {
            var response = await _restClient.GetJsonAsync<GetBlocksResponse>($"/blocks/{offset}/{count}");
            return response;
        }

        /// <summary>
        /// Returns all transactions of a given block.
        /// (See https://etherchain.org/documentation/api/#api-Blocks-GetBlockIdTx)
        /// </summary>
        /// <param name="id">The number or hash of the block</param>
        /// <returns></returns>
        public async Task<GetTxForBlockResponse> GetTxForBlock(string id)
        {
            var response = await _restClient.GetJsonAsync<GetTxForBlockResponse>($"/block/{id}/tx");
            return response;
        }
    }
}
