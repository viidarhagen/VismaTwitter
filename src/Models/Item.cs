using Microsoft.Azure.Documents;
using Newtonsoft.Json;

namespace VismaTwitter.Models
{


    public class Item
    {

        [JsonProperty(PropertyName = "_ts")]
        public double ts { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "keyPhrases")]
        public string KeyPhrases { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "sentiment")]
        public double Sentiment { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "translatedText")]
        public string TranslatedText { get; set; }

        [JsonProperty(PropertyName = "tweetedby")]
        public string TweetedBy { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public string CreatedAt { get; set; }
    }
}