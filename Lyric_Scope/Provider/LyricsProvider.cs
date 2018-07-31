using System;
using LyricScope.Services.Spotify;
using LyricScope.Services.Lyrics;

namespace LyricScope.Provider
{
    public class LyricsProvider
    {
        public Genius Genius { get; } = new Genius();
    }
}