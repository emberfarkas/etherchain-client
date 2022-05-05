using System;
using System.Text;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EtherchainApi.Tests
{
    /// <summary>
    /// Tests for blocks related API methods.
    /// </summary>
    [TestClass]
    public class EtherchainApiClientBlocksTest
    {
        private const string TestBlockId = "3319753";

        [TestMethod]
        public async void TestGetBlocksCount()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetBlocksCount();
            response?.Status.Should().Be(1);
            response?.Data.Count.Should().Be(1);
            response?.Data[0].Count.Should().BeGreaterThan(3315040);
        }

        [TestMethod]
        public async void TestGetBlockByNumberOrHash()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetBlockByNumberOfHash(TestBlockId);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Number.Should().Be(3319753);
            response.Data[0].Hash.Should().Be("0xb4d1c6a1a3f54073df7c6f0bc4a8d5afa11ca0d8f02646cea78ee981045f7d94");
            response.Data[0].ParentHash.Should()
                .Be("0x5d91f7719f366c0275913b95c41849d891eddc7213e8fe940026a7a00b9514c4");
            response.Data[0].UncleHash.Should().Be("0x1dcc4de8dec75d7aab85b567b6ccd41ad312451b948a7413f0a142fd40d49347");
            response.Data[0].CoinBase.Should().Be("0xc0ea08a2d404d3172d2add29a45be56da40e2949");
            response.Data[0].Root.Should().Be("0x1f033fc661da53bc09e8ee0da483b9728aa55e2b4f3a012bc0f0bd291f2fdc89");
            response.Data[0].TxHash.Should().Be("0x7d6ca323c32a789b4207d536e88b88c1143aad9850e2e239172431706d4685ad");
            response.Data[0].Difficulty.Should().Be(172399265559825);
            response.Data[0].GasLimit.Should().Be(4025929);
            response.Data[0].GasUsed.Should().Be(148105);
            response.Data[0].Time.Should().Be("2017-03-09T10:16:26.000Z");
            response.Data[0].Extra.Should().Be("0x7777772e62772e636f6d");
            response.Data[0].MixDigest.Should().BeNull();
            response.Data[0].Nonce.Should().Be("0x20403c8005bdb382");
            response.Data[0].TxCount.Should().Be(3);
            response.Data[0].UncleCount.Should().Be(0);
            response.Data[0].Size.Should().Be(987);
            response.Data[0].BlockTime.Should().Be(93);
            response.Data[0].Reward.Should().Be(5006025445000000000);
            response.Data[0].TotalFee.Should().Be(6025445000000000);
        }

        [TestMethod]
        public async void TestGetBlocks()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetBlocks(0, 50);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(50);
            response.Data.ForEach(d =>
            {
                d.Number.Should().BeGreaterOrEqualTo(3319753);
                d.Hash.Should().NotBeNullOrEmpty();
                d.ParentHash.Should().NotBeNullOrEmpty();
                d.UncleHash.Should().NotBeNullOrEmpty();
                d.CoinBase.Should().NotBeNullOrEmpty();
                d.Root.Should().NotBeNullOrEmpty();
                d.TxHash.Should().NotBeNullOrEmpty();
                d.Difficulty.Should().BeGreaterThan(0);
                d.GasLimit.Should().BeGreaterThan(0);
                d.TxCount.Should().BeGreaterOrEqualTo(0);
                d.Size.Should().BeGreaterOrEqualTo(0);
                d.BlockTime.Should().BeGreaterOrEqualTo(0);
                d.Reward.Should().BeGreaterThan(0);
                d.TotalFee.Should().BeGreaterOrEqualTo(0);
            });
        }

        [TestMethod]
        public async void TestGetTxForBlock()
        {
            var apiClient = new EtherchainApiClient();
            var response = await apiClient.GetTxForBlock(TestBlockId);
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(11);
            response.Data.ForEach(d =>
            {
                d.Hash.Should().NotBeNullOrEmpty();
            });
        }
    }
}
