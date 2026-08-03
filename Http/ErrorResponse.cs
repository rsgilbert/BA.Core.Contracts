using System.Text.Json.Serialization;

namespace BA.Core.Contracts.Http;


public class ErrorResponse
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }
}