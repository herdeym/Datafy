using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    /// <summary>
    /// Referred to by a user, a playlist, and an album
    /// </summary>
    public class Followers
    {
        [JsonProperty("href")] public string Href { get; set; }

        [JsonProperty("total")] public int Total { get; set; }
    }
}