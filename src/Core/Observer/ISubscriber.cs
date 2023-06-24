namespace MediaPlayer.src.Core.Entity.Observer
{
    public interface ISubscriber
    {
        public void OnRecieved(string message);
    }
}