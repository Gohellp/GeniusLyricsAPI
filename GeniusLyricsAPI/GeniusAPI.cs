using GeniusLyricsAPI.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace GeniusLyricsAPI
{
    public class GeniusAPI
	{
		private readonly string _token;
		private readonly string _baseUri = "https://api.genius.com";
		private HttpClient _clientApi;

		/// <summary>
		/// "Gateway" for requests :D
		/// </summary>
		/// <param name="token">Client access token for authorisation requests. You can take it <see href="https://genius.com/api-clients">here</see></param>
		public GeniusAPI(string token)
		{
			_token = token;
			_clientApi = new HttpClient()
			{
				BaseAddress = new Uri(_baseUri)
			};

		}

		/// <summary>
		/// Make requaest to /search endpoint
		/// </summary>
		/// <param name="options">Standart <see cref="RequestOptions"/></param>
		/// <returns>Response of Genius api. May return null</returns>
		public async Task<SearchResults?> SearchSong(RequestOptions options)
		{
			string query = $"/search?q={options.Artist} {options.Title}" + (options.AuthHeader ?"":$"&access_token={_token}");

			SearchResults? searchResults = null;

			using (var request = new HttpRequestMessage(HttpMethod.Get,query))
			{
				if (options.AuthHeader)
				{
					request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
				}

				var response = await _clientApi.SendAsync(request);

				if(response.IsSuccessStatusCode)
				{
					searchResults = await response.Content.ReadFromJsonAsync<SearchResults>();
				}
			}

			return searchResults;
		}

		/// <summary>
		/// Make a request to the endpoint /search and then to /songs
		/// </summary>
		/// <param name="options">Standart <see cref="RequestOptions"/></param>
		/// <returns>Read only <see cref="Song"/>. May return null</returns>
		public async Task<Song?> GetSong(RequestOptions options)
		{
			SearchResults SearchResults = await SearchSong(options);

			Song Song = await GetSong(SearchResults!.Response.Hits[0].Song.Id);

			return Song;
		}

		/// <summary>
		/// Make a request to the endpoint /songs
		/// </summary>
		/// <param name="songId">Genius song id</param>
		/// <returns>Read only <see cref="Song"/></returns>
		public async Task<Song> GetSong(int songId)
		{
			Song? Song = null;
			using (var request =  new HttpRequestMessage(HttpMethod.Get,"/songs/"+songId))
			{
                var response = await _clientApi.SendAsync(request);

				Song = await response.Content.ReadFromJsonAsync<Song>();
            }
			return Song!;
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