using bc.infura.web3.Ethereum;
using System.Diagnostics;

namespace bc.infura.web3.tests
{
    [TestClass]
    public class InfuraEthMainApiTests
    {
        QuantityEncoder enc = new QuantityEncoder();
        [TestInitialize]
        public void TestInitOperations()
        {
            Environment.SetEnvironmentVariable("APIKey", "4d0508e9830f4357a6340eefaff1e6b3");
        }

        [TestMethod]
        public async Task GetCurrentChainIdMainnetTest()
        {
            var cl = new EthereumClient();
            Assert.IsTrue(cl.Methods.Any(m => m == "eth_chainId"));
            var resp = await cl.GetChainId();
            Assert.IsNotNull(resp);
            Debug.WriteLine(resp);
        }

        [TestMethod]
        public async Task GetCurrentChainIdSepoTest()
        {
            var cl = new EthereumClient("sepolia");
            Assert.IsTrue(cl.Methods.Any(m => m == "eth_chainId"));
            var resp = await cl.GetChainId();
            Assert.IsNotNull(resp);
            Debug.WriteLine(resp);

        }

        // Check gas price
        [TestMethod]
        public async Task GetGasPriceOnMainnetTest()
        {
            var cl = new EthereumClient();
            var resp = await cl.GetGasPrice();
            Assert.IsNotNull(resp);
            Debug.WriteLine(resp);
            Debug.WriteLine(enc.WeiToGwei(resp));
        }

        // Check gas price
        [TestMethod]
        public async Task GetBalanceTest()
        {
            const string acc1 = "0x297822f860890459d733E30a141F4436c8bDb5C6";
            var cl = new EthereumClient();
            var resp = await cl.GetBalance(acc1);
            Assert.IsNotNull(resp);
            Debug.WriteLine(resp);
            Debug.WriteLine(enc.WeiToGwei(resp));
        }

        [TestMethod]
        public async Task GetSepoBalanceTest()
        {
            const string acc1 = "0x06Bbe2727cb099dc769B0eD48e109Fde69dE824A";
            var cl = new EthereumClient("sepolia");
            var resp = await cl.GetBalance(acc1);
            Assert.IsNotNull(resp);
            Debug.WriteLine(resp);
            Debug.WriteLine(enc.WeiToGwei(resp));
        }
    }
}