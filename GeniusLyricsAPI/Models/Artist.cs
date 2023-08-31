using Newtonsoft.Json;

namespace GeniusLyricsAPI.Models
{
    public class Artist
    {
        [JsonProperty(PropertyName = "id")]
        public readonly int Id;

        [JsonProperty("name")]
        public readonly string Name;

        [JsonProperty("header_image_url")]
        public readonly Uri HeaderImageUri;

        [JsonProperty("image_url")]
        public readonly Uri ImageUri;

        [JsonProperty("url")]
        public readonly Uri Url;

    }
}
