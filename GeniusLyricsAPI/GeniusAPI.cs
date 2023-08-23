using GeniusLyricsAPI.Models;

namespace GeniusLyricsAPI
{
	public class GeniusAPI
	{
		private string _token;

        /// <summary>
        /// "Gateway" for requests :D
        /// </summary>
        /// <param name="token">Client access token for authorisation requests. You can take it <see href="https://genius.com/api-clients">here</see></param>
        public GeniusAPI(string token)
		{
			_token = token;
		}

		/// <summary>
		/// Make requaest to /search endpoint
		/// </summary>
		/// <param name="options">Standart <see cref="RequestOptions"/></param>
		/// <returns>Array of <see cref="Song"/>. May return null</returns>
		public async Task<List<Song>?> SearchSong(RequestOptions options)
		{
			return new List<Song>();
		}

        /// <summary>
        /// Make a request to the endpoint /search and then to /songs
        /// </summary>
        /// <param name="options">Standart <see cref="RequestOptions"/></param>
        /// <returns>Read only <see cref="Song"/></returns>
        public async Task<Song> GetSong(RequestOptions options)
		{
			return new Song();
		}

        /// <summary>
        /// Make a request to the endpoint /songs
        /// </summary>
        /// <param name="songId">Genius song id</param>
        /// <returns>Read only <see cref="Song"/></returns>
        public async Task<Song> GetSong(int songId)
		{
			return new Song();
		}

        /// <summary>
        /// Makes a request to the endpoint /songs. I would do it directly to /albums, but there is no album search.
        /// </summary>
        /// <param name="options">Standart <see cref="RequestOptions"/></param>
        /// <returns>Url of album cover</returns>
        public async Task<Uri?> GetAlbumCover(RequestOptions options)
		{
			Song song = await GetSong(options);

			if(song.Album == null)
			{
				return null;
			}
			return song.Album.CoverUri;
		}

        /// <summary>
        /// Makes a request to the endpoint /albums and takes only CoverUri from response
        /// </summary>
        /// <param name="albumId">Genius album id</param>
        /// <returns>Url of album cover</returns>
        public async Task<Uri> GetAlbumCoverUri(int albumId)
		{
            

            return new Uri("");
        }

        /// <summary>
        /// A certain amount of chthonic code
        /// </summary>
        /// <param name="options">Standart <see cref="RequestOptions"/></param>
        /// <returns>Lyrics of song</returns>
        public async Task<string> GetLyrics(RequestOptions options)
		{
			Song song = await GetSong(options);

			return await LyricsExtractor(song.Uri);
		}

        /// <summary>
        /// Some more chthonic code
        /// </summary>
        /// <param name="songUri">Genius song Uri</param>
        /// <returns>Lyrics of song</returns>
        public async Task<string> GetLyrics(Uri songUri)
		{
			return await LyricsExtractor(songUri);
		}


		private async Task<string> LyricsExtractor(Uri songUri)
		{
			return "";
		}
	}
}