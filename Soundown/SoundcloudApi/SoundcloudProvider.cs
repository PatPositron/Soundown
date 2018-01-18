using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Soundown.SoundcloudApi.Objects;

namespace Soundown.SoundcloudApi
{
    public class SoundcloudProvider : IDisposable
    {
        public string ClientId { get; }

        private readonly HttpClient MainClient;

        public SoundcloudProvider(string clientId)
        {
            ClientId = clientId;

            MainClient = new HttpClient(new HttpClientHandler
            {
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                UseCookies = false,
                UseProxy = false
            })
            {
                BaseAddress = new Uri("https://api.soundcloud.com/")
            };
        }

        public async Task<ResolveObject> Resolve(string url)
        {
            var rawJson = await MainClient.GetStringAsync($"resolve?url={url}&client_id={ClientId}");

            var resolveObject = JsonUtil.Deserialize<ResolveObject>(rawJson);

            resolveObject.RawJson = rawJson;

            return resolveObject;
        }

        public async Task<byte[]> DownloadTrack(TrackObject track)
        { 
            return await MainClient.GetByteArrayAsync($"tracks/{track.Id}/stream?client_id={ClientId}");
        }

        public async Task<Bitmap> DownloadTrackArt(TrackObject track)
        {
            if (track.ArtworkUrl == null)
                return null;

            var imageBytes = await MainClient.GetByteArrayAsync(track.ArtworkUrl.Replace("large", "t500x500"));

            return new Bitmap(new MemoryStream(imageBytes));
        }

        public async Task<TrackObject[]> GetUserTracks(UserObject user)
        {
            var rawJson = await MainClient.GetStringAsync($"users/{user.Id}/tracks?client_id={ClientId}");

            return JsonUtil.Deserialize<List<TrackObject>>(rawJson).ToArray();
        }

        public async Task<PlaylistObject[]> GetUserPlaylists(UserObject user)
        {
            var rawJson = await MainClient.GetStringAsync($"users/{user.Id}/playlists?client_id={ClientId}");

            return JsonUtil.Deserialize<List<PlaylistObject>>(rawJson).ToArray();
        }

        public async Task<TrackObject[]> GetUserLikes(UserObject user)
        {
            var rawJson = await MainClient.GetStringAsync($"users/{user.Id}/favorites?client_id={ClientId}");

            return JsonUtil.Deserialize<List<TrackObject>>(rawJson).ToArray();
        }

        public void Dispose()
        {
            MainClient.Dispose();
        }


    }
}
