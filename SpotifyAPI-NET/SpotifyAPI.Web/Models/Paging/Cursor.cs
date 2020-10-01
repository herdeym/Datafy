using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace SpotifyAPI.Web.Models
{
    public class Cursor
    {
        [JsonProperty("after")] public string After { get; set; }

        [JsonProperty("before")] public string Before { get; set; }
    }
}