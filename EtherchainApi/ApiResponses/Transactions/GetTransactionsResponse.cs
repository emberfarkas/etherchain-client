using System.Collections.Generic;

namespace EtherchainApi.ApiResponses.Transactions
{
    /// <summary>
    /// Response to GetTransactions request
    ///  (See https://etherchain.org/documentation/api/#api-Transactions-GetTxsOffsetCount)
    /// </summary>
    public class GetTransactionsResponse : EtherchainApiResponse<List<TransactionData>>
    {
    }
}
