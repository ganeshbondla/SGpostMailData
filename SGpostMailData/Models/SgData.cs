using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGpostMailData.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class SgData
    {
        public int Id { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("timestamp")]
        public int timestamp { get; set; }

        [JsonProperty("smtp-id")]
        public string SmtpId { get; set; }

        [JsonProperty("event")]
        public string @event { get; set; }

        [JsonProperty("category")]
        public List<string> category { get; set; }

        [JsonProperty("sg_event_id")]
        public string sg_event_id { get; set; }

        [JsonProperty("sg_message_id")]
        public string sg_message_id { get; set; }

        [JsonProperty("useragent")]
        public string useragent { get; set; }

        [JsonProperty("ip")]
        public string ip { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("asm_group_id")]
        public int asm_group_id { get; set; }
        public string mobile { get; set; }
        public string end_point_id { get; set; }
    }

}