using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyAPI.Web.Models
{
    public class SimplePlaylist : Playlist
    {
        [JsonProperty("tracks")] public SimplePlaylistTrackInfo Tracks { get; set; }
    }
}