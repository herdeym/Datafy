using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyAPI.Web.Models
{
    public class FullPlaylist : Playlist
    {
        [JsonProperty("description")] public string Description { get; set; }


        [JsonProperty("followers")] public Followers Followers { get; set; }

        [JsonProperty("tracks")] public Paging<PlaylistTrack> Tracks { get; set; }
    }
}