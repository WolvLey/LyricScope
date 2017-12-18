using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpotifyAPI.Local;
using SpotifyAPI.Local.Models;

namespace LyricScope.Services.Spotify
{
    class LocalApi
    {
        private SpotifyLocalAPI _spotifyAPI;
        private static StatusResponse status;

        public LocalApi()
        {
            _spotifyAPI = new SpotifyLocalAPI(new SpotifyLocalAPIConfig());
            if (!SpotifyLocalAPI.IsSpotifyRunning()) { return; }

            if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning()) { return; }

            if (!_spotifyAPI.Connect()) { return; }
        }
    }
}
