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
            response.data.Count.Should().Be(1);
            response.data[0].Balance.Should().BeGreaterThan(0);
        }
    }
}
