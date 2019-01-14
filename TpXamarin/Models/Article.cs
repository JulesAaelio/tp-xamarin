using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TpXamarin.Models
{
    class Article
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("illustration")]
        public string IllustrationAddress { get; set; }
    }
}
