namespace GeniusLyricsAPI.Models
{

    public class RequestOptions
    {
        public RequestOptions(string _title, string _artist)
        {
            if (_title == ""&&_artist == "")
            {
                throw new ArgumentNullException("At least one of these parameters should have a value.");
            }
            Title = _title;
            Artist = _artist;
        }

        public string Title;

        public string Artist;

        /// <summary>
        /// Setting this to true will optimize the query for best results.
        /// </summary>
        public bool OptimizeQuery = false;

        /// <summary>
        /// Whether to include auth header in the search request.
        /// </summary>
        public bool AuthHeader = false;

    }
}
