using System.IO;

namespace Skynet.Dtos.AudioRecordings
{
    public class AudioFile
    {
        public AudioFile(string contentType, Stream content)
        {
            ContentType = contentType;
            Content = content;
        }

        public string ContentType { get; }
        public Stream Content { get; }
    }
}