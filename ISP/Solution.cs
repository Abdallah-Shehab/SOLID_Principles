using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IPlayAudio
    {
        void PlayAudio();
    }
    public interface IPlayVideo
    {
        void PlayVideo();
    }
    public interface IDisplaySubtitles
    {
        void DisplaySubtitles();
    }

    public interface ILoadMedia
    {
        void LoadMedia(string filePath);
    }
    public class AudioPlayer : IPlayAudio, ILoadMedia
    {
        public void PlayAudio()
        {

        }
        public void LoadMedia(string filePath)
        {
            // Code to load audio file
        }
    }

    public class VideoPlayer : IPlayVideo, ILoadMedia, IDisplaySubtitles
    {
        public void DisplaySubtitles()
        {
            // Code Here
        }

        public void LoadMedia(string filePath)
        {
            // Code Here
        }

        public void PlayVideo()
        {
            // Code Here
        }
    }
}
