using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyAPI.Web.Models
{
    public class SimpleAlbum : Album
    {
        [JsonProperty("album_group")] public string AlbumGroup { get; set; }
    }
}