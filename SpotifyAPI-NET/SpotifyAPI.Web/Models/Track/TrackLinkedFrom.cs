﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class TrackLinkedFrom
    {
        [JsonProperty("external_urls")] public Dictionary<string, string> ExternalUrls { get; set; }

        [JsonProperty("href")] public string Href { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("uri")] public string Uri { get; set; }
    }
}