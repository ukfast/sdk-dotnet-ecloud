﻿using Newtonsoft.Json;

namespace UKFast.API.Client.ECloud.Models.V2.Request
{
    public class UpdateVPCRequest
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
    }
}