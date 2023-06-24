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
            // Private constructor to prevent instantiation
        }

        // Media player event to be observed
        public event EventHandler<MediaPlayerEventArgs> MediaPlayerEvent;

        // Raise the media player event
        public void RaiseMediaPlayerEvent(MediaPlayerEventArgs args)
        {
            MediaPlayerEvent?.Invoke(this, args);
        }

        // Other methods and properties related to the media player manager
        // ...
    }

    }