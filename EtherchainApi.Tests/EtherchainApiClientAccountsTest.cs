using EtherchainApi;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EtherchainApi.Tests
{
    /// <summary>
    /// Tests for accounts related API methods.
    /// </summary>
    [TestClass]
    public class EtherchainApiClientAccountsTest
    {
        private const string TestAddress = "0xd34da389374caad1a048fbdc4569aae33fd5a375";
        private const string TestAddresses = "0xd34da389374caad1a048fbdc4569aae33fd5a375,0x28653a6F957f0db7232A0b168D015f33ce6B124a";

        [TestMethod]
        public async void TestGetAccount()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetAccount(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Balance.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public async void TestGetAccountCount()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetAccountCount();
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Count.Should().BeGreaterThan(100000);
        }

        [TestMethod]
        public async void TestGetAccountNonce()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetAccountNonce(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].AccountNonce.Should().BeGreaterThan(100000);
        }

        [TestMethod]
        public async void TestGetAccountSource()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetAccountSource(TestAddress);
            response.Status.Should().Be(1);
            //response.Data.Count.Should().Be(1);
        }

        [TestMethod]
        public async void TestGetAccountTransactions()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetAccountTransactions(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(50);
        }

        [TestMethod]
        public async void TestGetAccounts()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetAccounts();
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(50);
        }

        [TestMethod]
        public async void TestGetMinedBlocks()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetMinedBlocks(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().BeGreaterThan(9);
            response.Data.ForEach(d =>
            {
                d.Number.Should().BePositive();
                d.Time.Should().NotBeNullOrEmpty();
            });
        }

        [TestMethod]
        public async void TestGetMinedBlocksHistory()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetMinedBlocksHistory(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().BeGreaterThan(10);
            response.Data.ForEach(d => {
                d.Day.Should().NotBeNullOrEmpty();
                d.MinedBlocks.Should().BePositive();
            });
        }

        [TestMethod]
        public async void TestGetMinedUnclesHistory()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetMinedUnclesHistory(TestAddress);
            response.Status.Should().Be(1);
            response.Data.Count.Should().BeGreaterThan(10);
            response.Data.ForEach(d =>
                {
                    d.Day.Should().NotBeNullOrEmpty();
                    d.MinedUncles.Should().BePositive();
                });
        }

        [TestMethod]
        public async void TestGetMultipleAccounts()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetMultipleAccounts(TestAddresses);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(2);
            response.Data.ForEach(d =>
            {
                d.Address.Should().NotBeNullOrEmpty();
                d.Balance.Should().BePositive();
                d.Code.Should().Be("0x");
            });
            
        }
    }
}
