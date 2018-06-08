using System;
using LyricScope.Services.Spotify;
using LyricScope.Services.Lyrics;

namespace LyricScope.Provider
{
    public class LyricsProvider
    {
        private readonly Spotify _spotify = new Spotify();
        private readonly Genius _genius = new Genius();

        public string GetLyrics(Spotify spotify)
        {
            return _genius.GetLyrics
            (
                spotify.Interpret,
                spotify.Track
                //_spotify.Album
            );
        }

        public string GetLyrics(string interpret = "", string track = "")
        {
            if (interpret == null) throw new ArgumentNullException(nameof(interpret));
            return _genius.GetLyrics(
                interpret,
                track
            );
        }
    }
}