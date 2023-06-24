using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Core.Entity.Observer;
using MediaPlayer.src.Core.Observer;

namespace MediaPlayer.src.Core.Entity
{
public class User : ISubscriber, IVideoFile, IAudioFile, IMediaPlayerObserver
{   
    public void Update(MediaPlayerEventArgs args)
        {
            Console.WriteLine("Received media player event: " + args.EventMessage);
        }
    public void OnRecieved(string message)
    {
        throw new NotImplementedException();
    }

    public void PlayVideoFile(User user)
    {
        Console.WriteLine("VideoFile");;
    }
    public void PlayVAudioFile(User user)
    {
        Console.WriteLine("AudioFile");
    }
}
}
