using MediaPlayer.src.Core.Entity;

namespace MediaPlayer.src.Core.Factory
{
    public class VideoFile : IVideoFile
    {
        private string filePath;

        public VideoFile(string filePath)
        {
            this.filePath = filePath;
        }

        public void PlayVideoFile(User user)
        {
            throw new NotImplementedException();
        }
    }
}