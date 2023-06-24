using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Infrastructure;

namespace MediaPlayer.src.Core.Factory
{
public class AudioPlayerFactory : IMediaPlayerFactory
    {
        public IMediaPlayer CreatePlayer()
        {
            return new AudioPlayer();
        }
    } 
}