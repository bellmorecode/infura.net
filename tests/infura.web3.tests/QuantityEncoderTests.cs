namespace infura.web3.tests
{
    [TestClass]
    public class QuantityEncoderTests
    {
        [TestMethod]
        public void ToHex_Test()
        {
            var enc = new QuantityEncoder();
            var hex_a = enc.ToHex(0);
            Assert.AreEqual("0x0", hex_a);
            var hex_b = enc.ToHex(1);
            Assert.AreEqual("0x1", hex_b);
            var hex_c = enc.ToHex(100);
            Assert.AreEqual("0x64", hex_c);

        }
    }
}