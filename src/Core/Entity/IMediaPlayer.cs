namespace MediaPlayer.src.Core.Entity
{
    public interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void Seek(TimeSpan position);
    }
}