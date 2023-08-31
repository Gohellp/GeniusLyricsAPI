using Newtonsoft.Json;

namespace GeniusLyricsAPI.Models
{
    public class SearchResults
    {
        public Meta Meta { get; set; }

        public Response Response { get; set; }
    }

    public class Meta
    {
        public int Status { get; set; }
    }

    public class Response
    {
        public List<Hit> Hits { get; set; }
    }

    public class Hit
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("result")]
        public ResultSong Song { get; set; }
    }

    public class ResultSong
    {
        [JsonProperty("artist_names")]
        public string ArtistNames { get; set; }

        public int Id { get; set; }

        [JsonProperty("release_date_for_display")]
        public string RealeaseDate { get; set; }

        [JsonProperty("song_art_image_url")]
        public Uri Cover { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        [JsonProperty("primary_artist")]
        public Artist Artist { get; set; }

        [JsonProperty("featured_artists")]
        public List<Artist> FeaturedArtists { get; set; }
    }
}
