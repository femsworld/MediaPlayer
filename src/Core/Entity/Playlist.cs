#nullable disable
using MediaPlayer.src.Core.Observer;
using MediaPlayer.src.infrastructure;

namespace MediaPlayer.src.Core.Entity
{
public class Playlist
{
    public string PlaylistName { get; set; }
    private List<string> mediaFiles;

    public Playlist(string v)
    {
        mediaFiles = new List<string>();
    }

    public void AddMediaFile(string file)
    {
        mediaFiles.Add(file);
    }

    public void RemoveMediaFile(string file)
    {
        mediaFiles.Remove(file);
    }

    public void Clear()
    {
        mediaFiles.Clear();
    }

    public List<string> GetMediaFiles()
    {
        return mediaFiles;
    }

    public void PlayPlaylist(MediaPlayerManager mediaPlayerManager)
        {
            if (mediaFiles.Count > 0)
            {
                foreach (string file in mediaFiles)
                {
                    Console.WriteLine("Playing: " + file);
                    mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs($"Playing: {file}"));
                    Thread.Sleep(2000);
                }
                Console.WriteLine("Playlist completed.");
            }
            else
            {
                Console.WriteLine("No media files in the playlist.");
            }
        }

        public void PlayAudioFile(string audioFileName, MediaPlayerManager mediaPlayerManager)
        {
            if (mediaFiles.Contains(audioFileName))
            {
                Console.WriteLine("Playing audio file: " + audioFileName);
                // Simulating audio playback
                mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs($"Playing audio file: {audioFileName}"));
            }
            else
            {
                Console.WriteLine("Audio file not found in the playlist.");
            }
        }

        public void PlayVideoFile(string videoFileName, MediaPlayerManager mediaPlayerManager)
        {
            if (mediaFiles.Contains(videoFileName))
            {
                Console.WriteLine("Playing video file: " + videoFileName);
                // Simulating video playback
                mediaPlayerManager.RaiseMediaPlayerEvent(new MediaPlayerEventArgs($"Playing video file: {videoFileName}"));
            }
            else
            {
                Console.WriteLine("Video file not found in the playlist.");
            }
        } 

        public List<string> GetAudioFiles()
        {
            // Simulated implementation to retrieve audio files from a data source
            List<string> audioFiles = new List<string>
            {
                "audio1.mp3",
                "audio2.mp3",
                "audio3.mp3"
            };

            return audioFiles;
        }

        public List<string> GetVideoFiles()
        {
            // Simulated implementation to retrieve video files from a data source
            List<string> videoFiles = new List<string>
            {
                "video1.mp4",
                "video2.mp4",
                "video3.mp4"
            };

            return videoFiles;
        }

}
}