using EtherchainApi;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EtherchainApi.Tests
{
    [TestClass]
    public class EtherchainApiClientTest
    {
        private const string TestAddress = "0x28653a6F957f0db7232A0b168D015f33ce6B124a";

        [TestMethod]
        public void TestGetAccount()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccount(TestAddress);
            response.Data.Count.Should().Be(1);
            response.Data[0].Balance.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void TestGetAccountCount()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetAccountCount();
            response.Data.Count.Should().Be(1);
            response.Data[0].Count.Should().BeGreaterThan(100000);
        }
    }
}
