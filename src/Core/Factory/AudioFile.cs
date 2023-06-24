using MediaPlayer.src.Core.Entity;

namespace MediaPlayer.src.Core.Factory
{
    public class AudioFile : IAudioFile
    {
        private string filePath;

        public AudioFile(string filePath)
        {
            this.filePath = filePath;
        }

        public void PlayVAudioFile(User user)
        {
            throw new NotImplementedException();
        }
    }
}