#nullable disable
using MediaPlayer.src.Core.Observer;

namespace MediaPlayer.src.infrastructure
{  
    public sealed class MediaPlayerManager
    {
        private static readonly Lazy<MediaPlayerManager> instance = new Lazy<MediaPlayerManager>(() => new MediaPlayerManager());
        public static MediaPlayerManager Instance => instance.Value;

        private MediaPlayerManager()
        {
        }
        public event EventHandler<MediaPlayerEventArgs> MediaPlayerEvent;

        public void RaiseMediaPlayerEvent(MediaPlayerEventArgs args)
        {
            MediaPlayerEvent?.Invoke(this, args);
        }
    }

    }