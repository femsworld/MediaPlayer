using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Core.Entity.Observer;

public class User : ISubscriber, IVideoFile, IAudioFile
{
    public void OnRecieved(string message)
    {
        throw new NotImplementedException();
    }

    public void PlayVideoFile(User user)
    {
        throw new NotImplementedException();
    }
    public void PlayVAudioFile(User user)
    {
        throw new NotImplementedException();
    }
}
