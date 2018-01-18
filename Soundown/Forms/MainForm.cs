using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soundown.Forms.Controls;
using Soundown.Properties;
using Soundown.SoundcloudApi;
using Soundown.SoundcloudApi.Objects;

namespace Soundown.Forms
{
    public partial class MainForm : Form
    {
        private readonly SoundcloudProvider Soundcloud;

        public MainForm()
        {
            InitializeComponent();

            Soundcloud = new SoundcloudProvider(Program.ClientId);

            if (!Directory.Exists(Program.DefaultDownloadLocation))
                Directory.CreateDirectory(Program.DefaultDownloadLocation);

            Program.DownloadLocation = Program.DefaultDownloadLocation;
        }

        private void AddTrackToList(TrackObject track)
        {
            var control = new TrackControl(track, Soundcloud);

            if (mainFlowPanel.Controls.Contains(control))
                control.Dispose();
            else 
                mainFlowPanel.Controls.Add(control);
        }

        private async Task ProcessUrl()
        {
            try
            {
                var valid = true;
                var data = await Soundcloud.Resolve(urlTextBox.Text);

                if (data.Errors != null)
                    return;

                if (data.Kind.Equals("track"))
                {
                    var track = JsonUtil.Deserialize<TrackObject>(data.RawJson);

                    AddTrackToList(track);
                }
                else if (data.Kind.Equals("playlist"))
                {
                    var playlist = JsonUtil.Deserialize<PlaylistObject>(data.RawJson);

                    foreach (var track in playlist.Tracks)
                        AddTrackToList(track);
                }
                else if (data.Kind.Equals("user"))
                {
                    var user = JsonUtil.Deserialize<UserObject>(data.RawJson);

                    var result = MessageBox.Show($"Add {user.Permalink}'s tracks?", Application.ProductName, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var tracks = await Soundcloud.GetUserTracks(user);

                        foreach (var track in tracks)
                            AddTrackToList(track);
                    }

                    result = MessageBox.Show($"Add {user.Permalink}'s playlists?", Application.ProductName, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var playlists = await Soundcloud.GetUserPlaylists(user);

                        foreach (var track in playlists.SelectMany(playlist => playlist.Tracks))
                            AddTrackToList(track);
                    }

                    result = MessageBox.Show($"Add {user.Permalink}'s likes?", Application.ProductName, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var likes = await Soundcloud.GetUserLikes(user);

                        foreach (var track in likes)
                            AddTrackToList(track);
                    }
                }
                else
                {
                    valid = false;
                }

                if (valid)
                {
                    processButton.Image = Resources.accept;
                    return;
                }
            }
            catch
            {
                // ignored
            }

            processButton.Image = Resources.cancel;
        }

        #region Events

        private async void UrlTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter)
                return;

            e.Handled = true;

            await ProcessUrl();
        }

        private async void processButton_Click(object sender, EventArgs e)
        {
            await ProcessUrl();
        }

        private void downloadAllButton_Click(object sender, EventArgs e)
        {
            foreach (var trackControl in mainFlowPanel.Controls.OfType<TrackControl>())
                trackControl.Download();
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            mainFlowPanel.Controls.Clear();
        }

        private void changeDownloadDirButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Choose a folder to save your tracks in";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                    Program.DownloadLocation = fbd.SelectedPath;
            }
        }

        #endregion
    }
}
