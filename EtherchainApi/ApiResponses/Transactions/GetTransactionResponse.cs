using System.Collections.Generic;

namespace EtherchainApi.ApiResponses.Transactions
{
    /// <summary>
    /// Response to GetTransaction request
    ///  (See https://etherchain.org/documentation/api/#api-Transactions-GetTxId)
    /// </summary>
    public class GetTransactionResponse : EtherchainApiResponse<List<TransactionData>>
    {
    }
}
