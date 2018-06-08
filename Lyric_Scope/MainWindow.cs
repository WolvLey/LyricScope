using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LyricScope.Services.Spotify;

namespace LyricScope
{
    public partial class MainWindow : Form
    {
        private Spotify spotify;
        private LyricsProvider lyricsProvider;
        private ConfigurationWindow configWindow;

        public MainWindow()
        {
            InitializeComponent();
            spotify = new Spotify();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lyricsProvider = new LyricsProvider();
            configWindow = new ConfigurationWindow();

            Play_PauseButton.Text = !spotify.Playing ? "Pause" : "Play";
        }

        private void Button_Config_Click(object sender, EventArgs e)
        {
            configWindow.ShowDialog();
        }

        private void LyricsPanel_SizeChanged(object sender, EventArgs e)
        {
            CenterLabel();
        }

        // TODO: Call async
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (spotify.Connect()) InvokeLyricSearch();

            //HandleScroll();
        }

        private void InvokeLyricSearch()
        {
            if (MainTextLabel.Text == lyricsProvider.GetLyrics(spotify))
                return;

            MainTextLabel.Text = lyricsProvider.GetLyrics(spotify);

            CenterLabel();

            CurrentSongTrackName.Text = spotify.Track;
            CurrentSongAdditonalData.Text = $@"{spotify.Interpret} | {spotify.Album}";
        }

        private void CenterLabel()
        {
            var labelSize = MainTextLabel.Size;
            var panelSize = LyricsPanel.Size;

            MainTextLabel.Location = new Point(panelSize.Width / 2 - labelSize.Width / 2, 0);
        }

//        private void HandleScroll()
//        {
//            for (var i = 0; i < 100; i++)
//            {
//                if (LyricsPanel.VerticalScroll.Value ==95) return;
//                LyricsPanel.VerticalScroll.Value += i;
//
//                Thread.Sleep(1000);
//            }
//        }

        private void SearchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                MainTextLabel.Text = lyricsProvider.GetLyrics(SearchField.Text);
                CenterLabel();
            }
        }

        private void Play_Pause(object sender, EventArgs e)
        {
            Play_PauseButton.Text = spotify.Play_Pause();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            spotify.Previous();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            spotify.Skip();
        }
    }
}