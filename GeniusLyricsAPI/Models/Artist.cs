using Newtonsoft.Json;

namespace GeniusLyricsAPI.Models
{
    public class Artist
    {
        [JsonProperty("id")]
        public readonly int Id;

        [JsonProperty("name")]
        public readonly string Name;

        [JsonProperty("header_image_url")]
        public readonly string HeaderImageUri;

        [JsonProperty("image_url")]
        public readonly string ImageUri;

        [JsonProperty("url")]
        public readonly string Url;

        [JsonProperty("is_verified")]
        public readonly bool IsVerifided;

        [JsonProperty("is_meme_verified")]
        public readonly bool IsMemeVerifided;

    }
}
