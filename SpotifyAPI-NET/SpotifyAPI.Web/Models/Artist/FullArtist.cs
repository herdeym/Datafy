using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyAPI.Web.Models
{
    public class FullArtist : SimpleArtist
    {
        [JsonProperty("followers")] public Followers Followers { get; set; }

        [JsonProperty("genres")] public List<string> Genres { get; set; }

        [JsonProperty("images")] public List<Image> Images { get; set; }

        [JsonProperty("popularity")] public int Popularity { get; set; }
    }
}