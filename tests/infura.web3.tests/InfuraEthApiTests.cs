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
    }
}