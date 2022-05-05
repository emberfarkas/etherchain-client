using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EtherchainApi.Tests
{
    /// <summary>
    /// Tests for transactions related API methods.
    /// </summary>
    [TestClass]
    public class EtherchainApiClientTransactionsTest
    {
        private const string TestTxHash = "0xe52a49364811fbcd0004470bb68c1f0aa108cff8650ed50fcf88aba337ad7b84";

        [TestMethod]
        public async void TestGetTransaction()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetTransaction(TestTxHash);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Hash.Should().Be("0xe52a49364811fbcd0004470bb68c1f0aa108cff8650ed50fcf88aba337ad7b84");
            response.Data[0].Sender.Should().Be("0x9e0b9ddba97dd4f7addab0b5f67036eebe687606");
            response.Data[0].Recipient.Should().Be("0x37a9679c41e99db270bda88de8ff50c0cd23f326");
            response.Data[0].AccountNonce.Should().Be("355208");
            response.Data[0].Price.Should().Be(20000000000);
            response.Data[0].GasLimit.Should().Be(135000);
            response.Data[0].Amount.Should().Be(0);
            response.Data[0].BlockId.Should().Be(3320108);
            response.Data[0].Time.Should().Be("2017-03-09T11:44:35.000Z");
            response.Data[0].NewContract.Should().Be(0);
            response.Data[0].IsContractTx.Should().BeNull();
            response.Data[0].BlockHash.Should()
                .Be("0x30ff1e214f1fa6456b7fbe49ea78fa6704058f95028ff25d9793bae4e7d4eae7");
            response.Data[0].ParentHash.Should()
                .Be("0xe52a49364811fbcd0004470bb68c1f0aa108cff8650ed50fcf88aba337ad7b84");
            response.Data[0].TxIndex.Should().BeNull();
            response.Data[0].GasUsed.Should().Be(37358);
            response.Data[0].Type.Should().Be("tx");
        }

        [TestMethod]
        public async void TestGetTransactionCount()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetTransactionCount();
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Count.Should().BeGreaterOrEqualTo(19858022);
        }

        [TestMethod]
        public async void TestGetTransactions()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetTransactions(0, 50);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(50);
            response.Data.ForEach(d =>
            {
                d.Hash.Should().NotBeNullOrEmpty();
                d.Sender.Should().NotBeNullOrEmpty();
                d.Recipient.Should().NotBeNullOrEmpty();

            });
        }

    }
}