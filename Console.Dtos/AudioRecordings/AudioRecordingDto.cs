using System;

namespace Skynet.Dtos.AudioRecordings
{
    public sealed class AudioRecordingDto : AudioRecordingRequest
    {
        public Guid AudioRecordingId { get; set; }

        public Guid? UserId { get; set; }

        public Guid? CompanyId { get; set; }
    }
}