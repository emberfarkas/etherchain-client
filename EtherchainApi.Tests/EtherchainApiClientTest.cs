using EtherchainApi;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EtherchainApi.Tests
{
    [TestClass]
    public class EtherchainApiClientTest
    {
        private const string TestAddress = "0xd34da389374caad1a048fbdc4569aae33fd5a375";
        //"0x28653a6F957f0db7232A0b168D015f33ce6B124a";

        [TestMethod]
        public void TestGetAccount()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccount(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Balance.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void TestGetAccountCount()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccountCount();
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Count.Should().BeGreaterThan(100000);
        }

        [TestMethod]
        public void TestGetAccountNonce()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccountNonce(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].AccountNonce.Should().BeGreaterThan(100000);
        }

        [TestMethod]
        public void TestGetAccountSource()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccountSource(TestAddress);
            response.Status.Should().Be(1);
            //response.Data.Count.Should().Be(1);
        }

        [TestMethod]
        public void TestGetAccountTransactions()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccountTransactions(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(50);
        }

        [TestMethod]
        public void TestGetAccounts()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccounts();
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(50);
        }

        [TestMethod]
        public void TestGetMinedBlocks()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetMinedBlocks(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().BeGreaterThan(9);
        }
    }
}
