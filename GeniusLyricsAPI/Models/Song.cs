using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusLyricsAPI.Models
{
    public class Song
    {

        public int Id { get; }

        public Artist Artist { get; }

        public string Title { get; }

        public string LanguageCode { get; }

        public Uri ThumbnailUri { get; }

        public Uri Cover { get; }



    }
}
