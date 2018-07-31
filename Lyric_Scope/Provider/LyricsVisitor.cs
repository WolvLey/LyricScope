using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyricScope.Services.Lyrics;
using LyricScope.Services.Spotify;

namespace LyricScope.Provider
{
    public class LyricsVisitor : ILyricsVisitor
    {
        private readonly Spotify _spotify;

        public LyricsVisitor(Spotify spotify)
        {
            _spotify = spotify;
        }

        //public string GetLyrics(string interpret = "", string track = "")
        //{
        //    if (interpret == null) throw new ArgumentNullException(nameof(interpret));
        //    return _genius.GetLyrics(
        //        interpret,
        //        track
        //    );
        //}

        public string VisitGenius(Genius genius)
        {
            return genius.GetLyrics(
                _spotify.Interpret,
                _spotify.Track
            );
        }
    }
}