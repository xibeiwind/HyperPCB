using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace HyperPCB.Core.Enums
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PinType
    {
        PinIn = 1,
        PinOut = 2
    }
}