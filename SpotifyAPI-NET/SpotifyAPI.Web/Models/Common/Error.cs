using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class Error
    {
        [JsonProperty("status")] public int Status { get; set; }

        [JsonProperty("message")] public string Message { get; set; }
    }
}