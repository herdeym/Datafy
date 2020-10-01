using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class Copyright
    {
        [JsonProperty("text")] public string Text { get; set; }

        [JsonProperty("type")] public string Type { get; set; }
    }
}