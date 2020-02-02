using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace HyperPCB.Core.Enums
{

    [JsonConverter(typeof(StringEnumConverter))]

    public enum FlowEngineState
    {
        Standby,
        Running,
        Stoped,
    }
}