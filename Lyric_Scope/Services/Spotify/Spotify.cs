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
        private readonly SpotifyLocalAPI _spotifyAPI;

        private string _interpret;
        private string _album;
        private string _track;

        public string Interpret => _interpret;
        public string Album => _album;
        public string Track => _track;
        public bool Playing => _spotifyAPI.GetStatus().Playing;

        public Spotify()
        {
            _spotifyAPI = new SpotifyLocalAPI(new SpotifyLocalAPIConfig()) {ListenForEvents = true};

            _spotifyAPI.OnTrackChange += _spotify_OnTrackChange;
            //if (!SpotifyLocalAPI.IsSpotifyRunning()) { return; }
            //if (!SpotifyLocalAPI.IsSpotifyWebHelperRunning()) { return; }
        }

        public bool Connect()
        {
            var isConnected = _spotifyAPI.Connect();

            if (isConnected)
            {
                var status = _spotifyAPI.GetStatus();

                _interpret = status.Track.ArtistResource?.Name ?? "";
                _album = status.Track.AlbumResource?.Name ?? "";
                _track = status.Track.TrackResource?.Name ?? "";

            }

            return isConnected;
        }

        public string Play_Pause()
        {
            var playing = _spotifyAPI.GetStatus().Playing;

            if (!playing)
            {
                _spotifyAPI.Play();
                return "Pause";
            }
            else
            {
                _spotifyAPI.Pause();
                return "Play";
            }
        }

        public void Skip()
        {
            _spotifyAPI.Skip();
        }

        public void Previous()
        {
            _spotifyAPI.Previous();
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