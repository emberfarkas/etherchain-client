using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EtherchainApi.ApiResponses;
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
    }
}
