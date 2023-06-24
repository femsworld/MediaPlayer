namespace MediaPlayer.src.Core.Observer
{
    public class MediaPlayerEventArgs
    {
        public string? EventMessage { get; internal set; }

        public MediaPlayerEventArgs(string eventMessage)
        {
            EventMessage = eventMessage;
        }
    }
}