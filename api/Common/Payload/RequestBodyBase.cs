using System.Text.Json.Serialization;

namespace infura.web3.Common
{
    public abstract class RequestBodyBase {
        [JsonPropertyName("jsonrpc")]
        public virtual string JsonRPCVersion { get; set; } = "2.0";
        [JsonPropertyName("method")]
        public virtual string Method { get; set; } = "";
        [JsonPropertyName("params")]
        public virtual string[] Arguments { get; set; } = new string[0];
        [JsonPropertyName("id")]
        public virtual int Id { get; set; } = 1;
    }
}
