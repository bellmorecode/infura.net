using infura.web3.Common;
using System.Net.Http.Json;

namespace bc.infura.web3.Common
{

    public abstract class RPCClient : IRPCClient
    {
        public const string UnknownAPIKey = "API Key Missing";
        public const string UnknownNetwork = "unknown";
        public string[] Methods { get; protected set; } = Array.Empty<string>();
        public string NetworkUrl { get; set; } = UnknownNetwork;
        public string APIVersion { get; set; } = "v3";
        public string APIKey { get; set; } = Environment.GetEnvironmentVariable("APIKey") ?? UnknownAPIKey;

        protected abstract void Dispose();
        void IDisposable.Dispose() => Dispose();
        protected async Task<U> CallAsync<T, U>(T args) where T : RequestBodyBase, new()
                                                        where U : ResponseBodyBase, new()
        {
            if (Methods.Any(x => x == args.Method))
            {
                string url = $"https://{NetworkUrl}.infura.io/{APIVersion}/{APIKey}";
                var content = JsonContent.Create<T>(args);
                var web = new HttpClient();
                var res = await web.PostAsync(url, content);
                if (res != null)
                {
                    var responseContent = await res.Content.ReadFromJsonAsync<U>();
                    if (responseContent != null) { return responseContent; }
                }
                throw new InvalidOperationException("Something went wrong here!");
            }
            else
            {
                throw new InvalidOperationException("Unknown method");
            }
        }
    }
}
