using Newtonsoft.Json;

namespace GeniusLyricsAPI.Models
{
    public class Song
    {
        [JsonProperty("id")]
        public readonly int Id;

        [JsonProperty("primary_artist")]
        public readonly Artist PrimaryArtist;

        [JsonProperty("title")]
        public readonly string Title;

        [JsonProperty("language")]
        public readonly string LanguageCode;

        [JsonProperty("song_art_image_thumbnail_url\"")]
        public readonly Uri ThumbnailUri;

        [JsonProperty("song_art_image_url")]
        public readonly Uri CoverUri;

        [JsonProperty("url")]
        public readonly Uri Uri;

        [JsonProperty("album")]
        public readonly Album? Album = null;

        [JsonProperty("producer_artists")]
        public readonly ICollection<Artist> Produsers = new List<Artist>();

        [JsonProperty("writer_artists")]
        public readonly ICollection<Artist> Writers = new List<Artist>();

        [JsonProperty("featured_artists")]
        public readonly List<string> FeaturedArtists = new List<string>();

        [JsonProperty("media")]
        public readonly List<Media> Media = new List<Media>();

        [JsonProperty("translation_songs")]
        public readonly ICollection<Translation> Translations = new List<Translation>();

    }

    public class Album
    {

        [JsonProperty("id")]
        public readonly int Id;

        [JsonProperty("name")]
        public readonly string Name;

        [JsonProperty("cover_art_url")]
        public readonly Uri CoverUri;

        [JsonProperty("url")]
        public readonly Uri Uri;

        [JsonProperty("artist")]
        public readonly Artist Artist;

        [JsonProperty("release_date_for_display")]
        public readonly string RealeseDate; //Idk why this is string ¯\_(ツ)_/¯

    }

    public class Media
    {

        [JsonProperty("provider")]
        public readonly string Provider;

        [JsonProperty("start")]
        public readonly int Start = 0; //???

        [JsonProperty("")]
        public readonly Uri? NativeUri; //Mb only for spotify

        [JsonProperty("url")]
        public readonly Uri Uri;

        [JsonProperty("type")]
        public readonly string Type;

    }

    public class Translation
    {
        [JsonProperty("id")]
        public int Id { get; }

        [JsonProperty("language")]
        public string LanguageCode { get; }

        [JsonProperty("lyrics_state")]
        public string LyricsState { get; }

        [JsonProperty("title")]
        public string Title { get; }

        [JsonProperty("url")]
        public Uri Uri { get; }

    }
}
