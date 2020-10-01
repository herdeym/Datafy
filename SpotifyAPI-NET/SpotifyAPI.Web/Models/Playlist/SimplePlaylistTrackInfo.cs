using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    /// <summary>
    /// Previously PlaylistTracksCollection
    /// </summary>
    public class SimplePlaylistTrackInfo
    {
        [JsonProperty("href")] public string Href { get; set; }

        [JsonProperty("total")] public int Total { get; set; }
    }
}