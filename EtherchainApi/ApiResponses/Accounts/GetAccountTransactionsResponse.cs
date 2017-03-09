using System.Collections.Generic;
using EtherchainApi.ApiResponses.Transactions;
using Newtonsoft.Json;

namespace EtherchainApi.ApiResponses.Accounts
{
    /// <summary>
    /// Response to GetAccountTransactions request (See https://etherchain.org/documentation/api/#api-Accounts-GetAccountIdTxOffset)
    /// </summary>
    public class GetAccountTransactionsResponse : EtherchainApiResponse<List<TransactionData>>
    {
    }
}
