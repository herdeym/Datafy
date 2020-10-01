using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class SavedTrack
    {
        [JsonProperty("added_at")] public DateTime AddedAt { get; set; }

        [JsonProperty("track")] public FullTrack Track { get; set; }
    }
}