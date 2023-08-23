namespace GeniusLyricsAPI.Models
{
    public class Song
    {

        public readonly int Id;

        public readonly Artist PrimaryArtist;

        public readonly string Title;

        public readonly string LanguageCode;

        public readonly Uri ThumbnailUri;

        public readonly Uri Cover;

        public readonly Uri Uri;

        public readonly Album? Album = null;

        public readonly ICollection<Artist> Produsers = new List<Artist>();

        public readonly ICollection<Artist> Writers = new List<Artist>();

        public readonly List<string> FeaturedArtists = new List<string>();

        public readonly List<Media> Media = new List<Media>();

        public readonly ICollection<Translation> Translations = new List<Translation>();

    }

    public class Album
    {

        public readonly int Id;

        public readonly string Name;

        public readonly Uri CoverUri;

        public readonly Uri Uri;

        public readonly Artist Artist;

        public readonly string RealeseDate; //Idk why this is string ¯\_(ツ)_/¯

    }

    public class Media
    {

        public readonly String Provider;

        public readonly int Start = 0; //???

        public readonly Uri? NativeUri; //Mb only for spotify

        public readonly string Type;

    }

    public class Translation
    {
        public int Id { get; }

        public string LanguageCode { get; }

        public string LyricsState { get; }

        public string Title { get; }

        public Uri Uri { get; }

    }
}
