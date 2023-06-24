#nullable disable
using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Core.Observer;
using System;
using System.Collections.Generic;

namespace MediaPlayer.src.infrastructure
{
    public sealed class MediaPlayerManager
    {
        private static readonly Lazy<MediaPlayerManager> instance = new Lazy<MediaPlayerManager>(() => new MediaPlayerManager());
        public static MediaPlayerManager Instance => instance.Value;

        private List<Playlist> playlists;

        private MediaPlayerManager()
        {
            playlists = new List<Playlist>();
        }

        public event EventHandler<MediaPlayerEventArgs> MediaPlayerEvent;

        public void RaiseMediaPlayerEvent(MediaPlayerEventArgs args)
        {
            MediaPlayerEvent?.Invoke(this, args);
        }

        public void AddPlaylist(Playlist playlist)
        {
            playlists.Add(playlist);
        }

        public List<Playlist> GetPlaylists()
        {
            return playlists;
        }

        public bool TryGetPlaylist(string playlistName, out Playlist playlist)
        {
            playlist = playlists.Find(p => p.PlaylistName == playlistName);
            return playlist != null;
        }
    }
}
