using System;
using System.IO;

namespace Skynet.Dtos.AudioRecordings
{
    public class UploadAudioRecordingDto
    {
        public Guid AudioRecordingId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? CompanyId { get; set; }

        public string ContentType { get; set; }

        public Stream Content { get; set; }
    }
}