using MediaPlayer.src.Core.Entity;

namespace MediaPlayer.src.Infrastructure
{
public class AudioPlayer : IMediaPlayer
    {
        public void Play()
        {
            // Audio player specific implementation for Play()
        }

        public void Pause()
        {
            // Audio player specific implementation for Pause()
        }

        public void Stop()
        {
            // Audio player specific implementation for Stop()
        }

        public void Seek(TimeSpan position)
        {
            // Audio player specific implementation for Seek()
        }
    }
}