﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class Image
    {
        [JsonProperty("url")] public string Url { get; set; }

        [JsonProperty("width")] public int Width { get; set; }

        [JsonProperty("height")] public int Height { get; set; }
    }
}