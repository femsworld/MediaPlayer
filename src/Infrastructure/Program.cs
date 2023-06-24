#nullable disable
using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Core.Factory;
using MediaPlayer.src.Core.Observer;
using MediaPlayer.src.infrastructure;
using MediaPlayer.src.Infrastructure;

class Program
    {
        static void Main(string[] args)
        {
            var mediaPlayerManager = MediaPlayerManager.Instance;

            var exampleObserver = new ExampleObserver();

            // Subscribe the observer to the media player event
            mediaPlayerManager.MediaPlayerEvent += exampleObserver.Update;

            // Create the audio player
            IMediaPlayer audioPlayer = new AudioPlayer();

            // Play audio
            audioPlayer.Play();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Audio playback started"));

            // Pause audio
            audioPlayer.Pause();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Audio playback paused"));

            // Seek audio
            audioPlayer.Seek(TimeSpan.FromMinutes(2));
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Audio seeking to 2 minutes"));

            // Stop audio
            audioPlayer.Stop();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Audio playback stopped"));

            // Create the video player
            IMediaPlayer videoPlayer = new VideoPlayer();

            // Play video
            videoPlayer.Play();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Video playback started"));

            // Pause video
            videoPlayer.Pause();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Video playback paused"));

            // Seek video
            videoPlayer.Seek(TimeSpan.FromMinutes(5));
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Video seeking to 5 minutes"));

            // Stop video
            videoPlayer.Stop();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Video playback stopped"));

            Console.ReadLine();


            Console.ReadLine();
        }
    }