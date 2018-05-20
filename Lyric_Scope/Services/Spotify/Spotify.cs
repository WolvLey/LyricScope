using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Local;
using SpotifyAPI.Local.Models;

using LyricScope.Services.Lyrics;



namespace LyricScope.Services.Spotify
{  

    public class Spotify
    {
        private SpotifyLocalAPI _spotifyAPI;
        private static StatusResponse status;

        private string _interpret;
        private string _album;
        private string _track;

        public string Interpret => _interpret;
        public string Album => _album;
        public string Track => _track;

        public Spotify()
        {
            _spotifyAPI = new SpotifyLocalAPI(new SpotifyLocalAPIConfig());

            _spotifyAPI.ListenForEvents = true;

            //if (!SpotifyLocalAPI.IsSpotifyRunning()) { return; }
            //if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning()) { return; }

            try
            {
                _spotifyAPI.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            status = _spotifyAPI.GetStatus();

            _interpret = status.Track.ArtistResource?.Name ?? "";
            _album = status.Track.AlbumResource?.Name ?? "";
            _track = status.Track.TrackResource?.Name ?? "";

            _spotifyAPI.OnTrackChange += _spotify_OnTrackChange;
        }

        private void _spotify_OnTrackChange(object sender, TrackChangeEventArgs e)
        {
            if (e.OldTrack != e.NewTrack)
            {
                _interpret = e.NewTrack.ArtistResource.Name;
                _album = e.NewTrack.AlbumResource.Name;
                _track = e.NewTrack.TrackResource.Name;
            }
        }

    }
}
