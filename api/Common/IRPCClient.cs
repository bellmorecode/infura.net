namespace infura.web3.Common
{
    public interface IRPCClient : IDisposable
    {
        public string APIKey { get; set; }
        public string NetworkUrl { get; set; }
        public string[] Methods { get; }

        public string APIVersion { get; set; }
    }
}
