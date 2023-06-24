#nullable disable
using MediaPlayer.src.Core.Entity;
using MediaPlayer.src.Core.Observer;
using MediaPlayer.src.infrastructure;
using MediaPlayer.src.Infrastructure;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the media player manager instance
        MediaPlayerManager mediaPlayerManager = MediaPlayerManager.Instance;

        // Create a playlist
        Playlist playlist1 = new Playlist("Playlist 1");
        playlist1.AddMediaFile("audio1.mp3");
        playlist1.AddMediaFile("video1.mp4");
        mediaPlayerManager.AddPlaylist(playlist1);

        Playlist playlist2 = new Playlist("Playlist 2");
        playlist2.AddMediaFile("audio2.mp3");
        playlist2.AddMediaFile("video2.mp4");
        mediaPlayerManager.AddPlaylist(playlist2);

        // Create the observer
        var exampleObserver = new ExampleObserver();

        // Subscribe the observer to the media player event
        mediaPlayerManager.MediaPlayerEvent += exampleObserver.Update;

        // Display menu and handle user input
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("===== Media Player Application =====");
            Console.WriteLine("1. Play Audio");
            Console.WriteLine("2. Play Video");
            Console.WriteLine("3. Seek");
            Console.WriteLine("4. Stop");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===================================");

            Console.Write("Enter your choice: ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case '1':
                    // Play audio
                    Console.WriteLine("Available playlists:");
                    // Display available playlists and let the user select one
                    foreach (var playlist in mediaPlayerManager.GetPlaylists())
                    {
                        Console.WriteLine($"- {playlist.PlaylistName}");
                    }

                    Console.Write("Select a playlist: ");
                    string selectedPlaylistName = Console.ReadLine();

                    if (mediaPlayerManager.TryGetPlaylist(selectedPlaylistName, out Playlist selectedPlaylist))
                    {
                        Console.WriteLine("Available audio files in the playlist:");
                        // Display available audio files in the selected playlist
                        foreach (var audioFile in selectedPlaylist.GetMediaFiles())
                        {
                            Console.WriteLine($"- {audioFile}");
                        }

                        Console.Write("Select an audio file to play: ");
                        string selectedAudioFile = Console.ReadLine();

                        // Play the selected audio file
                        selectedPlaylist.PlayAudioFile(selectedAudioFile, mediaPlayerManager);
                    }
                    else
                    {
                        Console.WriteLine("Invalid playlist selection.");
                    }
                    break;

                case '2':
                    // Play video
                    Console.WriteLine("Available playlists:");
                    // Display available playlists and let the user select one
                    foreach (var playlist in mediaPlayerManager.GetPlaylists())
                    {
                        Console.WriteLine($"- {playlist.PlaylistName}");
                    }

                    Console.Write("Select a playlist: ");
                    selectedPlaylistName = Console.ReadLine();

                    if (mediaPlayerManager.TryGetPlaylist(selectedPlaylistName, out selectedPlaylist))
                    {
                        Console.WriteLine("Available video files in the playlist:");
                        // Display available video files in the selected playlist
                        foreach (var videoFile in selectedPlaylist.GetMediaFiles())
                        {
                            Console.WriteLine($"- {videoFile}");
                        }

                        Console.Write("Select a video file to play: ");
                        string selectedVideoFile = Console.ReadLine();

                        // Play the selected video file
                        selectedPlaylist.PlayVideoFile(selectedVideoFile, mediaPlayerManager);
                    }
                    else
                    {
                        Console.WriteLine("Invalid playlist selection.");
                    }
                    break;

                case '3':
                    // Seek
                    Console.Write("Enter the seek position (in seconds): ");
                    if (int.TryParse(Console.ReadLine(), out int seekPosition))
                    {
                        TimeSpan position = TimeSpan.FromSeconds(seekPosition);
                        mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs($"Seek to {position.TotalSeconds} seconds"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                    break;

                case '4':
                    // Stop playback
                    mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs("Playback stopped"));
                    break;

                case '0':
                    // Exit the application
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Application closed.");
    }
}
