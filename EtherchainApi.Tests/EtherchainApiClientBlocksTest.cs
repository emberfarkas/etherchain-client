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

        [TestMethod]
        public void TestGetBlocksCount()
        {
            var apiClient = new EtherchainApiClient();
            var response = apiClient.GetBlocksCount();
            response.Status.Should().Be(1);
            response.Data.Count.Should().Be(1);
            response.Data[0].Count.Should().BeGreaterThan(3315040);
        }
    }
}
