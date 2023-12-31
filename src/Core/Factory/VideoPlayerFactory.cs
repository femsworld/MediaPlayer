using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.infrastructure;
using MediaPlayer.src.Infrastructure;

namespace MediaPlayer.src.Core.Factory
{
public class VideoPlayerFactory : IMediaPlayerFactory
    {
        public IMediaPlayer CreatePlayer()
        {
            return new VideoPlayer();
        }
    }
}