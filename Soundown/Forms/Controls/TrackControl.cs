using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using HundredMilesSoftware.UltraID3Lib;
using Soundown.Properties;
using Soundown.SoundcloudApi;
using Soundown.SoundcloudApi.Objects;

namespace Soundown.Forms.Controls
{
    public partial class TrackControl : UserControl
    {
        public TrackObject Track { get; }
        private readonly SoundcloudProvider Soundcloud;
        private readonly UltraID3 Mp3Tagger;
        private readonly string DownloadPath;
        private bool Downloaded;

        public TrackControl(TrackObject track, SoundcloudProvider soundcloud)
        {
            InitializeComponent();

            Track = track;
            Soundcloud = soundcloud;
            Mp3Tagger = new UltraID3();

            DownloadPath = Path.Combine(Program.DownloadLocation, string.Concat(Track.Title, ".mp3"));

            InitializeUi();
        }

        public void Download()
        {
            downloadButton.PerformClick();
        }

        private void InitializeUi()
        {
            trackPictureBox.ImageLocation = Track.ArtworkUrl;
            trackLabel.Text = Track.Title;
            trackAuthorLabel.Text = Track.User.Username;
            downloadButton.Enabled = Track.Streamable;
            downloadButton.Text = Track.Streamable ? "Download" : "Unavailable";
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            if (!Track.Streamable)
                return;

            if (Downloaded)
            {
                Process.Start(DownloadPath);
                return;
            }

            try
            {
                downloadButton.Enabled = false;
                downloadButton.Text = "Downloading";

                var trackBytes = await Soundcloud.DownloadTrack(Track);
                var trackArt = await Soundcloud.DownloadTrackArt(Track);

                File.WriteAllBytes(DownloadPath, trackBytes);

                // ultraID3

                Mp3Tagger.Read(DownloadPath);
                Mp3Tagger.Title = Track.Title;
                Mp3Tagger.Artist = Track.User.Username;
                Mp3Tagger.Album = Program.DefaultAlbum;
                Mp3Tagger.Genre = Track.Genre;
                Mp3Tagger.ID3v2Tag.Frames.Add(new ID3v23PictureFrame {Picture = trackArt});
                Mp3Tagger.Write();

                // end

                successPictureBox.Image = Resources.accept;
                downloadButton.Enabled = true;
                downloadButton.Text = "Open";
                Downloaded = true;
            }
            catch
            {
                downloadButton.Enabled = true;
                downloadButton.Text = "Download";
                successPictureBox.Image = Resources.cancel;
            }
        }

        public override bool Equals(object obj)
        {
            var control = (TrackControl) obj;

            return Track.Id == control?.Track.Id;
        }

        public override int GetHashCode()
        {
            return Track.Id.GetHashCode();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
