using MediaPlayer.src.Core.Entity;

namespace MediaPlayer.src.infrastructure
{
public class VideoPlayer : IMediaPlayer
    {
        public void Play()
        {
            // Video player specific implementation for Play()
        }

        public void Pause()
        {
            // Video player specific implementation for Pause()
        }

        public void Stop()
        {
            // Video player specific implementation for Stop()
        }

        public void Seek(TimeSpan position)
        {
            // Video player specific implementation for Seek()
        }
    }
}