using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyAPI.Web.Models
{
    public class FullTrack : SimpleTrack
    {
        [JsonProperty("album")] public SimpleAlbum Album { get; set; }

        [JsonProperty("external_ids")] public Dictionary<string, string> ExternalIds { get; set; }

        [JsonProperty("popularity")] public int Popularity { get; set; }

        /// <summary>
        ///     Only filled when the "market"-parameter was supplied!
        /// </summary>
        [JsonProperty("is_playable")]
        public bool? IsPlayable { get; set; }

        /// <summary>
        ///     Only filled when the "market"-parameter was supplied!
        /// </summary>
        [JsonProperty("linked_from")]
        public TrackLinkedFrom LinkedFrom { get; set; }
    }
}