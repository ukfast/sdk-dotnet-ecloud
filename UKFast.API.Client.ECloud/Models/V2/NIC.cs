﻿using Newtonsoft.Json;
using System;
using UKFast.API.Client.Json;
using UKFast.API.Client.Models;

namespace UKFast.API.Client.ECloud.Models.V2
{
    public class NIC : ModelBase
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("mac_address")]
        public string MACAddress { get; set; }

        [JsonProperty("instance_id")]
        public string InstanceID { get; set; }

        [JsonProperty("network_id")]
        public string NetworkID { get; set; }

        [JsonProperty("ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty("created_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}