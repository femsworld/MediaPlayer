namespace MediaPlayer.src.Core.Entity.Observer
{
public interface ISubscriber 
{
    void OnRecieved(string message);
}
}