
// internal class Program
//     {
//         static void Main(string[] args)
//         {
//             MediaPlayerFeatures player = new MediaPlayerFeatures();

//             // Add media files to the library
//             player.AddMediaFile("song.mp3", TimeSpan.FromMinutes(3));
//             player.AddMediaFile("video.mp4", TimeSpan.FromMinutes(5));

//             // Create a playlist
//             player.AddToPlaylist("song.mp3");
//             player.AddToPlaylist("video.mp4");

//             // Play the playlist
//             player.ListPlaylist();
//             player.Play();

//             Thread.Sleep(10000); // Simulate playback for 10 seconds

//             // Add another media file to the library
//             player.AddMediaFile("audio.wav", TimeSpan.FromMinutes(2));

//             // Add the new file to the playlist
//             player.AddToPlaylist("audio.wav");

//             // Play the updated playlist
//             player.ListPlaylist();
//             player.Play();

//             Console.ReadLine();
//         }
//     }

using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Core.Factory;
using MediaPlayer.src.Core.Observer;
using MediaPlayer.src.infrastructure;

class Program
    {
        static void Main(string[] args)
        {
            // Create the media player manager instance
            var mediaPlayerManager = MediaPlayerManager.Instance;

            // Create the observers
            var exampleObserver = new ExampleObserver();

            // Subscribe the observers to the media player event
            // mediaPlayerManager.MediaPlayerEvent += exampleObserver.Update;


            // Create the audio player using the factory
            IMediaPlayerFactory audioPlayerFactory = new AudioPlayerFactory();
            IMediaPlayer audioPlayer = audioPlayerFactory.CreatePlayer();

            // Play audio
            audioPlayer.Play();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Audio playback started"));

            // Create the video player using the factory
            IMediaPlayerFactory videoPlayerFactory = new VideoPlayerFactory();
            IMediaPlayer videoPlayer = videoPlayerFactory.CreatePlayer();

            // Play video
            videoPlayer.Play();
            mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Video playback started"));

            // Other operations and interactions with the media player

            Console.ReadLine();
        }
    }