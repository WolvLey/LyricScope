using System;
using LyricScope.Services.Spotify;
using LyricScope.Services.Lyrics;

namespace LyricScope
{
    class LyricsProvider
    {
        private Spotify _spotify = new Spotify();
        private Genius _genius = new Genius();

        public string GetLyrics()
        {
            return _genius.GetLyrics
                (
                    _spotify.Interpret,
                    _spotify.Track
                //_spotify.Album
                );
        }

        public string GetLyrics(string interpret="", string track ="")
        {
            return _genius.GetLyrics(
                    interpret,
                    track
                );
        }
    }
}
