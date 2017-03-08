﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses
{
    /// <summary>
    /// Response to GetAccountNonce request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountIdNonce)
    /// </summary>
    public class GetAccountNonceResponse : EtherchainApiResponse<List<GetAccountNonceResponseData>>
    {
    }

    public class GetAccountNonceResponseData
    {
        /// <summary>
        /// The number of transactions issued from the account.
        /// </summary>
        [JsonProperty("accountNonce")]
        public int AccountNonce { get; set; }
    }
}
