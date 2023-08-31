# GeniusLyricsAPI

Spotify to Youtube module that converts (searches for) a Spotify link into a Youtube link


## Features
- Gets track info
- Search some track in Genius
- Gets track's lyrics
- Gets album's cover link

## Install a package
1. Open a command line and switch to the directory that contains your project file.

1. Use the following command to install a NuGet package:

	```powershell
	dotnet add package GeniusLyricsAPI
	```

1. After the command completes, you can open the project file to see the package reference.

   For example, open the *.csproj* file to see the added `GeniusLyricsAPI` package reference:

	```xml
	<ItemGroup>
	  <PackageReference Include="GeniusLyricsAPI" Version="1.0.0" />
	</ItemGroup>
	```

## Usage
```csharp
using GeniusLyricsAPI;
using GeniusLyricsApi.Models;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            new Program().Run().Wait();
        }
        catch (AggregateException ex)
        {
            foreach (var e in ex.InnerExceptions)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }

    private async Task Run()
	{
	    var genius = new GeniusApi("REPLACE_ME_GeniusToken");
	    
	    Song song = await genius.GetSong("8594139");
	    
	    string Lyrics = await genius.GetLyrics(song.Uri);
	    
	    Console.Write(Lyrics);
    }
}
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## Thanks
Thank you very much [farshed](https://github.com/farshed) for writing a similar library for JavaScript. If it wasn't for the [genius-lyrics-api](https://github.com/farshed/genius-lyrics-api), I wouldn't have come up with the idea of rewriting it in C# and wouldn't have written a bot for Telegram :D


## License

[MIT](https://choosealicense.com/licenses/mit/)