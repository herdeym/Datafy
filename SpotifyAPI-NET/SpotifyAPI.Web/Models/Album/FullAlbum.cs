using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyAPI.Web.Models
{
    public class FullAlbum : Album
    {
        [JsonProperty("copyrights")] public List<Copyright> Copyrights { get; set; }

        [JsonProperty("external_ids")] public Dictionary<string, string> ExternalIds { get; set; }

        [JsonProperty("genres")] public List<string> Genres { get; set; }

        [JsonProperty("label")] public string Label { get; set; }

        [JsonProperty("popularity")] public int Popularity { get; set; }

        [JsonProperty("tracks")] public Paging<SimpleTrack> Tracks { get; set; }
    }
}