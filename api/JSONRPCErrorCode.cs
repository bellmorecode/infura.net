namespace bc.infura.web3
{
    public class JSONRPCErrorCode
    {
        public static Dictionary<int, JSONRPCErrorCode> ErrorCodes = new Dictionary<int, JSONRPCErrorCode>();

        static JSONRPCErrorCode()
        {
            ErrorCodes.Add(-32700, new JSONRPCErrorCode { Code = -32700, Message = "Parse error", Description = "Invalid JSON" });
            ErrorCodes.Add(-32600, new JSONRPCErrorCode { Code = -32600, Message = "Invalid request	JSON is not a valid request object" });
            ErrorCodes.Add(-32601, new JSONRPCErrorCode { Code = -32601, Message = "Method not found", Description = "Method does not exist" });
            ErrorCodes.Add(-32602, new JSONRPCErrorCode { Code = -32602, Message = "Invalid params", Description = "Invalid method parameters" });
            ErrorCodes.Add(-32603, new JSONRPCErrorCode { Code = -32603, Message = "Internal error", Description = "Internal JSON-RPC error" });
            ErrorCodes.Add(-32000, new JSONRPCErrorCode { Code = -32000, Message = "Invalid input", Description = "Missing or invalid parameters" });
            ErrorCodes.Add(-32001, new JSONRPCErrorCode { Code = -32001, Message = "Resource not found", Description = "Requested resource not found" });
            ErrorCodes.Add(-32002, new JSONRPCErrorCode { Code = -32002, Message = "Resource unavailable", Description = "Requested resource not available" });
            ErrorCodes.Add(-32003, new JSONRPCErrorCode { Code = -32003, Message = "Transaction rejected", Description = "Transaction creation failed" });
            ErrorCodes.Add(-32004, new JSONRPCErrorCode { Code = -32004, Message = "Method not supported", Description = "Method is not implemented" });
            ErrorCodes.Add(-32005, new JSONRPCErrorCode { Code = -32005, Message = "Limit exceeded", Description = "Request exceeds defined limit" });
            ErrorCodes.Add(-32006, new JSONRPCErrorCode { Code = -32006, Message = "JSON-RPC version not supported", Description = "Version of JSON-RPC protocol is not supported" });
        }

        /// <summary>
        /// Code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; } = "";

        /// <summary>
        /// Error Message description
        /// </summary>
        public string Description { get; set; } = "";
    }
}