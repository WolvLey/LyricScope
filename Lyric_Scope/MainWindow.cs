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


        Spotify spotify;
        LyricsProvider lyricsProvider;
        ConfigurationWindow configWindow;

        public MainWindow()
        {
            InitializeComponent();
            spotify = new Spotify();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            spotify = new Spotify();
            lyricsProvider = new LyricsProvider();
            configWindow = new ConfigurationWindow();
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
            Test();
        }

        private async void Test()
        {
            if (MainTextLabel.Text == lyricsProvider.Lyrics)
                return;

                MainTextLabel.Text = lyricsProvider.Lyrics;

                CenterLabel();
                SpotifyData.Text = $@"{spotify.Track} - {spotify.Interpret} | {spotify.Album}";
        }

        private void CenterLabel()
        {
            Size labelSize = MainTextLabel.Size;
            Size panelSize = LyricsPanel.Size;

            MainTextLabel.Location = new Point((panelSize.Width / 2) - (labelSize.Width / 2), 0);
        }
    }
}
