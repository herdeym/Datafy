using System;
using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class PlaylistTrack
    {
        [JsonProperty("added_at")] public DateTime AddedAt { get; set; }

        [JsonProperty("added_by")] public PublicProfile AddedBy { get; set; }

        [JsonProperty("track")] public FullTrack Track { get; set; }

        [JsonProperty("is_local")] public bool IsLocal { get; set; }
    }
}