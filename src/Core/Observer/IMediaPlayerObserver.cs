namespace MediaPlayer.src.Core.Observer
{
public interface IMediaPlayerObserver
    {
        void Update(object sender, MediaPlayerEventArgs args);
    }
}