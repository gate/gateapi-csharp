using Io.Gate.GateApi.Client;

namespace GateApiDemo
{
    // Keep all public examples on the SDK's canonical credential setter.
    internal static class ExampleAuth
    {
        internal static Configuration Create(RunConfig config)
        {
            var result = new Configuration { BasePath = config.HostUsed };
            result.SetGateApiV4KeyPair(config.ApiKey, config.ApiSecret);
            return result;
        }
    }
}
