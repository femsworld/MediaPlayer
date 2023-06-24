namespace MediaPlayer.src.Core.Observer
{
public class ExampleObserver : IMediaPlayerObserver
    {
        public void Update(object sender, MediaPlayerEventArgs args)
        {
            Console.WriteLine("Received media player event: " + args.EventMessage);
        }
    }
}